using System;
using Subgurim.Maps.Core.Helpers;

namespace Subgurim.Maps.Core.Google.Events
{
    [Serializable]
    internal sealed class CircleEvents : StringEnum
    {
        /// <summary>
        ///   This event is fired when the circle's center is changed.
        /// </summary>
        public static readonly CircleEvents CenterChanged = new CircleEvents(1, "center_changed");

        /// <summary>
        ///   This event is fired when the DOM click event is fired on the circle.
        /// </summary>
        public static readonly CircleEvents Click = new CircleEvents(2, "click");

        /// <summary>
        ///   This event is fired when the DOM dblclick event is fired on the circle.
        /// </summary>
        public static readonly CircleEvents DblClick = new CircleEvents(3, "dblclick");

        /// <summary>
        ///   This event is fired when the DOM mousedown event is fired on the circle.
        /// </summary>
        public static readonly CircleEvents MouseDown = new CircleEvents(4, "mousedown");

        /// <summary>
        ///   This event is fired when the DOM mousemove event is fired on the circle.
        /// </summary>
        public static readonly CircleEvents MouseMove = new CircleEvents(5, "mousemove");

        /// <summary>
        ///   This event is fired on circle mouseout.
        /// </summary>
        public static readonly CircleEvents MouseOut = new CircleEvents(6, "mouseout");

        /// <summary>
        ///   This event is fired on circle mouseover.
        /// </summary>
        public static readonly CircleEvents MouseOver = new CircleEvents(7, "mouseover");

        /// <summary>
        ///   This event is fired when the DOM mouseup event is fired on the circle.
        /// </summary>
        public static readonly CircleEvents MouseUp = new CircleEvents(8, "mouseup");

        /// <summary>
        ///   This event is fired when the circle's radius is changed.
        /// </summary>
        public static readonly CircleEvents RadiusChanged = new CircleEvents(9, "radius_changed");

        /// <summary>
        ///   This event is fired when the circle is right-clicked on.
        /// </summary>
        public static readonly CircleEvents RightClick = new CircleEvents(10, "rightclick");

        private CircleEvents(int value, string name) : base(value, name)
        {
        }
    }
}