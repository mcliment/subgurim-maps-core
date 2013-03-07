using System;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google.Events
{
    [Serializable]
    internal sealed class MarkerEvents : StringEnum
    {
        /// <summary>
        ///   This event is fired when the marker's animation property changes.
        /// </summary>
        public static readonly MarkerEvents AnimationChanged = new MarkerEvents(1, "animation_changed");

        /// <summary>
        ///   This event is fired when the marker icon was clicked.
        /// </summary>
        public static readonly MarkerEvents Click = new MarkerEvents(2, "click");

        /// <summary>
        ///   This event is fired when the marker's clickable property changes.
        /// </summary>
        public static readonly MarkerEvents ClickableChanged = new MarkerEvents(3, "clickable_changed");

        /// <summary>
        ///   This event is fired when the marker's cursor property changes.
        /// </summary>
        public static readonly MarkerEvents CursorChanged = new MarkerEvents(4, "cursor_changed");

        /// <summary>
        ///   This event is fired when the marker icon was double clicked.
        /// </summary>
        public static readonly MarkerEvents DblClick = new MarkerEvents(5, "dblclick");

        /// <summary>
        ///   This event is repeatedly fired while the user drags the marker.
        /// </summary>
        public static readonly MarkerEvents Drag = new MarkerEvents(6, "drag");

        /// <summary>
        ///   This event is fired when the user stops dragging the marker.
        /// </summary>
        public static readonly MarkerEvents Dragend = new MarkerEvents(7, "dragend");

        /// <summary>
        ///   This event is fired when the marker's draggable property changes.
        /// </summary>
        public static readonly MarkerEvents DraggableChanged = new MarkerEvents(8, "draggable_changed");

        /// <summary>
        ///   This event is fired when the user starts dragging the marker.
        /// </summary>
        public static readonly MarkerEvents DragStart = new MarkerEvents(9, "dragstart");

        /// <summary>
        ///   This event is fired when the marker's flat property changes.
        /// </summary>
        public static readonly MarkerEvents FlatChanged = new MarkerEvents(10, "flat_changed");

        /// <summary>
        ///   This event is fired when the marker icon property changes.
        /// </summary>
        public static readonly MarkerEvents IconChanged = new MarkerEvents(11, "icon_changed");

        /// <summary>
        ///   This event is fired for a mousedown on the marker.
        /// </summary>
        public static readonly MarkerEvents MouseDown = new MarkerEvents(12, "mousedown");

        /// <summary>
        ///   This event is fired when the mouse leaves the area of the marker icon.
        /// </summary>
        public static readonly MarkerEvents MouseOut = new MarkerEvents(13, "mouseout");

        /// <summary>
        ///   This event is fired when the mouse enters the area of the marker icon.
        /// </summary>
        public static readonly MarkerEvents MouseOver = new MarkerEvents(14, "mouseover");

        /// <summary>
        ///   This event is fired for a mouseup on the marker.
        /// </summary>
        public static readonly MarkerEvents MouseUp = new MarkerEvents(15, "mouseup");

        /// <summary>
        ///   This event is fired when the marker position property changes.
        /// </summary>
        public static readonly MarkerEvents PositionChanged = new MarkerEvents(16, "position_changed");

        /// <summary>
        ///   This event is fired for a rightclick on the marker.
        /// </summary>
        public static readonly MarkerEvents RightClick = new MarkerEvents(17, "rightclick");

        /// <summary>
        ///   This event is fired when the marker's shadow property changes.
        /// </summary>
        public static readonly MarkerEvents ShadowChanged = new MarkerEvents(18, "shadow_changed");

        /// <summary>
        ///   This event is fired when the marker's shape property changes.
        /// </summary>
        public static readonly MarkerEvents ShapeChanged = new MarkerEvents(19, "shape_changed");

        /// <summary>
        ///   This event is fired when the marker title property changes.
        /// </summary>
        public static readonly MarkerEvents TitleChanged = new MarkerEvents(20, "title_changed");

        /// <summary>
        ///   This event is fired when the marker's visible property changes.
        /// </summary>
        public static readonly MarkerEvents VisibleChanged = new MarkerEvents(21, "visible_changed");

        /// <summary>
        ///   This event is fired when the marker's zIndex property changes.
        /// </summary>
        public static readonly MarkerEvents ZIndexChanged = new MarkerEvents(22, "zindex_changed");

        private MarkerEvents(int value, string name) : base(value, name)
        {
        }
    }
}