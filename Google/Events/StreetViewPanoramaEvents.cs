namespace Subgurim.Maps.Google.Events
{
    internal enum StreetViewPanoramaEvents
    {
        /// <summary>
        /// This event is fired when the close button is clicked.
        /// </summary>
        CloseClick,

        /// <summary>
        /// This event is fired when the panorama's links change. The links change asynchronously following a pano id change.
        /// </summary>
        Links_Changed,

        /// <summary>
        /// This event is fired when the panorama's pano id changes. The pano may change as the user navigates through the panorama or the position is manually set. Note that not all position changes trigger a pano_changed.
        /// </summary>
        Pano_Changed,

        /// <summary>
        /// This event is fired when the panorama's position changes. The position changes as the user navigates through the panorama or the position is set manually.
        /// </summary>
        Position_Changed,

        /// <summary>
        /// This event is fired when the panorama's point-of-view changes. The point of view changes as the pitch, zoom, or heading changes.
        /// </summary>
        Pov_Changed,

        /// <summary>
        /// Developers should trigger this event on the panorama when its div changes size: google.maps.event.trigger(panorama, 'resize').
        /// </summary>
        Resize,

        /// <summary>
        /// This event is fired when the panorama's visibility changes. The visibility is changed when the Pegman id dragged onto the map, the close button is clicked, or setVisible() is called.
        /// </summary>
        Visible_Changed,
    }
}