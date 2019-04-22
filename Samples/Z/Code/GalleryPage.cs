using System;
using System.Collections;

using Microsoft.MediaCenter.UI;


namespace Z
{
    /// <summary>
    /// This object contains the standard set of information displayed in the 
    /// gallery page UI.
    /// </summary>
    public class GalleryPage : FilteredContentPage
    {
        /// <summary>
        /// The desired size for a galley item.  This will be interpreted by the 
        /// UI to control what size to allow for the thumbnails as well as how 
        /// many rows to display.
        /// </summary>
        public GalleryItemSize ItemSize
        {
            get { return itemSize; }
            set { itemSize = value; }
        }

        private GalleryItemSize itemSize;
    }

    /// <summary>
    /// The possible size configurations supported by the gallery UI.
    /// </summary>
    public enum GalleryItemSize
    {
        Small,
        Large
    }
}
