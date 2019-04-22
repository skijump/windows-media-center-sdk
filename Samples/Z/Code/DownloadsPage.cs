using System;
using System.Collections;
using System.Collections.Generic;

using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// This object contains the standard set of information displayed in the 
    /// gallery page UI.
    /// NOTE: The Filters Choice on a DownloadsPage should contain 
    /// DownloadFilter objects.
    /// </summary>
    public class DownloadsPage : FilteredContentPage
    {
        /// <summary>
        /// Construct a downloads page.
        /// </summary>
        public DownloadsPage()
        {
        }

        /// <summary>
        /// Invoked when the active filter changes.
        /// </summary>
        protected override void OnActiveFilterChanged(object sender, EventArgs args)
        {
            base.OnActiveFilterChanged(sender, args);

            if (Filters == null)
            {
                System.Diagnostics.Debug.WriteLine("Cannot check downloads without any filters");
                return;
            }

            // Get the currently active filter.
            DownloadFilter activeFilter = Filters.Chosen as DownloadFilter;
            if (activeFilter == null)
                throw new ArgumentException("Expect filters to be of type DownloadFilter");
            Content = activeFilter.Content;
        }
    }

    /// <summary>
    /// An entry in the Filters' Choice in a DownloadsPage.
    /// </summary>
    public class DownloadFilter : ModelItem
    {
        /// <summary>
        /// Empty constructor to enable markup creation.
        /// </summary>
        public DownloadFilter()
            : this(null, null, null)
        {
        }

        /// <summary>
        /// Construct a download filter.
        /// </summary>
        public DownloadFilter(IModelItemOwner owner, string description, ListDataSet content)
            : base(owner, description)
        {
            this.content = content;
        }

        /// <summary>
        /// The delegate that will provide the downloads list.
        /// </summary>
        public ListDataSet Content
        {
            get { return content; }
            set
            {
                if (content != value)
                {
                    content = value;
                    FirePropertyChanged("Content");
                }
            }
        }

        private ListDataSet content;
    }
}
