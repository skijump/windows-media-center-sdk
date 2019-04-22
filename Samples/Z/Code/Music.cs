using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Xml;

using Microsoft.MediaCenter;
using Microsoft.MediaCenter.UI;

namespace Z
{
    /// <summary>
    /// The Music experience within the Z application.
    /// </summary>
    public class Music : ApplicationExperience
    {
        /// <summary>
        /// Construct a Music experience.
        /// </summary>
        public Music()
        {
            base.Description = Z.Resources.Music;

            // These images are used in the gallery when no better thumbnail
            // can be found.
            fileImage = new Image("resx://Z/Z.Resources/MusicFile");
            directoryImage = new Image("resx://Z/Z.Resources/MusicDirectory");
        }

        /// <summary>
        /// Create the main menu category entry for this experience.
        /// </summary>
        public override MenuCategory CreateMenuCategory()
        {
            MenuCategory category = new MenuCategory();
            category.Title = Description;

            //
            // Featured items
            //

            VirtualList items = new VirtualList(category, null);
            items.EnableSlowDataRequests = true;
            items.RequestSlowDataHandler = new RequestSlowDataHandler(CompleteGalleryItem);
            category.Items = items;

            DirectoryInfo directory = GetDirectory(MusicDirectory);
            if (directory != null)
                PopulateGallery(category, items, directory);


            //
            // Set up a handler for when this category is clicked.
            //

            category.Invoked += delegate(object sender, EventArgs args)
            {
                // Go to our root gallery page.
                GalleryPage page = CreateGalleryPage(MusicDirectory);
                Application.Current.GoToGallery(page);
            };

            return category;
        }

        /// <summary>
        /// Create a music gallery.
        /// NOTE: This is public to enable debug markup access.
        /// </summary>
        public GalleryPage CreateGalleryPage(string path)
        {
            GalleryPage page = new GalleryPage();

            // Create the virtual list and enable slow data.
            VirtualList galleryList = new VirtualList(page, null);
            galleryList.EnableSlowDataRequests = true;
            galleryList.RequestSlowDataHandler = new RequestSlowDataHandler(CompleteGalleryItem);
            page.Content = galleryList;

            DirectoryInfo directory = GetDirectory(path);
            if (directory != null)
            {
                //
                // Populate the gallery with the contents of this folder.
                //

                page.Description = directory.Name;

                PopulateGallery(page, page.Content, directory);
            }
            else
            {
                //
                // This directory does not exist.
                // Present an empty gallery.
                //

                page.Description = Z.Resources.Music;
            }

            return page;
        }

        /// <summary>
        /// Create gallery items for all the subdirectories and music files found in the given directory.
        /// </summary>
        private void PopulateGallery(IModelItemOwner owner, IList list, DirectoryInfo directory)
        {
            //
            // Subdirectories
            //

            DirectoryInfo[] subdirectories = directory.GetDirectories();

            if (subdirectories != null)
            {
                foreach (DirectoryInfo subdirectory in subdirectories)
                {
                    ThumbnailCommand item = CreateDirectoryGalleryItem(owner, subdirectory);
                    if (item != null)
                        list.Add(item);
                }
            }


            //
            // Files
            //

            FileInfo[] files = directory.GetFiles();

            if (files != null)
            {
                foreach (FileInfo file in files)
                {
                    ThumbnailCommand item = CreateFileGalleryItem(owner, file);
                    if (item != null)
                        list.Add(item);
                }
            }
        }

        /// <summary>
        /// Create a gallery item to represent a directory.
        /// </summary>
        private ThumbnailCommand CreateDirectoryGalleryItem(IModelItemOwner owner, DirectoryInfo info)
        {
            // Create the command
            ThumbnailCommand item = new ThumbnailCommand(owner);
            item.Description = info.Name;
            item.Image = directoryImage;
            item.Data["Path"] = info.FullName;

            // Hook up the invoked handler
            item.Invoked += delegate(object sender, EventArgs args)
            {
                ThumbnailCommand invokedDirectory = (ThumbnailCommand)sender;
                string path = (string)invokedDirectory.Data["Path"];

                // When invoked navigate to a new gallery page for this directory
                GalleryPage newPage = CreateGalleryPage(path);
                Application.Current.GoToGallery(newPage);
            };

            return item;
        }

        /// <summary>
        /// Create a gallery item to represent a file.
        /// This method may return null if it decides to not include this file.
        /// </summary>
        private ThumbnailCommand CreateFileGalleryItem(IModelItemOwner owner, FileInfo info)
        {
            // Only list WMA and MP3 file types
            string extension = FilterExtension(info.Extension);
            if ((extension != "wma") && (extension != "mp3"))
                return null;

            // Create the command
            ThumbnailCommand item = new ThumbnailCommand(owner);
            item.Description = info.Name;
            item.Metadata = extension;
            item.Image = fileImage;
            item.Data["Path"] = info.FullName;

            // Hook up the invoked handler
            item.Invoked += delegate(object sender, EventArgs args)
            {
                ThumbnailCommand invokedFile = (ThumbnailCommand)sender;
                string path = (string)invokedFile.Data["Path"];

                //
                // When invoked play the audio file
                //

                if (Application.Current.MediaCenterEnvironment != null)
                {
                    // Play
                    Application.Current.MediaCenterEnvironment.PlayMedia(MediaType.Audio, path, true);

                    // Display a notification that will time out.
                    Application.Current.MessageBox(Z.Resources.Music_PlayDialog_Text, invokedFile.Description, 4, false);
                }
                else
                {
                    Debug.WriteLine("Play " + path);
                }
            };

            return item;
        }

        /// <summary>
        /// Preprocess a raw extension into a common format.
        /// </summary>
        private string FilterExtension(string extension)
        {
            if (String.IsNullOrEmpty(extension))
                return String.Empty;

            // Normalize the extension value
            extension = extension.ToLower();
            extension = extension.TrimStart(new char[] { '.' });

            return extension;
        }

        /// <summary>
        /// Finishes any slow data for a gallery item.
        /// </summary>
        private void CompleteGalleryItem(VirtualList list, int index)
        {
            ThumbnailCommand item = (ThumbnailCommand)list[index];
            
            // This is where we would load a thumbnail for this item.
        }

        /// <summary>
        /// Return results for items that match the search string.
        /// </summary>
        public override IList<SearchResult> Search(string value)
        {
            return new List<SearchResult>();
        }

        /// <summary>
        /// Safe wrapper for getting a directory from a path.
        /// Returns null if the directory does not exist.
        /// </summary>
        private DirectoryInfo GetDirectory(string path)
        {
            DirectoryInfo directory = null;
            try
            {
                directory = new DirectoryInfo(path);
            }
            catch (DirectoryNotFoundException)
            {
                Debug.WriteLine("Unable to find directory: " + path);
            }

            return directory;
        }

        private Image fileImage;
        private Image directoryImage;
    }
}
