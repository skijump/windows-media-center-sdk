using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Xml;

using Microsoft.MediaCenter;
using Microsoft.MediaCenter.UI;

using Microsoft.MediaCenter.TV.Scheduling;

using GalleryItem = Z.DataSetHelpers.GalleryItem;
using Filter = Z.DataSetHelpers.Filter;
using DetailsCommand = Z.DataSetHelpers.DetailsCommand;

namespace Z
{
    /// <summary>
    /// The TV experience within the Z application.
    /// </summary>
    public class TV : ApplicationExperience
    {
        /// <summary>
        /// Construct a TV experience.
        /// </summary>
        public TV()
        {
            base.Description = Z.Resources.TV;

            //
            // Construct a DataSet from an XML document.
            //

            string fileName = "tbl_tv.xml";
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

            // Subtitle (extracted from the total episode count)
            DataTable tbl_TV_Show = dataSet.Tables["tbl_TV_Show"];
            string subTitle = String.Format(Z.Resources.TV_Category_SubTitle, tbl_TV_Show.Rows.Count);
            category.SubTitle = subTitle;


            //
            // Featured items
            //

            VirtualList items = new VirtualList(category, null);
            items.EnableSlowDataRequests = true;
            items.RequestSlowDataHandler = new RequestSlowDataHandler(CompleteEpisodeGalleryItem);
            category.Items = items;

            DataTable tbl_TV_Episode_And_Highlight = dataSet.Tables["tbl_TV_Episode_And_Highlight"];
            DataTable tbl_TV_Episode = dataSet.Tables["tbl_TV_Episode"];

            foreach (DataRow highlightData in tbl_TV_Episode_And_Highlight.Rows)
            {
                int episodeId = (int)highlightData["TV_Episode_ID"];
                DataRow episodeData = GetEpisodeData(episodeId);

                GalleryItem item = CreateEpisodeGalleryItem(episodeData);
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
                // Go to our show gallery page.
                GalleryPage page = CreateShowGalleryPage();
                Application.Current.GoToGallery(page);
            };

            return category;
        }

        #endregion Menu Category

        #region Show Gallery

        /// <summary>
        /// Create the gallery page for this exprience.
        /// NOTE: This is public to enable debug markup access.
        /// </summary>
        public GalleryPage CreateShowGalleryPage()
        {
            GalleryPage page = new GalleryPage();
            page.Description = Description;


            // Create the virtual list and enable slow data.
            VirtualList galleryList = new VirtualList(page, null);
            galleryList.EnableSlowDataRequests = true;
            galleryList.RequestSlowDataHandler = new RequestSlowDataHandler(CompleteShowGalleryItem);
            page.Content = galleryList;

            // Create and apply the filters.
            CreateShowGalleryFilters(page);

            return page;
        }

        /// <summary>
        /// Creat the filters on the gallery.
        /// </summary>
        private void CreateShowGalleryFilters(GalleryPage page)
        {
            //
            // Put together a list of filters on the content.
            //

            ArrayListDataSet list = new ArrayListDataSet(page);

            // Create the unfiltered "All" filter
            ModelItem filterAll = new Filter(page, Z.Resources.TV_Filter_All, -1);
            list.Add(filterAll);

            // Get the rest of the filters out of the genre list.
            DataTable tbl_TV_Genre = dataSet.Tables["tbl_TV_Genre"];
            foreach (DataRow genreData in tbl_TV_Genre.Rows)
            {
                string genreName = (string)genreData["TV_Genre"];
                int genreId = (int)genreData["TV_Genre_ID"];

                ModelItem filter = new Filter(page, genreName, genreId);
                list.Add(filter);
            }

            // FUTURE: There's information in the data table for us to implement
            // a "featured" filter.  Its implementation would go here.

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

            DataTable tbl_TV_Show = dataSet.Tables["tbl_TV_Show"];

            if (filterId < 0)
            {
                //
                // A negative filter Id signifies no filter ("All").
                // Populate the list with all entries in the table.
                //

                foreach (DataRow showData in tbl_TV_Show.Rows)
                    page.Content.Add(CreateShowGalleryItem(showData));
            }
            else
            {
                //
                // Fetch only the entries that have the matching genre type.
                //

                string query = String.Format("TV_Genre_ID = '{0}'", filterId);
                DataRow[] matches = tbl_TV_Show.Select(query);
                foreach (DataRow showData in matches)
                    page.Content.Add(CreateShowGalleryItem(showData));
            }
        }

        /// <summary>
        /// Create a gallery item from a row in the table.
        /// </summary>
        private GalleryItem CreateShowGalleryItem(DataRow showData)
        {
            GalleryItem item = new GalleryItem();
            item.Description = (string)showData["TV_Show_Title"];
            item.ItemId = (int)showData["TV_Show_ID"];

            // Display the show provider in the metadata
            DataRow providerData = Z.DataSetHelpers.GetIDMappedDataRow(showData, "TV_Provider_ID",
                dataSet.Tables["tbl_TV_Provider"], "TV_Provider_ID");
            item.Metadata = (string)providerData["TV_Provider"];

            //
            // Hook up an event for when the gallery item is invoked.
            //

            item.Invoked += delegate(object sender, EventArgs args)
            {
                GalleryItem galleryItem = (GalleryItem)sender;

                // Navigate to a gallery page for this show.
                GalleryPage page = CreateEpisodeGalleryPage(galleryItem.ItemId);
                Application.Current.GoToGallery(page);
            };

            return item;
        }

        /// <summary>
        /// Finishes any slow data for a gallery item.
        /// </summary>
        private void CompleteShowGalleryItem(VirtualList list, int index)
        {
            GalleryItem item = (GalleryItem)list[index];
            DataRow showData = GetShowData(item.ItemId);
            CompleteShowGalleryItem(item, showData);
        }

        /// <summary>
        /// Fill in any slow data for a gallery item.
        /// </summary>
        private void CompleteShowGalleryItem(GalleryItem item, DataRow showData)
        {
            string imageName = (string)showData["TV_Show_Image"];
            item.Image = LoadImage(imageName);
        }

        #endregion Show Gallery

        #region Episode Gallery

        /// <summary>
        /// Create a gallery of episodes from a show.
        /// NOTE: This is public to enable debug markup access.
        /// </summary>
        public GalleryPage CreateEpisodeGalleryPage(int showId)
        {
            DataRow showData = GetShowData(showId);

            GalleryPage page = new GalleryPage();
            page.Description = (string)showData["TV_Show_Title"];

            // Create the virtual list and enable slow data.
            VirtualList galleryList = new VirtualList(page, null);
            galleryList.EnableSlowDataRequests = true;
            galleryList.RequestSlowDataHandler = new RequestSlowDataHandler(CompleteEpisodeGalleryItem);
            page.Content = galleryList;

            // No filters in the episode gallery
            page.Filters = null;

            //
            // Create all the gallery items.
            //

            DataTable tbl_TV_Episode = dataSet.Tables["tbl_TV_Episode"];

            string query = String.Format("TV_Show_ID = '{0}'", showId);
            DataRow[] matches = tbl_TV_Episode.Select(query);
            foreach (DataRow episodeData in matches)
                page.Content.Add(CreateEpisodeGalleryItem(episodeData));

            return page;
        }

        /// <summary>
        /// Create a gallery item from a row of episode data.
        /// </summary>
        private GalleryItem CreateEpisodeGalleryItem(DataRow episodeData)
        {
            GalleryItem item = new GalleryItem();
            item.Description = (string)episodeData["TV_Episode_Title"];
            item.ItemId = (int)episodeData["TV_Episode_ID"];

            // Show the release data of the episode in the metadata.
            DateTime releaseDate = (DateTime)episodeData["TV_Episode_Release_Date"];
            item.Metadata = releaseDate.ToString("d");

            //
            // Hook up an event for when the gallery item is invoked.
            //

            item.Invoked += delegate(object sender, EventArgs args)
            {
                GalleryItem galleryItem = (GalleryItem)sender;

                // Navigate to a details page for this episode.
                DetailsPage page = CreateEpisodeDetailsPage(galleryItem.ItemId);
                Application.Current.GoToDetails(page);
            };

            return item;
        }

        /// <summary>
        /// Finishes any slow data for an episode gallery item.
        /// </summary>
        private void CompleteEpisodeGalleryItem(VirtualList list, int index)
        {
            GalleryItem item = (GalleryItem)list[index];
            DataRow episodeData = GetEpisodeData(item.ItemId);
            CompleteEpisodeGalleryItem(item, episodeData);
        }

        /// <summary>
        /// Fill in any slow data for an episode gallery item.
        /// </summary>
        private void CompleteEpisodeGalleryItem(GalleryItem item, DataRow episodeData)
        {
            string imageName = (string)episodeData["TV_Episode_Gallery_Image"];
            item.Image = LoadImage(imageName);
        }

        #endregion Episode Gallery

        #region Episode Details

        /// <summary>
        /// Create a details page for an episode.
        /// NOTE: This is public to enable debug markup access.
        /// </summary>
        public DetailsPage CreateEpisodeDetailsPage(int episodeId)
        {
            DetailsPage page = new DetailsPage();

            //
            // Get the full metadata on the episode.
            //

            DataRow episodeData = GetEpisodeData(episodeId);
            EpisodeMetadata episodeMetadata = ExtractEpisodeMetadata(episodeData, episodeId);


            //
            // Get the full metadata on the show.
            //

            DataRow showData = GetShowData(episodeMetadata.ShowId);
            ShowMetadata showMetadata = ExtractShowMetadata(showData, episodeMetadata.ShowId);


            //
            // Fill in the page's easy properties.
            //

            page.Title = episodeMetadata.Title;
            page.Summary = episodeMetadata.Summary;
            page.Background = LoadImage(episodeMetadata.DetailImagePath);


            //
            // Metadata
            //
            // Now that we have all the little pieces, we can put together our
            // final metadata string.
            //

            page.Metadata = String.Format(Z.Resources.TV_Details_Metadata,
                showMetadata.Provider,
                episodeMetadata.Season,
                showMetadata.Genre,
                episodeMetadata.Length,
                showMetadata.CountryShortName,
                episodeMetadata.ReleaseDate.Year);


            //
            // Actions
            //

            CreateEpisodeDetailsCommands(page, episodeData, episodeId);

            return page;
        }

        /// <summary>
        /// This struct contains all the metadata we can get from a row of
        /// episode data.
        /// </summary>
        private struct EpisodeMetadata
        {
            public string Title;
            public string Summary;
            public string GalleryImagePath;
            public string DetailImagePath;
            public string Rating;
            public int Length;
            public int Season;
            public DateTime ReleaseDate;

            public int Id;
            public int ShowId;
        }

        /// <summary>
        /// This enum must match 1:1 with the options declared in the database.
        /// The database should only be referencing actions that this code
        /// supports.
        /// </summary>
        private enum TVEpisodeDetailsActionType
        {
            WatchNow = 1,
            Record = 2,
            Related = 3,
            Actors = 4,
        }

        /// <summary>
        /// Take the raw episode data row and create a nicely typed struct.
        /// </summary>
        private EpisodeMetadata ExtractEpisodeMetadata(DataRow episodeData, int episodeId)
        {
            EpisodeMetadata metadata = new EpisodeMetadata();

            metadata.Title = (string)episodeData["TV_Episode_Title"];
            metadata.Summary = (string)episodeData["TV_Episode_Description"];
            metadata.GalleryImagePath = (string)episodeData["TV_Episode_Gallery_Image"];
            metadata.DetailImagePath = (string)episodeData["TV_Episode_Detail_Image"];
            metadata.Length = (int)episodeData["TV_Episode_Length"];
            metadata.Season = (int)episodeData["TV_Episode_Season"];
            metadata.ReleaseDate = (DateTime)episodeData["TV_Episode_Release_Date"];

            metadata.Id = (int)episodeData["TV_Episode_ID"];
            metadata.ShowId = (int)episodeData["TV_Show_ID"];

            
            //
            // Rating
            //

            DataRow rating = Z.DataSetHelpers.GetIDMappedDataRow(episodeData, "TV_Rating_ID",
                dataSet.Tables["tbl_TV_Rating"], "TV_Rating_ID");

            metadata.Rating = (string)rating["TV_Rating"];


            return metadata;
        }

        /// <summary>
        /// Create the commands for the episode details page.
        /// </summary>
        private void CreateEpisodeDetailsCommands(DetailsPage page, DataRow episodeData, int episodeId)
        {
            page.Commands = new ArrayListDataSet(page);

            //
            // There is a list of actions associated with each episode.
            // We need to walk through the episode->action table (tbl_TV_And_Action)
            // and build a list of Commands for each entry.
            //

            DataTable tbl_TV_Episode_And_Action = dataSet.Tables["tbl_TV_Episode_And_Action"];
            DataTable tbl_TV_Action = dataSet.Tables["tbl_TV_Action"];

            // Get the matching actions specified by our item.
            string query = String.Format("TV_Episode_ID = '{0}'", episodeId);
            DataRow[] episodeAndActionMatches = tbl_TV_Episode_And_Action.Select(query);

            foreach (DataRow episodeAndActionData in episodeAndActionMatches)
            {
                // Look up the standard type of this action
                DataRow actionTypeData = Z.DataSetHelpers.GetIDMappedDataRow(episodeAndActionData, "TV_Action_ID",
                    tbl_TV_Action, "TV_Action_ID");
                string actionName = (string)actionTypeData["TV_Action"];
                int actionTypeId = (int)actionTypeData["TV_Action_ID"];

                // Some actions have a "value" associated with them.
                // TODO: Needs to be added to data source.
                //string value = (string)episodeAndActionData["TV_Action_Value"];
                string value = null;

                CreateEpisodeDetailsCommand(page, actionName, actionTypeId, value, episodeId);
            }
        }

        /// <summary>
        /// Create a single episode details page command.
        /// </summary>
        private void CreateEpisodeDetailsCommand(DetailsPage page, string description, int type, string value, int itemId)
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
                OnEpisodeDetailsActionInvoked((DetailsCommand)sender);
            };

            page.Commands.Add(command);
        }

        /// <summary>
        /// Called when one of the custom actions on a details page is clicked.
        /// </summary>
        private void OnEpisodeDetailsActionInvoked(DetailsCommand command)
        {
            TVEpisodeDetailsActionType actionType = (TVEpisodeDetailsActionType)command.Type;
            string value = command.Value;
            int episodeId = command.ItemId;

            //
            // Interpret the action.
            //

            switch (actionType)
            {
                case TVEpisodeDetailsActionType.WatchNow:
                {
                    // Placeholder...
                    break;
                }

                case TVEpisodeDetailsActionType.Record:
                {
                    //
                    // TODO: Grab the xml from the database
                    //
                    // As is this code schedules a manual 30 minute recording to 
                    // occur 1 hour from now on channel 4.
                    //

                    string xmlRecordingInfoFormat = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<clickToRecord xmlns=\"urn:schemas-microsoft-com:ehome:clicktorecord\">\n\t<body>\n\t\t<programRecord programDuration=\"30\">\n\t\t\t<service>\n\t\t\t\t<key field=\"urn:schemas-microsoft-com:ehome:epg:service#mappedChannelNumber\" match=\"exact\">{0}</key>\n\t\t\t</service>\n\t\t\t<airing>\n\t\t\t\t<key field=\"urn:schemas-microsoft-com:ehome:epg:airing#starttime\">{1}</key>\n\t\t\t</airing>\n\t\t</programRecord>\n\t</body>\n</clickToRecord>";
                    int channelNumber = 4;
                    DateTime time = DateTime.UtcNow.AddHours(1);
                    string xmlRecordingInfo = String.Format(xmlRecordingInfoFormat, channelNumber, time.ToString("o"));

                    XmlReader reader = XmlReader.Create(new StringReader(xmlRecordingInfo));


                    CreateScheduleRequestResult scheduleResult = CreateScheduleRequestResult.NoConfiguredResource;
                    try
                    {
                        //
                        // Create EventSchedule object and create ScheduleRequest from XML.
                        //

                        EventSchedule scheduler = new EventSchedule();
                        ScheduleRequest request = null;
                        scheduleResult = scheduler.CreateScheduleRequest(reader, ConflictResolutionPolicy.AllowConflict, "example", out request);

                        Debug.WriteLine("DetailsAction: Record: " + scheduleResult);
                    }
                    catch (EventScheduleException)
                    {
                        // TV may not be configured - handle that exception.
                        Application.Current.MessageBox(Z.Resources.TV_NotSetUpDialog_Text, Z.Resources.TV_NotSetUpDialog_Caption);
                    }


                    //
                    // Display a dialog to notify the user.
                    //

                    if ((scheduleResult != CreateScheduleRequestResult.NoConfiguredResource) && 
                        (Application.Current.MediaCenterEnvironment != null))
                    {
                        EpisodeMetadata metadata = ExtractEpisodeMetadata(GetEpisodeData(episodeId), episodeId);

                        // Two options: "View Scheduled" or "OK"
                        IEnumerable buttons = new object[] {
                            Z.Resources.TV_RecordDialog_ViewScheduled,
                            (int)DialogButtons.Ok
                        };

                        // Use the gallery image in the dialog.
                        // Note that the Dialog API requires a standard Uri, so we
                        // need to specificy the system drive letter.
                        string systemDrive = Environment.GetEnvironmentVariable("SystemDrive");
                        string imagePath = "file://" + systemDrive + ImagesDirectory + metadata.GalleryImagePath;

                        Application.Current.MediaCenterEnvironment.Dialog(
                            Z.Resources.TV_RecordDialog_Text,
                            metadata.Title,
                            buttons,
                            0, true,
                            imagePath,
                            delegate(DialogResult dialogResult)
                            {
                                // Custom button #1 = 100 = "View Scheduled"
                                // Navigate to the scheduled recordings page
                                if ((int)dialogResult == 100)
                                    Application.Current.MediaCenterEnvironment.NavigateToPage(PageId.ScheduledTVRecordings, null);

                                Debug.WriteLine("Dialog closed:" + dialogResult);
                            }
                        );
                    }
                    break;
                }

                case TVEpisodeDetailsActionType.Related:
                {
                    //
                    // Go to this episode's show gallery.
                    //

                    EpisodeMetadata metadata = ExtractEpisodeMetadata(GetEpisodeData(episodeId), episodeId);
                    GalleryPage page = CreateEpisodeGalleryPage(metadata.ShowId);
                    Application.Current.GoToGallery(page);
                    break;
                }


                default:
                    Debug.WriteLine(String.Format("DetailsAction: {0}({1}): NOT YET IMPLEMENTED", actionType, value));
                    break;
            }
        }

        #endregion Episode Details

        #region Show Details

        /// <summary>
        /// This struct contains all the metadata we can get from a row of
        /// show data.
        /// </summary>
        private struct ShowMetadata
        {
            public string Title;
            public string Provider;
            public string Genre;
            public string CountryShortName;
            public string CountryFullName;

            public int Id;
        }

        /// <summary>
        /// Take the raw show data row and create a nicely typed struct.
        /// </summary>
        private ShowMetadata ExtractShowMetadata(DataRow showData, int showId)
        {
            ShowMetadata metadata = new ShowMetadata();
            metadata.Id = showId;

            metadata.Title = (string)showData["TV_Show_Title"];

            //
            // Provider
            //

            DataRow providerData = Z.DataSetHelpers.GetIDMappedDataRow(showData, "TV_Provider_ID",
                dataSet.Tables["tbl_TV_Provider"], "TV_Provider_ID");

            metadata.Provider = (string)providerData["TV_Provider"];

            //
            // Genre
            //

            DataRow genreData = Z.DataSetHelpers.GetIDMappedDataRow(showData, "TV_Genre_ID",
                dataSet.Tables["tbl_TV_Genre"], "TV_Genre_ID");

            metadata.Genre = (string)genreData["TV_Genre"];

            //
            // Country
            //

            DataRow countryData = Z.DataSetHelpers.GetIDMappedDataRow(showData, "TV_Country_ID",
                dataSet.Tables["tbl_TV_Country"], "TV_Country_ID");

            metadata.CountryFullName = (string)countryData["TV_Country"];
            metadata.CountryShortName = (string)countryData["TV_Country_Abbrev"];

            return metadata;
        }

        #endregion Show Details

        /// <summary>
        /// Return Commands for items that match the search string.
        /// </summary>
        public override IList<SearchResult> Search(string value)
        {
            IList<SearchResult> results = new List<SearchResult>();

            //
            // Episodes
            //
            // Search the episode table for items that have this search
            // string in their title.
            //

            DataTable tbl_TV_Episode = dataSet.Tables["tbl_TV_Episode"];
            string query = String.Format("TV_Episode_Title LIKE '*{0}*'", value);
            DataRow[] matches = tbl_TV_Episode.Select(query);

            foreach (DataRow episodeData in matches)
            {
                int episodeId = (int)episodeData["TV_Episode_ID"];

                // Create the search result object 
                SearchResult item = new SearchResult(episodeId);
                item.Description = (string)episodeData["TV_Episode_Title"];
                item.Type = Z.Resources.TV_Search_Type_Episode;

                string imageName = (string)episodeData["TV_Episode_Gallery_Image"];
                item.Image = LoadImage(imageName);

                // Hook up an invoked handler
                item.Invoked += delegate(object sender, EventArgs args)
                {
                    SearchResult searchResult = (SearchResult) sender;

                    // Navigate to a details page for this item.
                    DetailsPage page = CreateEpisodeDetailsPage(searchResult.Id);
                    Application.Current.GoToDetails(page);
                };

                results.Add(item);
            }


            //
            // Shows
            //
            // Search the show table for items that have this search
            // string in their title.
            //

            DataTable tbl_TV_Show = dataSet.Tables["tbl_TV_Show"];
            query = String.Format("TV_Show_Title LIKE '*{0}*'", value);
            matches = tbl_TV_Show.Select(query);

            foreach (DataRow showData in matches)
            {
                int showId = (int)showData["TV_Show_ID"];

                // Create the search result object 
                SearchResult item = new SearchResult(showId);
                item.Description = (string)showData["TV_Show_Title"];
                item.Type = Z.Resources.TV_Search_Type_Show;

                string imageName = (string)showData["TV_Show_Image"];
                item.Image = LoadImage(imageName);

                // Hook up an invoked handler
                item.Invoked += delegate(object sender, EventArgs args)
                {
                    SearchResult searchResult = (SearchResult) sender;

                    // Navigate to a gallery page for this item.
                    GalleryPage page = CreateEpisodeGalleryPage(searchResult.Id);
                    Application.Current.GoToGallery(page);
                };

                results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Get a show data row given a unique id.
        /// </summary>
        private DataRow GetShowData(int showId)
        {
            DataTable tbl_TV_Show = dataSet.Tables["tbl_TV_Show"];
            return Z.DataSetHelpers.GetSingleDataRow(tbl_TV_Show, "TV_Show_ID", showId);
        }

        /// <summary>
        /// Get a show data row given a unique id.
        /// </summary>
        private DataRow GetEpisodeData(int episodeId)
        {
            DataTable tbl_TV_Episode = dataSet.Tables["tbl_TV_Episode"];
            return Z.DataSetHelpers.GetSingleDataRow(tbl_TV_Episode, "TV_Episode_ID", episodeId);
        }

        /// <summary>
        /// Helper method to load an image from our data directory.
        /// </summary>
        private Image LoadImage(string imageName)
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
