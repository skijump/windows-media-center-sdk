using System;
using System.Collections;

using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// This object contains the standard set of information displayed in the 
    /// details page UI.
    /// </summary>
    public class DetailsPage : ModelItem
    {
        /// <summary>
        /// The primary title of the object.
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
            }
        }

        /// <summary>
        /// A multiline summary of the object.
        /// </summary>
        public string Summary
        {
            get { return summary; }
            set
            {
                if (summary != value)
                {
                    summary = value;
                    FirePropertyChanged("Summary");
                }
            }
        }

        /// <summary>
        /// A list of actions that can be performed on this object.
        /// This list should only contain objects of type Command.
        /// </summary>
        public IList Commands
        {
            get { return commands; }
            set
            {
                if (commands != value)
                {
                    commands = value;
                    FirePropertyChanged("Commands");
                }
            }
        }

        /// <summary>
        /// Additional minor metadata about this object.
        /// </summary>
        public string Metadata
        {
            get { return metadata; }
            set
            {
                if (metadata != value)
                {
                    metadata = value;
                    FirePropertyChanged("Metadata");
                }
            }
        }

        /// <summary>
        /// A fullscreen image to display in the background.
        /// </summary>
        public Image Background
        {
            get { return backgroundImage; }
            set
            {
                if (backgroundImage != value)
                {
                    backgroundImage = value;
                    FirePropertyChanged("Background");
                }
            }
        }


        private string title;
        private string summary;
        private IList commands;
        private string metadata;
        private Image backgroundImage;
    }
}
