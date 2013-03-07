using System;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google.Events
{
    [Serializable]
    internal sealed class PolylineEvents : StringEnum
    {
        /// <summary>
        ///   This event is fired when the DOM click event is fired on the Polyline.
        /// </summary>
        public static readonly PolylineEvents Click = new PolylineEvents(1, "click");

        /// <summary>
        ///   This event is fired when the DOM dblclick event is fired on the Polyline.
        /// </summary>
        public static readonly PolylineEvents DblClick = new PolylineEvents(2, "dblclick");

        /// <summary>
        ///   This event is fired when the DOM mousedown event is fired on the Polyline.
        /// </summary>
        public static readonly PolylineEvents MouseDown = new PolylineEvents(3, "mousedown");

        /// <summary>
        ///   This event is fired when the DOM mousemove event is fired on the Polyline.
        /// </summary>
        public static readonly PolylineEvents MouseMove = new PolylineEvents(4, "mousemove");

        /// <summary>
        ///   This event is fired on Polyline mouseout.
        /// </summary>
        public static readonly PolylineEvents MouseOut = new PolylineEvents(5, "mouseout");

        /// <summary>
        ///   This event is fired on Polyline mouseover.
        /// </summary>
        public static readonly PolylineEvents MouseOver = new PolylineEvents(6, "mouseover");

        /// <summary>
        ///   This event is fired when the DOM mouseup event is fired on the Polyline.
        /// </summary>
        public static readonly PolylineEvents MouseUp = new PolylineEvents(7, "mouseup");

        /// <summary>
        ///   This event is fired when the Polyline is right-clicked on.
        /// </summary>
        public static readonly PolylineEvents RightClick = new PolylineEvents(8, "rightclick");

        private PolylineEvents(int value, string name) : base(value, name)
        {
        }
    }
}