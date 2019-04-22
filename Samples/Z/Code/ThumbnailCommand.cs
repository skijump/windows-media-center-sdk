using System;

using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// An actionable item that also has an associated image.
    /// </summary>
    public class ThumbnailCommand : Command
    {
        /// <summary>
        /// Create an unowned ThumbnailCommand.
        /// </summary>
        public ThumbnailCommand()
            : base()
        {
        }

        /// <summary>
        /// Create a ThumbnailCommand that has an lifetime owner.
        /// </summary>
        public ThumbnailCommand(IModelItemOwner owner)
            : base(owner)
        {
        }

        /// <summary>
        /// The representative image for this command.
        /// </summary>
        public Image Image
        {
            get { return image; }
            set
            {
                if (image != value)
                {
                    image = value;
                    FirePropertyChanged("Image");
                }
            }
        }

        /// <summary>
        /// Some extra metadata to display about this item.
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


        private Image image;
        private string metadata;
    }
}
