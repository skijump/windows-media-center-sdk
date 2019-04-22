using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Win32;
using Microsoft.MediaCenter;
using Microsoft.MediaCenter.Hosting;
using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// This is the global coordinating object for the Z application.
    /// It handles the general page navigation.
    /// </summary>
    public class Application : ModelItem
    {
        /// <summary>
        /// Empy constructor to enable markup creation for when we want
        /// to run in McmlPad standalone.
        /// </summary>
        public Application()
            : this(null, null)
        {
        }

        /// <summary>
        /// Construct an Application object and associate it with a page
        /// session.
        /// </summary>
        public Application(HistoryOrientedPageSession session, AddInHost host)
        {
            // Store the page session and host
            this.session = session;
            this.host = host;

            // initialize the field used by the static Application.Current property
            singleApplicationInstance = this;

            //
            // Construct the application experiences
            //

            AddExperience(new Movies());
            AddExperience(new TV());
            AddExperience(new Music());
        }

        /// <summary>
        /// Adds the given experience to the Application's Experiences list
        /// and create a menu category for it.
        /// </summary>
        private void AddExperience(ApplicationExperience experience)
        {
            // Application sets experience's Id to its index in the Experiences
            // array.  This makes it easy to map from id back to experience
            experience.Id = experiences.Count;

            experiences.Add(experience);
            menu.Add(experience.CreateMenuCategory());
        }

        /// <summary>
        /// Given a unique experience id get the Experience object.
        /// </summary>
        public ApplicationExperience GetExperienceFromId(int id)
        {
            return experiences[id];
        }

        /// <summary>
        /// The one and only instance of Application running in this Z process
        /// </summary>
        public static Application Current 
        {
            get
            {
                return singleApplicationInstance;
            }
        }
        

        /// <summary>
        /// The main menu for the Z application.
        /// Each item in this array is a MenuCategory
        /// </summary>
        public ArrayListDataSet MainMenu
        {
            get { return menu; }
        }

        /// <summary>
        /// The Media Center environment.
        /// </summary>
        public MediaCenterEnvironment MediaCenterEnvironment
        {
            get
            {
                if (host == null)
                    return null;

                return host.MediaCenterEnvironment;
            }
        }

        /// <summary>
        /// The current logged in user.
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }

            private set
            {
                if (username != value)
                {
                    username = value;
                    FirePropertyChanged("Username");
                }
            }
        }

        /// <summary>
        /// Navigate to the appropriate starting page for the app.
        /// </summary>
        public void GoToStartPage()
        {
            //
            // Skip past the log in page if a registry key is set.
            // This logic is purely for the purpose of demonstration.
            // Obviously if your application required a login in order to
            // proceed you wouldn't want to skip over the log in page.
            //

            // Get the value from the registry.
            // Accomodate for 64-bit support.
            string showLoginPageValue = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\09530D0BE3104237B278FA545F27AA38\Z", @"ShowLoginPage", null) as string;
            if (showLoginPageValue == null)
                showLoginPageValue = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Wow6432Node\09530D0BE3104237B278FA545F27AA38\Z", @"ShowLoginPage", null) as string;

            // Map this from a string to a bool.
            bool showLoginPage = (showLoginPageValue != "0");

            // Either go to the log in page or the main menu.
            if (showLoginPage)
                GoToLogIn();
            else
                GoToMenu();
        }

        /// <summary>
        /// Navigate to the log in page.
        /// </summary>
        public void GoToLogIn()
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties["Application"] = this;

            if (session != null)
            {
                session.GoToPage("resx://Z/Z.Resources/LogInPage", properties);
            }
            else
            {
                Debug.WriteLine("GoToLogIn");
            }
        }

        /// <summary>
        /// Log in
        /// </summary>
        public void LogIn(string username, string password, bool rememberPassword)
        {
            //
            // The sample app does not validate log in credentials.
            // This is where you would implement your app's log in validation code.
            //

            Debug.WriteLine(String.Format("LogIn: {0} {1}{2}", username, password, rememberPassword ? " (remember)" : null));
            Username = username;

            GoToMenu();
        }

        /// <summary>
        /// Navigate to the main menu.
        /// </summary>
        public void GoToMenu()
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties["Menu"] = menu;
            properties["Application"] = this;

            if (session != null)
            {
                session.GoToPage("resx://Z/Z.Resources/MainMenu", properties);
            }
            else
            {
                Debug.WriteLine("GoToMainMenu");
            }
        }

        /// <summary>
        /// Navigate to the search page.
        /// </summary>
        public void GoToSearch()
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties["Application"] = this;
            properties["Page"] = CreateSearchPage();

            if (session != null)
            {
                session.GoToPage("resx://Z/Z.Resources/SearchPage", properties);
            }
            else
            {
                Debug.WriteLine("GoToSearch");
            }
        }

        /// <summary>
        /// Navigate to the downloads page.
        /// </summary>
        public void GoToDownloads()
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties["Application"] = this;
            properties["Page"] = CreateDownloadsPage();

            if (session != null)
            {
                session.GoToPage("resx://Z/Z.Resources/DownloadsPage", properties);
            }
            else
            {
                Debug.WriteLine("GoToDownloads");
            }
        }

        /// <summary>
        /// Navigate to the specified details page.
        /// </summary>
        /// <param name="page">The state object for the details page</param>
        public void GoToDetails(DetailsPage page)
        {
            if (page == null)
                throw new ArgumentNullException("page", "Must specify the model for the details page");

            // If we have no page session, just spit out a trace statement.
            if (session == null)
            {
                Debug.WriteLine("GoToDetails: " + page.Title);
                return;
            }


            //
            // Construct the arguments dictionary and then navigate to the
            // details page template.
            //

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties["Page"] = page;
            properties["Application"] = this;

            session.GoToPage("resx://Z/Z.Resources/DetailsPage", properties);
        }

        /// <summary>
        /// Navigate to the specified gallery page.
        /// </summary>
        /// <param name="page">The state object for the gallery page</param>
        public void GoToGallery(GalleryPage page)
        {
            if (page == null)
                throw new ArgumentNullException("page", "Must specify the model for the gallery page");

            // If we have no page session, just spit out a trace statement.
            if (session == null)
            {
                Debug.WriteLine("GoToGallery: " + page.Description);
                return;
            }


            //
            // Construct the arguments dictionary and then navigate to the
            // gallery page template.
            //

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties["Page"] = page;
            properties["Application"] = this;

            session.GoToPage("resx://Z/Z.Resources/GalleryPage", properties);
        }

        /// <summary>
        /// Navigate to the keyboard entry page.
        /// </summary>
        public void GoToKeyboard(EditableText text, bool password, bool submitWhenDone)
        {
            // If we have no page session, just spit out a trace statement.
            if (session == null)
            {
                Debug.WriteLine("GoToKeyboard: " + text.Value);
                return;
            }

            //
            // Construct the arguments dictionary and then navigate to the
            // keyboard page template.
            //

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties["Model"] = text;
            properties["Password"] = password;
            properties["SubmitWhenDone"] = submitWhenDone;
            properties["Application"] = this;

            session.GoToPage("resx://Z/Z.Resources/KeyboardPage", properties);
        }

        /// <summary>
        /// Navigate back to the previous page.
        /// </summary>
        public void GoBack()
        {
            if (session == null)
            {
                Debug.WriteLine("GoBack");
                return;
            }
            session.BackPage();
        }

        /// <summary>
        /// Construct a SearchPage object. This is carried out by the Application
        /// because the search page is global and not owned by any single 
        /// Experience.
        /// NOTE: This is public to enable debug markup access.
        /// </summary>
        public SearchPage CreateSearchPage()
        {
            SearchPage page = new SearchPage();
            page.Description = Z.Resources.Search;
            page.Content = new VirtualList();


            //
            // Create one on/off filter for each experience.
            //

            ArrayListDataSet filters = new ArrayListDataSet(page);
            foreach (ApplicationExperience experience in experiences)
            {
                filters.Add(CreateSearchPageFilter(page, experience));
            }
            page.Filters = filters;

            return page;
        }

        /// <summary>
        /// Create a search filter object given an Experience.
        /// </summary>
        private BooleanChoice CreateSearchPageFilter(SearchPage page, ApplicationExperience experience)
        {
            BooleanChoice filter = new BooleanChoice(page, experience.Description);

            // Stick the associated experience in dynamic data so we can fetch it later.
            filter.Data["Experience"] = experience;

            // Default the filter to "on".
            filter.Value = true;

            return filter;
        }

        /// <summary>
        /// Construct a DownloadsPage object. This is carried out by the Application
        /// because the downloads page is global and not owned by any single 
        /// Experience.
        /// NOTE: This is public to enable debug markup access.
        /// </summary>
        public DownloadsPage CreateDownloadsPage()
        {
            DownloadsPage page = new DownloadsPage();
            page.Description = Z.Resources.Downloads;

            //
            // Create one filter for each experience and one global "All"
            // filter that indicates all experiences.
            //

            ArrayListDataSet filters = new ArrayListDataSet(page);
            filters.Add(new DownloadFilter(page, "All", ActiveDownloads));
            foreach (ApplicationExperience experience in experiences)
            {
                filters.Add(CreateDownloadPageFilter(page, experience));
            }
            Choice filtersChoice = new Choice(page, null, filters);

            // Default to having "All" as the current filter
            filtersChoice.ChosenIndex = 0;

            page.Filters = filtersChoice;

            return page;
        }

        /// <summary>
        /// Create a download filter object from an experience.
        /// </summary>
        private static DownloadFilter CreateDownloadPageFilter(DownloadsPage page, ApplicationExperience experience)
        {
            return new DownloadFilter(page, experience.Description, experience.ActiveDownloads);
        }

        /// <summary>
        /// All downloads (of all media types) that are currently taking place.
        /// Each item in this list will be a SearchResult
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
        /// Displays a simple "OK" message box, branded with the Z logo.
        /// </summary>
        public void MessageBox(string text, string caption)
        {
            MessageBox(text, caption, 5, true);
        }

        /// <summary>
        /// Displays a simple "OK" message box, branded with the Z logo.
        /// </summary>
        public void MessageBox(string text, string caption, int timeout, bool modal)
        {
            if (MediaCenterEnvironment == null)
            {
                Debug.WriteLine(String.Format("Dialog {0}: {1}", caption, text));
                return;
            }

            MediaCenterEnvironment.Dialog(
                text,
                caption,
                new object[] { DialogButtons.Ok },
                timeout,
                modal,
                "resx://Z,Version=7.0.0.0,PublicKeyToken=2f4e6f203aa84589,Culture=neutral/Z.Resources/ZLogoProgramLibrary",
                delegate(DialogResult dialogResult) { });
        }

        private static Application singleApplicationInstance;

        private ListDataSet activeDownloads;
        private HistoryOrientedPageSession session;
        private AddInHost host;

        private ArrayListDataSet menu = new ArrayListDataSet();
        private List<ApplicationExperience> experiences = new List<ApplicationExperience>();
        
        private string username;
    }
}
