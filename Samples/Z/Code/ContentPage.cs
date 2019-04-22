using System;
using System.Collections;

using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// This object contains the standard set of information displayed in a
    /// content page UI (e.g. Gallery).
    /// </summary>
    public class ContentPage : ModelItem
    {
        /// <summary>
        /// The list of items in the page.
        /// This list should only contain objects of type ThumbnailCommand.
        /// </summary>
        public IList Content
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


        private IList content;
    }


    /// <summary>
    /// This object contains the standard set of information displayed in a 
    /// filtered content page UI (e.g. Gallery).
    /// </summary>
    public class FilteredContentPage : ContentPage
    {
        /// <summary>
        /// A choice of available filters on the content.
        /// </summary>
        public virtual Choice Filters
        {
            get { return filters; }
            set
            {
                if (filters != value)
                {
                    // Unhook events on the old value
                    if (filters != null)
                        filters.ChosenChanged -= new EventHandler(OnActiveFilterChanged);

                    filters = value;

                    // Hook up events to the new value
                    if (filters != null)
                        filters.ChosenChanged += new EventHandler(OnActiveFilterChanged);

                    // Fire the "chagned" event
                    OnActiveFilterChanged(filters, EventArgs.Empty);
                    FirePropertyChanged("Filters");
                }
            }
        }

        /// <summary>
        /// Fired when the Chosen value within Filters has been modified
        /// or if the instance of Filters has been changed.
        /// </summary>
        public event EventHandler ActiveFilterChanged;

        /// <summary>
        /// Fire the event for the active filter changing.
        /// </summary>
        protected virtual void OnActiveFilterChanged(object sender, EventArgs args)
        {
            if (ActiveFilterChanged != null)
                ActiveFilterChanged(this, EventArgs.Empty);
        }


        private Choice filters;
    }
}
