using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Xml;
using Microsoft.Win32;
using Microsoft.MediaCenter.UI;

using GalleryItem = Z.DataSetHelpers.GalleryItem;
using Filter = Z.DataSetHelpers.Filter;
using DetailsCommand = Z.DataSetHelpers.DetailsCommand;

namespace Z
{
    /// <summary>
    /// The Movies experience within the Z application.
    /// </summary>
    public class Movies : ApplicationExperience
    {

        /// <summary>
        /// Construct a Movies experience.
        /// </summary>
        public Movies()
        {
            base.Description = Z.Resources.Movies;

            //
            // Construct a DataSet from an XML document.
            //

            string fileName = "tbl_movie.xml";
            TextReader rawReader = null;
            try
            {
                rawReader = new StreamReader(DataDirectory + fileName);
            }
            catch (DirectoryNotFoundException e)
            {
                // The Z data directory does not exist, therefore Z was not
                // installed correctly
                throw new InvalidOperationException("The Z application data has not been correctly installed.", e);
            }
            XmlReader xmlReader = new XmlTextReader(rawReader);

            dataSet = new DataSet(Description);
            dataSet.ReadXml(xmlReader);


            // To debug your data set you can uncomment this line
            //Z.DataSetHelpers.DumpDataSetContents(dataSet, true);
        }

        #region Menu Category

        /// <summary>
        /// Create the main menu category entry for this experience.
        /// </summary>
        public override MenuCategory CreateMenuCategory()
        {
            MenuCategory category = new MenuCategory();

            // Title
            category.Title = Description;

            // Subtitle (extracted from the total movie count)
            DataTable tbl_Movie = dataSet.Tables["tbl_Movie"];
            string subTitle = String.Format(Z.Resources.Movies_Category_SubTitle, tbl_Movie.Rows.Count);
            category.SubTitle = subTitle;


            //
            // Featured items
            //

            VirtualList items = new VirtualList(category, null);
            items.EnableSlowDataRequests = true;
            items.RequestSlowDataHandler = new RequestSlowDataHandler(CompleteMenuItem);
            category.Items = items;

            DataTable tbl_Movie_And_Highlight = dataSet.Tables["tbl_Movie_And_Highlight"];

            foreach (DataRow highlightData in tbl_Movie_And_Highlight.Rows)
            {
                int movieId = (int)highlightData["Movie_ID"];
                DataRow movieData = GetMovieData(movieId);

                GalleryItem item = CreateGalleryItem(movieData);
                items.Add(item);

                // Stop once we've found 3 items.
                if (category.Items.Count >= 3)
                    break;
            }


            //
            // Set up a handler for when this category is clicked.
            //

            category.Invoked += delegate(object sender, EventArgs args)
            {
                // Go to our gallery page.
                GalleryPage page = CreateGalleryPage();
                Application.Current.GoToGallery(page);
            };

            return category;
        }

        /// <summary>
        /// Finishes any slow data for a menu item.
        /// </summary>
        private void CompleteMenuItem(VirtualList list, int index)
        {
            GalleryItem item = (GalleryItem)list[index];
            DataRow movieData = GetMovieData(item.ItemId);

            // Load the Small image (note that we need to load a different image,
            // than CompleteGalleryItem, which is why the menu uses a different 
            // handler).
            string imageName = (string)movieData["Movie_Image_Gallery_Small"];
            item.Image = LoadImage(imageName);
        }

        #endregion Menu Category

        #region Gallery

        /// <summary>
        /// Create a movies gallery.
        /// NOTE: This is public to enable debug markup access.
        /// </summary>
        public GalleryPage CreateGalleryPage()
        {
            GalleryPage page = new GalleryPage();
            page.Description = Description;

            // Use the large thumbs view.
            page.ItemSize = GalleryItemSize.Large;

            // Create the virtual list and enable slow data.
            VirtualList galleryList = new VirtualList(page, null);
            galleryList.EnableSlowDataRequests = true;
            galleryList.RequestSlowDataHandler = new RequestSlowDataHandler(CompleteGalleryItem);
            page.Content = galleryList;

            // Create and apply the filters.
            CreateGalleryFilters(page);

            return page;
        }

        /// <summary>
        /// Creat the filters on the gallery.
        /// </summary>
        private void CreateGalleryFilters(GalleryPage page)
        {
            //
            // Put together a list of filters on the content.
            //

            ArrayListDataSet list = new ArrayListDataSet(page);

            // Create the unfiltered "All" filter
            ModelItem filterAll = new Filter(page, Z.Resources.Movies_Filter_All, -1);
            list.Add(filterAll);

            // Get the rest of the filters out of the genre list.
            DataTable tbl_Movie_Genre = dataSet.Tables["tbl_Movie_Genre"];
            foreach (DataRow genreData in tbl_Movie_Genre.Rows)
            {
                string genreName = (string)genreData["Movie_Genre_Type"];
                int genreId = (int)genreData["Movie_Genre_Type_ID"];

                ModelItem filter = new Filter(page, genreName, genreId);
                list.Add(filter);
            }

            // FUTURE: There's information in the data table for us to implement
            // a "featured" filter.  Its implementation would go here.
            /*
                Table: tbl_Movie_Highlight
                Row:
                    [Movie_Highlight_ID] = 1
                    [Movie_Highlight] = featured
                    [dataroot_Id] = 0
                Table: tbl_Movie_And_Highlight
                Row:
                    [Movie_And_Highlight_ID] = 1
                    [Movie_ID] = 1
                    [Movie_Highlight_ID] = 1
                    [tbl_Movie_Id] = 5
            */

            Choice filters = new Choice(page, null, list);
            filters.Chosen = filterAll;

            //
            // Hook up the "filter changed" event so that we can apply the
            // active filter to our gallery.
            //
            // As soon as this Filters list is set, we will get an OnActiveFilterChanged
            // event which will cause us to populate the gallery.
            //

            page.ActiveFilterChanged += delegate(object sender, EventArgs e)
            {
                GalleryPage galleryPage = (GalleryPage)sender;
                Filter activeFilter = (Filter)galleryPage.Filters.Chosen;
                FilterContent(galleryPage, activeFilter.FilterId);
            };
            page.Filters = filters;
        }

        /// <summary>
        /// Populate the gallery's content given the current filer.
        /// </summary>
        private void FilterContent(GalleryPage page, int filterId)
        {
            page.Content.Clear();

            //
            // Populate the list with items according to the filter.
            //

            DataTable tbl_Movie = dataSet.Tables["tbl_Movie"];

            if (filterId < 0)
            {
                //
                // A negative filter Id signifies no filter ("All").
                // Populate the list with all entries in the table.
                //

                foreach (DataRow movieData in tbl_Movie.Rows)
                    page.Content.Add(CreateGalleryItem(movieData));
            }
            else
            {
                //
                // Fetch only the entries that have the matching genre type.
                //

                string query = String.Format("Movie_Genre_Type_ID = '{0}'", filterId);
                DataRow[] matches = tbl_Movie.Select(query);
                foreach (DataRow movieData in matches)
                    page.Content.Add(CreateGalleryItem(movieData));
            }
        }

        /// <summary>
        /// Construct a gallery item for a row of data.
        /// </summary>
        private GalleryItem CreateGalleryItem(DataRow movieData)
        {
            GalleryItem item = new GalleryItem();
            item.Description = (string)movieData["Movie_Title"];
            item.ItemId = (int)movieData["Movie_ID"];

            // Display the release year as this item's metadata.
            DateTime releaseDate = (DateTime)movieData["Movie_Release_Date"];
            item.Metadata = releaseDate.Year.ToString();


            //
            // Hook up an event for when the gallery item is invoked.
            //

            item.Invoked += delegate(object sender, EventArgs args)
            {
                GalleryItem galleryItem = (GalleryItem)sender;

                // Navigate to a details page for this item.
                DetailsPage page = CreateDetailsPage(galleryItem.ItemId);
                Application.Current.GoToDetails(page);
            };

            return item;
        }

        /// <summary>
        /// Finishes any slow data for a gallery item.
        /// </summary>
        private void CompleteGalleryItem(VirtualList list, int index)
        {
            GalleryItem item = (GalleryItem)list[index];
            DataRow movieData = GetMovieData(item.ItemId);
            CompleteGalleryItem(item, movieData);
        }

        /// <summary>
        /// Finishes any slow data for a gallery item.
        /// </summary>
        private void CompleteGalleryItem(GalleryItem item, DataRow movieData)
        {
            string imageName = (string)movieData["Movie_Image_Gallery_Large"];
            item.Image = LoadImage(imageName);
        }

        #endregion Gallery

        #region Details

        /// <summary>
        /// Create a details page for a movie.
        /// NOTE: This is public to enable debug markup access.
        /// </summary>
        public DetailsPage CreateDetailsPage(int movieId)
        {
            DetailsPage page = new DetailsPage();

            //
            // Get the full metadata from this row.
            //

            DataRow movieData = GetMovieData(movieId);
            MovieMetadata metadata = ExtractMetadata(movieData, movieId);


            //
            // Fill in the page's easy properties.
            //

            page.Title = metadata.Title;
            page.Summary = metadata.Summary;
            page.Background = LoadImage(metadata.ImagePath);


            //
            // Metadata
            //
            // Now that we have all the little pieces, we can put together our
            // final metadata string.
            //

            string cast = String.Empty;
            foreach (string actor in metadata.Actors)
                Z.DataSetHelpers.AppendCommaSeparatedValue(ref cast, actor);

            page.Metadata = String.Format(Z.Resources.Movies_Details_Metadata,
                metadata.Genre,
                cast,
                metadata.Length,
                metadata.CountryShortName,
                metadata.ReleaseDate.Year);


            //
            // Actions
            //

            CreateDetailsCommands(page, movieData, movieId);

            return page;
        }

        /// <summary>
        /// This struct contains all the metadata we can get from a row of
        /// movies data.
        /// </summary>
        private struct MovieMetadata
        {
            public string Title;
            public string Summary;
            public string Genre;
            public string CountryFullName;
            public string CountryShortName;
            public string Rating;
            public string ImagePath;
            public int Length;
            public DateTime ReleaseDate;
            public List<string> Actors;

            public int Id;
        }

        /// <summary>
        /// This enum must match 1:1 with the options declared in the database.
        /// The database should only be referencing actions that this code
        /// supports.
        /// </summary>
        private enum MoviesDetailsActionType
        {
            Preview = 0,
            Purchase = 1,
            Related = 2,
            Actors = 3,
        }

        /// <summary>
        /// Take the raw movie data row and create a nicely typed struct.
        /// </summary>
        private MovieMetadata ExtractMetadata(DataRow movieData)
        {
            int movieId = (int)movieData["Movie_ID"];
            return ExtractMetadata(movieData, movieId);
        }

        /// <summary>
        /// Take the raw movie data row and create a nicely typed struct.
        /// </summary>
        private MovieMetadata ExtractMetadata(DataRow movieData, int movieId)
        {
            MovieMetadata metadata = new MovieMetadata();
            metadata.Id = movieId;

            metadata.Title = (string)movieData["Movie_Title"];
            metadata.Summary = (string)movieData["Movie_Description"];
            metadata.ImagePath = (string)movieData["Movie_Image_Detail"];
            metadata.Length = (int)movieData["Movie_Length"];
            metadata.ReleaseDate = (DateTime)movieData["Movie_Release_Date"];


            //
            // Actors
            //
            // The association of what actors are in what movies is in a 
            // separate table (tbl_Movie_And_Actor).
            //

            metadata.Actors = new List<string>();

            DataTable tbl_Movie_And_Actor = dataSet.Tables["tbl_Movie_And_Actor"];
            DataTable tbl_Movie_Actor = dataSet.Tables["tbl_Movie_Actor"];

            // Get the entries that match our movie.
            string actorForMovieQuery = String.Format("Movie_ID = '{0}'", movieId);
            DataRow[] movieAndActorMatches = tbl_Movie_And_Actor.Select(actorForMovieQuery);

            foreach (DataRow movieAndActorData in movieAndActorMatches)
            {
                int actorId = (int)movieAndActorData["Movie_Actor_ID"];

                // Look up the extra information on this actor from the actor
                // table.
                string actorQuery = String.Format("Movie_Actor_ID = '{0}'", actorId);
                DataRow[] actorMatches = tbl_Movie_Actor.Select(actorQuery);

                foreach (DataRow actorData in actorMatches)
                {
                    // Append this actor's name to our string.
                    string actorName = (string)actorData["Movie_Actor"];
                    metadata.Actors.Add(actorName);
                }
            }


            //
            // Genre
            //

            DataRow genreData = Z.DataSetHelpers.GetIDMappedDataRow(movieData, "Movie_Genre_Type_ID", 
                dataSet.Tables["tbl_Movie_Genre"], "Movie_Genre_Type_ID");

            metadata.Genre = (string)genreData["Movie_Genre_Type"];


            //
            // Country
            //
            //

            DataRow countryData = Z.DataSetHelpers.GetIDMappedDataRow(movieData, "Movie_Country_ID", 
                dataSet.Tables["tbl_Movie_Country"], "Movie_Country_ID");

            metadata.CountryFullName = (string)countryData["Movie_Country"];
            metadata.CountryShortName = (string)countryData["Movie_Country_Abbrev"];


            //
            // Rating
            //

            DataRow ratingData = Z.DataSetHelpers.GetIDMappedDataRow(movieData, "Movie_Rating_ID", 
                dataSet.Tables["tbl_Movie_Rating"], "Movie_Rating_ID");

            metadata.Rating = (string)ratingData["Movie_Rating"];


            return metadata;
        }

        /// <summary>
        /// Create the commands for the details page.
        /// </summary>
        private void CreateDetailsCommands(DetailsPage page, DataRow movieData, int movieId)
        {
            page.Commands = new ArrayListDataSet(page);

            //
            // We always have a "Preview" command.  Populate that.
            //

            string previewContent = (string)movieData["Movie_Preview_Content"];
            CreateDetailsCommand(page, Z.Resources.Movies_Details_Preview, (int)MoviesDetailsActionType.Preview, previewContent, movieId);


            //
            // There is a list of actions associated with each movie.
            // We need to walk through the movie->action table (tbl_Movie_And_Action)
            // and build a list of Commands for each entry.
            //

            DataTable tbl_Movie_And_Action = dataSet.Tables["tbl_Movie_And_Action"];
            DataTable tbl_Movie_Action = dataSet.Tables["tbl_Movie_Action"];

            // Get the matching actions specified by our movie.
            string query = String.Format("Movie_ID = '{0}'", movieId);
            DataRow[] movieActionMatches = tbl_Movie_And_Action.Select(query);

            foreach (DataRow movieAndActionData in movieActionMatches)
            {
                // Look up the standard type of this action
                DataRow actionTypeData = Z.DataSetHelpers.GetIDMappedDataRow(movieAndActionData, "Movie_Action_ID", 
                    tbl_Movie_Action, "Movie_Action_ID");
                string actionName = (string)actionTypeData["Movie_Action"];
                int actionTypeId = (int)actionTypeData["Movie_Action_ID"];

                // Some actions have a "value" associated with them.
                string value = (string)movieAndActionData["Movie_Action_Value"];

                CreateDetailsCommand(page, actionName, actionTypeId, value, movieId);
            }
        }

        /// <summary>
        /// Create a single details page command.
        /// </summary>
        private void CreateDetailsCommand(DetailsPage page, string description, int type, string value, int itemId)
        {
            DetailsCommand command = new DetailsCommand(page, description);
            command.Type = type;
            command.Value = value;
            command.ItemId = itemId;

            // Hook up the event handler.  This handler will disambiguate
            // what the actual action that should occur based on the item's
            // action type.
            command.Invoked += delegate(object sender, EventArgs e)
            {
                OnDetailsActionInvoked((DetailsCommand)sender);
            };

            page.Commands.Add(command);
        }

        /// <summary>
        /// Called when one of the custom actions on a details page is clicked.
        /// </summary>
        private void OnDetailsActionInvoked(DetailsCommand command)
        {
            MoviesDetailsActionType actionType = (MoviesDetailsActionType)command.Type;
            string value = command.Value;
            int movieId = command.ItemId;

            //
            // Interpret the action.
            //

            switch (actionType)
            {
                case MoviesDetailsActionType.Preview:
                    //
                    // Preview = Play the movie
                    //

                    string path = VideosDirectory + value;
                    Debug.WriteLine(path);

                    if (Application.Current.MediaCenterEnvironment != null)
                        Application.Current.MediaCenterEnvironment.PlayMedia(Microsoft.MediaCenter.MediaType.Video, path, false);
                    else
                        Debug.WriteLine("DetailsAction: Play " + path);
                    break;

                case MoviesDetailsActionType.Purchase:
                    //
                    // Purchase = Download the movie
                    //

                    // Only download if the item is not actively being downloaded
                    //
                    // FUTURE: Z should maintain a persisted list of all media items
                    // downloaded;  that way, the end-user wouldn't end up buying and
                    // downloading the same media item twice.
                    // When implementing this, the UI for already downloaded items
                    // should replace "purchase" with "play"

                    bool alreadyDownloading = false;
                    foreach (SearchResult item in ActiveDownloads)
                    {
                        if (item.Id == movieId)
                        {
                            alreadyDownloading = true;
                            break;
                        }
                    }
                    if (!alreadyDownloading)
                    {
                        DataRow movieData = GetMovieData(movieId);
                        string title = (string)movieData["Movie_Title"];

                        if (Application.Current.MediaCenterEnvironment != null)
                        {
                            //
                            // Display a dialog telling the user that download was started.
                            //

                            string dialogText = String.Format(Z.Resources.Movies_DownloadDialog_Text, title);

                            Application.Current.MessageBox(dialogText, Z.Resources.Movies_DownloadDialog_Caption);
                        }

                        // Create a search result for the movie that the
                        // Downloads page can use to show downloads
                        SearchResult item = CreateSearchResult(movieData);

                        // The source location was retrieved from the data table
                        // and stored in the Value property of the DetailsCommand
                        // that initiated this download.  Convert that to a Uri.
                        Uri source = new Uri(command.Value);

                        // Construct the destination path by appending the file
                        // name from the source onto the path for the Z
                        // subdirectory in the public videos folder
                        string[] segments = source.Segments;
                        string fileName = segments[segments.Length - 1];

                        Debug.WriteLine("DetailsAction: Downloading " + movieId);
                    }
                    else
                    {
                        Debug.WriteLine("DetailsAction: Already downloading " + movieId);
                    }
                    break;

                default:
                    Debug.WriteLine(String.Format("DetailsAction: {0}({1}): NOT YET IMPLEMENTED", actionType, value));
                    break;
            }
        }

        #endregion Details

        #region Search And Downloads

        /// <summary>
        /// Return results for items that match the search string.
        /// </summary>
        public override IList<SearchResult> Search(string value)
        {
            IList<SearchResult> results = new List<SearchResult>();

            //
            // Search the movies table for items that have this search
            // string in their title.
            //

            DataTable tbl_Movie = dataSet.Tables["tbl_Movie"];
            string query = String.Format("Movie_Title LIKE '*{0}*'", value);
            DataRow[] matches = tbl_Movie.Select(query);

            foreach (DataRow movieData in matches)
            {
                SearchResult item = CreateSearchResult(movieData);
                results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Fill in all the metadata on serach result.
        /// </summary>
        private SearchResult CreateSearchResult(DataRow movieData)
        {
            // Grab all the available metadata from the data source.
            MovieMetadata metadata = ExtractMetadata(movieData);

            // Create the search result object 
            SearchResult item = new SearchResult(metadata.Id);
            item.Type = Z.Resources.Movies_Search_Type;

            //
            // Fill in all the string metadata.
            //

            item.Description = metadata.Title;

            string cast = String.Empty;
            foreach (string actor in metadata.Actors)
                Z.DataSetHelpers.AppendCommaSeparatedValue(ref cast, actor);

            item.Metadata1 = String.Format(Z.Resources.Movies_Search_Metadata1,
                metadata.Genre,
                cast,
                metadata.Length,
                metadata.CountryShortName,
                metadata.ReleaseDate.Year);

            item.Metadata2 = String.Format(Z.Resources.Movies_Search_Metadata2,
                metadata.Genre,
                cast,
                metadata.Length,
                metadata.CountryShortName,
                metadata.ReleaseDate.Year);

            //
            // Load the image.
            //

            string imageName = (string)movieData["Movie_Image_Gallery_Small"];
            item.Image = LoadImage(imageName);


            // Hook up an invoked handler
            item.Invoked += delegate(object sender, EventArgs args)
            {
                SearchResult searchResult = (SearchResult) sender;

                // Navigate to a details page for this item.
                DetailsPage page = CreateDetailsPage(searchResult.Id);
                Application.Current.GoToDetails(page);
            };

            return item;
        }

        #endregion Search And Downloads

        /// <summary>
        /// Get a movie data row given a unique id.
        /// </summary>
        private DataRow GetMovieData(int itemId)
        {
            DataTable tbl_Movie = dataSet.Tables["tbl_Movie"];
            return Z.DataSetHelpers.GetSingleDataRow(tbl_Movie, "Movie_ID", itemId);
        }

        /// <summary>
        /// Helper method to load an image from our data directory.
        /// </summary>
        private static Image LoadImage(string imageName)
        {
            try
            {
                return new Image("file://" + ImagesDirectory + imageName);
            }
            catch (Exception)
            {
                Debug.WriteLine("Error loading image: " + imageName);
            }

            return null;
        }

        private DataSet dataSet;
    }
}
