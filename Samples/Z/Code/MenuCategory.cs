using System;
using System.Collections;

using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// A category in the main menu.
    /// The category contains preview items and is itself actionable.
    /// </summary>
    public class MenuCategory : Command
    {
        /// <summary>
        /// The primary description of this category.
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    FirePropertyChanged("Title");
                }

                // Map the Description property to the same value as Title so
                // that standard Button templates may display this guy.
                Description = title;
            }
        }

        /// <summary>
        /// The secondary description of this category.
        /// </summary>
        public string SubTitle
        {
            get { return subtitle; }
            set
            {
                if (subtitle != value)
                {
                    subtitle = value;
                    FirePropertyChanged("SubTitle");
                }
            }
        }

        /// <summary>
        /// The list of preview items for this category.
        /// This list should only contain objects of type ThumbnailCommand.
        /// </summary>
        public IList Items
        {
            get { return items; }
            set
            {
                if (items != value)
                {
                    items = value;
                    FirePropertyChanged("Items");
                }
            }
        }


        private string title;
        private string subtitle;
        private IList items;
    }
}
