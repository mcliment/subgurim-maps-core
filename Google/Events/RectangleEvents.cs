using System;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google.Events
{
    [Serializable]
    internal sealed class RectangleEvents : StringEnum
    {
        /// <summary>
        ///   This event is fired when the rectangle's bounds are changed.
        /// </summary>
        public static readonly RectangleEvents BoundsChanged = new RectangleEvents(1, "bounds_changed");

        /// <summary>
        ///   This event is fired when the DOM click event is fired on the rectangle.
        /// </summary>
        public static readonly RectangleEvents Click = new RectangleEvents(2, "click");

        /// <summary>
        ///   This event is fired when the DOM dblclick event is fired on the rectangle.
        /// </summary>
        public static readonly RectangleEvents DblClick = new RectangleEvents(3, "dblclick");

        /// <summary>
        ///   This event is fired when the DOM mousedown event is fired on the rectangle.
        /// </summary>
        public static readonly RectangleEvents MouseDown = new RectangleEvents(4, "mousedown");

        /// <summary>
        ///   This event is fired when the DOM mousemove event is fired on the rectangle.
        /// </summary>
        public static readonly RectangleEvents MouseMove = new RectangleEvents(5, "mousemove");

        /// <summary>
        ///   This event is fired on rectangle mouseout.
        /// </summary>
        public static readonly RectangleEvents MouseOut = new RectangleEvents(6, "mouseout");

        /// <summary>
        ///   This event is fired on rectangle mouseover.
        /// </summary>
        public static readonly RectangleEvents MouseOver = new RectangleEvents(7, "mouseover");

        /// <summary>
        ///   This event is fired when the DOM mouseup event is fired on the rectangle.
        /// </summary>
        public static readonly RectangleEvents MouseUp = new RectangleEvents(8, "mouseup");

        /// <summary>
        ///   This event is fired when the rectangle is right-clicked on.
        /// </summary>
        public static readonly RectangleEvents RightClick = new RectangleEvents(9, "rightclick");

        private RectangleEvents(int value, string name) : base(value, name)
        {
        }
    }
}