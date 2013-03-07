namespace Subgurim.Maps.Google.Events
{
    internal enum MapEvents
    {
        /// <summary>
        /// This event is fired when the viewport bounds have changed
        /// </summary>
        Bounds_Changed,

        /// <summary>
        /// This event is fired when the map center property changes.
        /// </summary>
        Center_Changed,

        /// <summary>
        /// This event is fired when the user clicks on the map (but not when they click on a marker or infowindow).
        /// </summary>
        Click,

        /// <summary>
        /// This event is fired when the user double-clicks on the map. Note that the click event will also fire, right before this one.
        /// </summary>
        DblClick,

        /// <summary>
        /// This event is repeatedly fired while the user drags the map.
        /// </summary>
        Drag,

        /// <summary>
        /// This event is fired when the user stops dragging the map.
        /// </summary>
        DragEnd,

        /// <summary>
        /// This event is fired when the user starts dragging the map.
        /// </summary>
        DragStart,

        /// <summary>
        /// This event is fired when the map heading property changes.
        /// </summary>
        Heading_Changed,

        /// <summary>
        /// This event is fired when the map becomes idle after panning or zooming.
        /// </summary>
        Idle,

        /// <summary>
        /// This event is fired when the mapTypeId property changes.
        /// </summary>
        MapTypeId_Changed,

        /// <summary>
        /// This event is fired whenever the user's mouse moves over the map container.
        /// </summary>
        MouseMove,

        /// <summary>
        /// This event is fired when the user's mouse exits the map container.
        /// </summary>
        MouseOut,

        /// <summary>
        /// This event is fired when the user's mouse enters the map container.
        /// </summary>
        MouseOver,

        /// <summary>
        /// This event is fired when the projection has changed.
        /// </summary>
        Projection_Changed,

        /// <summary>
        /// Developers should trigger this event on the map when the div changes size: google.maps.event.trigger(map, 'resize').
        /// </summary>
        Resize,

        /// <summary>
        /// This event is fired when the DOM contextmenu event is fired on the map container.
        /// </summary>
        RightClick,

        /// <summary>
        /// This event is fired when the visible tiles have finished loading.
        /// </summary>
        TilesLoaded,

        /// <summary>
        /// This event is fired when the map tilt property changes.
        /// </summary>
        Tilt_Changed,

        /// <summary>
        /// This event is fired when the map zoom property changes.
        /// </summary>
        Zoom_Changed,
    }
}
