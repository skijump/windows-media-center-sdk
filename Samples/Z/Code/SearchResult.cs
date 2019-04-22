using System;
using System.Collections;

using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// An actionable search result.  Experience-specific metadata should be
    /// provided by deriving from this class and adding additional properties.
    /// </summary>
    public class SearchResult : Command
    {
        /// <summary>
        /// Create an unowned SearchResult.
        /// </summary>
        public SearchResult()
            : base()
        {
        }

        /// <summary>
        /// Create a SearchResult that has a lifetime owner.
        /// </summary>
        public SearchResult(IModelItemOwner owner)
            : base(owner)
        {
        }

        /// <summary>
        /// Create a SearchResult with the given unique id.
        /// It is up to the experience to ensure the id supplied here is unique 
        /// across that experience.
        /// </summary>
        public SearchResult(int id)
        {
            this.id = id;
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
        /// The type of the item (e.g. Movie, TV Episode).
        /// </summary>
        public string Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    FirePropertyChanged("Type");
                }
            }
        }

        /// <summary>
        /// The unique id for this SearchResult.
        /// It is up to the experience to ensure the id supplied here is unique 
        /// across that experience.
        /// </summary>
        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    FirePropertyChanged("Id");
                }
            }
        }

        /// <summary>
        /// Additional metadata.
        /// </summary>
        public string Metadata1
        {
            get { return metadata1; }
            set
            {
                if (metadata1 != value)
                {
                    metadata1 = value;
                    FirePropertyChanged("Metadata1");
                }
            }
        }

        /// <summary>
        /// Additional metadata.
        /// </summary>
        public string Metadata2
        {
            get { return metadata2; }
            set
            {
                if (metadata2 != value)
                {
                    metadata2 = value;
                    FirePropertyChanged("Metadata2");
                }
            }
        }

        /// <summary>
        /// The progress of this download.
        /// The value will be between 0.0 - 1.0
        /// </summary>
        public float DownloadProgress
        {
            get { return progress; }
            set
            {
                // constrain the value to the range 0.0 - 1.0, inclusively
                if (value < 0)
                {
                    value = 0;
                }

                if (value > 1.0f)
                {
                    value = 1.0f;
                }

                if (progress != value)
                {
                    progress = value;
                    FirePropertyChanged("DownloadProgress");
                }
            }
        }

        private Image image;
        private string type;
        private int id;
        private string metadata1;
        private string metadata2;
        private float progress;
    }
}
