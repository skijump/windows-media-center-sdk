using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// An ApplicationExperience is one of the primary sections of the Z 
    /// application.  It has a category in the main menu and a gallery page.
    /// </summary>
    public abstract class ApplicationExperience
    {
        /// <summary>
        /// A friendly name for this experience.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// The id for this experience. This id is set by Application.
        /// Application ensures its uniqueness across all experiences.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Create the main menu category entry for this experience.
        /// </summary>
        public abstract MenuCategory CreateMenuCategory();

        /// <summary>
        /// Return results for items that match the search string.
        /// </summary>
        public abstract IList<SearchResult> Search(string value);

        /// <summary>
        /// List of all downloads for this experience that are currently taking place.
        /// Each item in this list will be a SearchResult.
        /// Ideally, this would just be use the global Application.ActiveDownloads list
        /// with different filters applied, but the API does not currently support
        /// filtering, so we will manage a global list plus a list per experence.
        /// </summary>
        public ListDataSet ActiveDownloads
        {
            get
            {
                // defer initialization of list until first access
                if (activeDownloads == null)
                {
                    activeDownloads = new ArrayListDataSet();
                }
                
                return activeDownloads;
            }
        }

        /// <summary>
        /// Helper method to add the item to appropriate ActiveDownloads lists
        /// </summary>
        public void AddToActiveDownloads(SearchResult item)
        {
            Application.Current.ActiveDownloads.Add(item);
            ActiveDownloads.Add(item);
        }

        /// <summary>
        /// Helper method to remove the item from appropriate ActiveDownloads lists
        /// </summary>
        public void RemoveFromActiveDownloads(SearchResult item)
        {
            Application.Current.ActiveDownloads.Remove(item);
            ActiveDownloads.Remove(item);
        }



        // Unfortunately, the Environment.SpecialFolder enumeration doesn't doesn't have values for
        // shared music & shared videos.  So we need to make a native call into a Shell helper API
        // to retrieve the paths for these shared folders.

        // Define the API signature we will be calling and the constants we will be using
        [DllImport("shell32.dll")]
        static extern bool SHGetSpecialFolderPath(IntPtr hwndOwner, [Out] StringBuilder lpszPath, int nFolder, bool fCreate);
        private const int CSIDL_COMMON_VIDEO = 0x0037;
        private const int CSIDL_COMMON_MUSIC = 0x0035;

        /// <summary>
        /// Location of the local data used by the different experiences.
        /// </summary>
        protected const string DataDirectory = @"\ProgramData\09530D0BE3104237B278FA545F27AA38\Z\Data\";

        /// <summary>
        /// Location of the local images used by the different experiences.
        /// </summary>
        protected const string ImagesDirectory = @"\ProgramData\09530D0BE3104237B278FA545F27AA38\Z\Images\";

        /// <summary>
        /// Location of the Z subdirectory in the public videos directory
        /// used by the different experiences.
        /// </summary>
        protected static string VideosDirectory
        {
            get
            {
                if (videosDirectory == null)
                {
                    // Query and cache the shared video folder path from Shell
                    videosDirectory = GetPath(CSIDL_COMMON_VIDEO) + @"\Z\";
                }

                return videosDirectory;
            }
        }

        /// <summary>
        /// Location of the Z subdirectory in the public music directory
        /// used by the different experiences.
        /// </summary>
        protected static string MusicDirectory
        {
            get
            {
                if (musicDirectory == null)
                {
                    // Query and cache the shared music folder path from Shell
                    musicDirectory = GetPath(CSIDL_COMMON_MUSIC) + @"\Z\";
                }

                return musicDirectory;
            }
        }

        /// <summary>
        /// Get the path by calling the Shell native API 
        /// </summary>
        private static string GetPath(int folderCSIDL)
        {
            StringBuilder resultPath = new StringBuilder(255);

            SHGetSpecialFolderPath((IntPtr)0, resultPath, folderCSIDL, false);
            return resultPath.ToString();
        }

        private static string videosDirectory = null;
        private static string musicDirectory = null;
        private string description;
        private ListDataSet activeDownloads = null;
        public int id;
    }
}
