namespace Subgurim.Maps.Google.Events
{
    internal enum MarkerEvents
    {
        /// <summary>
        /// This event is fired when the marker's animation property changes.
        /// </summary>
        Animation_Changed,

        /// <summary>
        /// This event is fired when the marker icon was clicked.
        /// </summary>
        Click,

        /// <summary>
        /// This event is fired when the marker's clickable property changes.
        /// </summary>
        Clickable_Changed,

        /// <summary>
        /// This event is fired when the marker's cursor property changes.
        /// </summary>
        Cursor_Changed,

        /// <summary>
        /// This event is fired when the marker icon was double clicked.
        /// </summary>
        DblClick,

        /// <summary>
        /// This event is repeatedly fired while the user drags the marker.
        /// </summary>
        Drag,

        /// <summary>
        /// This event is fired when the user stops dragging the marker.
        /// </summary>
        Dragend,

        /// <summary>
        /// This event is fired when the marker's draggable property changes.
        /// </summary>
        Draggable_Changed,

        /// <summary>
        /// This event is fired when the user starts dragging the marker.
        /// </summary>
        DragStart,

        /// <summary>
        /// This event is fired when the marker's flat property changes.
        /// </summary>
        Flat_Changed,

        /// <summary>
        /// This event is fired when the marker icon property changes.
        /// </summary>
        Icon_Changed,

        /// <summary>
        /// This event is fired for a mousedown on the marker.
        /// </summary>
        MouseDown,

        /// <summary>
        /// This event is fired when the mouse leaves the area of the marker icon.
        /// </summary>
        MouseOut,

        /// <summary>
        /// This event is fired when the mouse enters the area of the marker icon.
        /// </summary>
        MouseOver,

        /// <summary>
        /// This event is fired for a mouseup on the marker.
        /// </summary>
        MouseUp,

        /// <summary>
        /// This event is fired when the marker position property changes.
        /// </summary>
        Position_Changed,

        /// <summary>
        /// This event is fired for a rightclick on the marker.
        /// </summary>
        RightClick,

        /// <summary>
        /// This event is fired when the marker's shadow property changes.
        /// </summary>
        Shadow_Changed,

        /// <summary>
        /// This event is fired when the marker's shape property changes.
        /// </summary>
        Shape_Changed,

        /// <summary>
        /// This event is fired when the marker title property changes.
        /// </summary>
        Title_Changed,

        /// <summary>
        /// This event is fired when the marker's visible property changes.
        /// </summary>
        Visible_Changed,

        /// <summary>
        /// This event is fired when the marker's zIndex property changes.
        /// </summary>
        ZIndex_Changed
    }
}
