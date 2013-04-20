using System;
using Subgurim.Maps.Core.Helpers;

namespace Subgurim.Maps.Core.Google.Events
{
    [Serializable]
    internal sealed class MapEvents : StringEnum
    {
        /// <summary>
        ///   This event is fired when the viewport bounds have changed
        /// </summary>
        public static readonly MapEvents BoundsChanged = new MapEvents(1, "bounds_changed");

        /// <summary>
        ///   This event is fired when the map center property changes.
        /// </summary>
        public static readonly MapEvents CenterChanged = new MapEvents(2, "center_changed");

        /// <summary>
        ///   This event is fired when the user clicks on the map (but not when they click on a marker or infowindow).
        /// </summary>
        public static readonly MapEvents Click = new MapEvents(3, "click");

        /// <summary>
        ///   This event is fired when the user double-clicks on the map. Note that the click event will also fire, right before this one.
        /// </summary>
        public static readonly MapEvents DblClick = new MapEvents(4, "dblclick");

        /// <summary>
        ///   This event is repeatedly fired while the user drags the map.
        /// </summary>
        public static readonly MapEvents Drag = new MapEvents(5, "drag");

        /// <summary>
        ///   This event is fired when the user stops dragging the map.
        /// </summary>
        public static readonly MapEvents DragEnd = new MapEvents(6, "dragend");

        /// <summary>
        ///   This event is fired when the user starts dragging the map.
        /// </summary>
        public static readonly MapEvents DragStart = new MapEvents(7, "dragstart");

        /// <summary>
        ///   This event is fired when the map heading property changes.
        /// </summary>
        public static readonly MapEvents HeadingChanged = new MapEvents(8, "heading_changed");

        /// <summary>
        ///   This event is fired when the map becomes idle after panning or zooming.
        /// </summary>
        public static readonly MapEvents Idle = new MapEvents(9, "idle");

        /// <summary>
        ///   This event is fired when the mapTypeId property changes.
        /// </summary>
        public static readonly MapEvents MapTypeIdChanged = new MapEvents(10, "maptypeid_changed");

        /// <summary>
        ///   This event is fired whenever the user's mouse moves over the map container.
        /// </summary>
        public static readonly MapEvents MouseMove = new MapEvents(11, "mousemove");

        /// <summary>
        ///   This event is fired when the user's mouse exits the map container.
        /// </summary>
        public static readonly MapEvents MouseOut = new MapEvents(12, "mouseout");

        /// <summary>
        ///   This event is fired when the user's mouse enters the map container.
        /// </summary>
        public static readonly MapEvents MouseOver = new MapEvents(13, "mouseover");

        /// <summary>
        ///   This event is fired when the projection has changed.
        /// </summary>
        public static readonly MapEvents ProjectionChanged = new MapEvents(14, "projection_changed");

        /// <summary>
        ///   Developers should trigger this event on the map when the div changes size: google.maps.event.trigger(map, 'resize').
        /// </summary>
        public static readonly MapEvents Resize = new MapEvents(15, "resize");

        /// <summary>
        ///   This event is fired when the DOM contextmenu event is fired on the map container.
        /// </summary>
        public static readonly MapEvents RightClick = new MapEvents(16, "rightclick");

        /// <summary>
        ///   This event is fired when the visible tiles have finished loading.
        /// </summary>
        public static readonly MapEvents TilesLoaded = new MapEvents(17, "tilesloaded");

        /// <summary>
        ///   This event is fired when the map tilt property changes.
        /// </summary>
        public static readonly MapEvents TiltChanged = new MapEvents(18, "tilt_changed");

        /// <summary>
        ///   This event is fired when the map zoom property changes.
        /// </summary>
        public static readonly MapEvents ZoomChanged = new MapEvents(19, "zoom_changed");

        private MapEvents(int value, string name) : base(value, name)
        {
        }
    }
}