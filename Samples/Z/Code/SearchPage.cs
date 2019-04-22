using System;
using System.Collections;
using System.Collections.Generic;

using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// This object contains the standard set of information displayed in the 
    /// search page UI.
    /// </summary>
    public class SearchPage : ContentPage
    {
        /// <summary>
        /// Construct a search page.
        /// </summary>
        public SearchPage()
        {
            // Create an object to track the search string and hook its 
            // submit event.
            searchValue = new EditableText(this);
            searchValue.Value = String.Empty;
            searchValue.Submitted += new EventHandler(OnSearchInputChanged);
        }

        /// <summary>
        /// The current value to search with.
        /// </summary>
        public EditableText SearchValue
        {
            get
            {
                return searchValue;
            }
        }

        /// <summary>
        /// A list of available filters on the content of this page.
        /// This list should only contain objects of type BooleanChoice.
        /// </summary>
        public IList Filters
        {
            get { return filters; }
            set
            {
                if (filters != value)
                {
                    // Create a read only copy of the list.  This ensures
                    // that we aren't surprised by someone else holding on
                    // to the list and changing the contents.
                    filters = ArrayList.ReadOnly(value);

                    foreach (object o in filters)
                    {
                        // Validate the contents of the list.
                        BooleanChoice filter = o as BooleanChoice;
                        if (filter == null)
                            throw new ArgumentException("Invalid contents for Filters list.  All contents must be of type BooleanChoice.");

                        // Hook the changed event.
                        filter.ChosenChanged += new EventHandler(OnSearchInputChanged);
                    }

                    FirePropertyChanged("Filters");
                }
            }
        }

        /// <summary>
        /// Invoked when something that would affect our search has been modified.
        /// </summary>
        private void OnSearchInputChanged(object sender, EventArgs e)
        {
            // Clear out the search results.
            Content.Clear();

            // Get the current search string.
            string search = searchValue.Value;

            foreach (BooleanChoice filter in filters)
            {
                // If the filter has been disabled, don't search it.
                if (!filter.Value)
                    continue;

                // Get the experience off of the item.
                ApplicationExperience experience = filter.Data["Experience"] as ApplicationExperience;
                if (experience == null)
                {
                    System.Diagnostics.Debug.WriteLine("No Experience stored on " + filter);
                    continue;
                }

                // Search that experience.
                IList<SearchResult> results = experience.Search(search);

                foreach (SearchResult result in results)
                {
                    // Add the search result to the content list.
                    Content.Add(result);
                }
            }
        }

        private EditableText searchValue;
        private IList filters;
    }
}
