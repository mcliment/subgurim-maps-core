namespace Subgurim.Maps.Google.Events
{
    internal enum InfoWindowEvents
    {
        /// <summary>
        /// This event is fired when the close button was clicked.
        /// </summary>
        CloseClick,

        /// <summary>
        /// This event is fired when the content property changes.
        /// </summary>
        Content_Changed,

        /// <summary>
        /// This event is fired when the <div> containing the InfoWindow's content is attached
        /// to the DOM. You may wish to monitor this event if you are building out your info
        /// window content dynamically.
        /// </summary>
        DomReady,

        /// <summary>
        /// This event is fired when the position property changes.
        /// </summary>
        Position_Changed,

        /// <summary>
        /// This event is fired when the InfoWindow's zIndex changes.
        /// </summary>
        Zindex_Changed
    }
}
