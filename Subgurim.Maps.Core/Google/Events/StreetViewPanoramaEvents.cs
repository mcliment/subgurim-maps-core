using System;
using Subgurim.Maps.Core.Helpers;

namespace Subgurim.Maps.Core.Google.Events
{
    [Serializable]
    internal sealed class StreetViewPanoramaEvents : StringEnum
    {
        /// <summary>
        ///   This event is fired when the close button is clicked.
        /// </summary>
        public static readonly StreetViewPanoramaEvents CloseClick = new StreetViewPanoramaEvents(1, "closeclick");

        /// <summary>
        ///   This event is fired when the panorama's links change. The links change asynchronously following a pano id change.
        /// </summary>
        public static readonly StreetViewPanoramaEvents LinksChanged = new StreetViewPanoramaEvents(2, "links_changed");

        /// <summary>
        ///   This event is fired when the panorama's pano id changes. The pano may change as the user navigates through the panorama or the position is manually set. Note that not all position changes trigger a pano_changed.
        /// </summary>
        public static readonly StreetViewPanoramaEvents PanoChanged = new StreetViewPanoramaEvents(3, "pano_changed");

        /// <summary>
        ///   This event is fired when the panorama's position changes. The position changes as the user navigates through the panorama or the position is set manually.
        /// </summary>
        public static readonly StreetViewPanoramaEvents PositionChanged = new StreetViewPanoramaEvents(4, "position_changed");

        /// <summary>
        ///   This event is fired when the panorama's point-of-view changes. The point of view changes as the pitch, zoom, or heading changes.
        /// </summary>
        public static readonly StreetViewPanoramaEvents PovChanged = new StreetViewPanoramaEvents(5, "pov_changed");

        /// <summary>
        ///   Developers should trigger this event on the panorama when its div changes size: google.maps.event.trigger(panorama, 'resize').
        /// </summary>
        public static readonly StreetViewPanoramaEvents Resize = new StreetViewPanoramaEvents(6, "resize");

        /// <summary>
        ///   This event is fired when the panorama's visibility changes. The visibility is changed when the Pegman id dragged onto the map, the close button is clicked, or setVisible() is called.
        /// </summary>
        public static readonly StreetViewPanoramaEvents VisibleChanged = new StreetViewPanoramaEvents(7, "visible_changed");

        private StreetViewPanoramaEvents(int value, string name) : base(value, name)
        {
        }
    }
}