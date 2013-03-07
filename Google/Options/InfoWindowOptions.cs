using System;
using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Abstract;

namespace Subgurim.Maps.Google.Options
{
    [Serializable]
    internal class InfoWindowOptions : BaseOptions
    {
        /// <summary>
        /// Content to display in the InfoWindow. This can be an HTML element, a plain-text string,
        /// or a string containing HTML. The InfoWindow will be sized according to the content. 
        /// To set an explicit size for the content, set content to be a HTML element with that size.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Disable auto-pan on open. By default, the info window will pan the map so that it is
        /// fully visible when it opens.
        /// </summary>
        public bool DisableAutoPan { get; set; }

        /// <summary>
        /// Maximum width of the infowindow, regardless of content's width. This value is only
        ///  considered if it is set before a call to open. To change the maximum width when
        ///  changing content, call close, setOptions, and then open.
        /// </summary>
        public int? MaxWidth { get; set; }

        /// <summary>
        /// The offset, in pixels, of the tip of the info window from the point on the map at
        /// whose geographical coordinates the info window is anchored. If an InfoWindow is
        /// opened with an anchor, the pixelOffset will be calculated from the top-center of the 
        /// anchor's bounds.
        /// </summary>
        public Size PixelOffset { get; set; }

        /// <summary>
        /// The LatLng at which to display this InfoWindow. If the InfoWindow is opened with an anchor,
        /// the anchor's position will be used instead.
        /// </summary>
        public LatLng Position { get; set; }

        /// <summary>
        /// All InfoWindows are displayed on the map in order of their zIndex, with higher values
        /// displaying in front of InfoWindows with lower values. By default, InfoWinodws are 
        /// displayed according to their latitude, with InfoWindows of lower latitudes appearing in 
        /// front of InfoWindows at higher latitudes. InfoWindows are always displayed in front 
        /// of markers.
        /// </summary>
        public int? ZIndex { get; set; }

        private const bool DefaultAutoPan = false;

        public override JsonCollection BuildParams()
        {
            JsonCollection options = new JsonCollection(false);

            // If it's already escaped, we use it raw
            if (!string.IsNullOrEmpty(Content) && Content.StartsWith("'"))
            {
                options.Add("content", this.Content);
            }
            else
            {
                options.Add("content", this.Content.Replace("'", "\\'"), !string.IsNullOrEmpty(Content), typeof(string));
            }

            options.Add("disableAutoPan", this.DisableAutoPan, this.DisableAutoPan != DefaultAutoPan, typeof (bool));
            if (this.MaxWidth.HasValue)
            {
                options.Add("maxWidth", this.MaxWidth.Value, typeof (int));
            }
            if (this.PixelOffset != null)
            {
                options.Add("pixelOffset", this.PixelOffset.ToStringNew());
            }
            if (this.Position != null)
            {
                options.Add("position", this.Position.ToStringNew());
            }
            if (ZIndex.HasValue)
            {
                options.Add("zIndex", this.ZIndex.Value, typeof (int));
            }

            return options;
        }
    }
}
