using System;
using Subgurim.Maps.Core.Helpers;

namespace Subgurim.Maps.Core.Google.Events
{
    [Serializable]
    internal sealed class InfoWindowEvents : StringEnum
    {
        /// <summary>
        ///   This event is fired when the close button was clicked.
        /// </summary>
        public static readonly InfoWindowEvents CloseClick = new InfoWindowEvents(1, "closeclick");

        /// <summary>
        ///   This event is fired when the content property changes.
        /// </summary>
        public static readonly InfoWindowEvents ContentChanged = new InfoWindowEvents(2, "content_changed");

        /// <summary>
        ///   This event is fired when the &lt;div&gt; containing the InfoWindow's content is attached
        ///   to the DOM. You may wish to monitor this event if you are building out your info
        ///   window content dynamically.
        /// </summary>
        public static readonly InfoWindowEvents DomReady = new InfoWindowEvents(3, "domready");

        /// <summary>
        ///   This event is fired when the position property changes.
        /// </summary>
        public static readonly InfoWindowEvents PositionChanged = new InfoWindowEvents(4, "position_changed");

        /// <summary>
        ///   This event is fired when the InfoWindow's zIndex changes.
        /// </summary>
        public static readonly InfoWindowEvents ZIndexChanged = new InfoWindowEvents(5, "zindex_changed");

        public InfoWindowEvents(int value, string name) : base(value, name)
        {
        }
    }
}