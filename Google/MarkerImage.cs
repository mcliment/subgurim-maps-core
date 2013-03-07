using System;
using Subgurim.Maps.Google.Abstract;

namespace Subgurim.Maps.Google
{
    [Serializable]
    internal class MarkerImage : BaseMapObject
    {
        public MarkerImage(string url) : this(url, null, null, null, null)
        {
        }

        public MarkerImage(string url, Size size) : this(url, size, null, null, null)
        {
        }
        
        public MarkerImage(string url, Size size, Point origin) : this(url, size, origin, null, null)
        {
        }
        
        public MarkerImage(string url, Size size, Point origin, Point anchor) : this(url, size, origin, anchor, null)
        {
        }
        
        public MarkerImage(string url, Size size, Point origin, Point anchor, Size scaledSize)
        {
            this.Url = url;
            this.Size = size;
            this.Origin = origin;
            this.Anchor = anchor;
            this.ScaledSize = scaledSize;
        }

        /// <summary>
        /// The position at which to anchor an image in correspondance to the location of the marker on the map.
        /// By default, the anchor is located along the center point of the bottom of the image.
        /// </summary>
        public Point Anchor { get; set; }

        /// <summary>
        /// The position of the image within a sprite, if any. By default,
        /// the origin is located at the top left corner of the image (0, 0).
        /// </summary>
        public Point Origin { get; set; }

        /// <summary>
        /// The size of the entire image after scaling, if any.
        /// Use this property to stretch/shrink an image or a sprite.
        /// </summary>
        public Size ScaledSize { get; set; }

        /// <summary>
        /// The display size of the sprite or image. When using sprites, you must specify the sprite size.
        /// If the size is not provided, it will be set when the image loads.
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// The URL of the image or sprite sheet.
        /// </summary>
        public string Url { get; set; }

        public override string ToString()
        {
            if (Anchor == null && Origin == null && ScaledSize == null && Size == null)
            {
                return string.Format("'{0}'", Url);
            }

            if (Origin == null)
            {
                Origin = new Point(0, 0);
            }

            string javascriptSize = "null";

            if (Size != null)
            {
                javascriptSize = Size.ToStringNew();
            }

            return string.Format("new google.maps.MarkerImage('{0}', {1}, {2}{3})", 
                Url, javascriptSize, 
                Origin.ToStringNew(), 
                Anchor == null ? string.Empty : ", " + Anchor.ToStringNew());
        }

    }
}