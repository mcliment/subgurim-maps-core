using System;
using Subgurim.Maps.Core.Helpers;

namespace Subgurim.Maps.Core.Google.Events
{
    [Serializable]
    internal sealed class PolygonEvents : StringEnum
    {
        /// <summary>
        ///   This event is fired when the DOM click event is fired on the Polygon.
        /// </summary>
        public static readonly PolygonEvents Click = new PolygonEvents(1, "click");

        /// <summary>
        ///   This event is fired when the DOM dblclick event is fired on the Polygon.
        /// </summary>
        public static readonly PolygonEvents DblClick = new PolygonEvents(2, "dblclick");

        /// <summary>
        ///   This event is fired when the DOM mousedown event is fired on the Polygon.
        /// </summary>
        public static readonly PolygonEvents MouseDown = new PolygonEvents(3, "mousedown");

        /// <summary>
        ///   This event is fired when the DOM mousemove event is fired on the Polygon.
        /// </summary>
        public static readonly PolygonEvents MouseMove = new PolygonEvents(4, "mousemove");

        /// <summary>
        ///   This event is fired on Polygon mouseout.
        /// </summary>
        public static readonly PolygonEvents MouseOut = new PolygonEvents(5, "mouseout");

        /// <summary>
        ///   This event is fired on Polygon mouseover.
        /// </summary>
        public static readonly PolygonEvents MouseOver = new PolygonEvents(6, "mouseover");

        /// <summary>
        ///   This event is fired when the DOM mouseup event is fired on the Polygon.
        /// </summary>
        public static readonly PolygonEvents MouseUp = new PolygonEvents(7, "mouseup");

        /// <summary>
        ///   This event is fired when the Polygon is right-clicked on.
        /// </summary>
        public static readonly PolygonEvents RightClick = new PolygonEvents(8, "rightclick");

        private PolygonEvents(int value, string name) : base(value, name)
        {
        }
    }
}