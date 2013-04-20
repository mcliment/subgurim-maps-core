using System;
using Subgurim.Maps.Core.Helpers;

namespace Subgurim.Maps.Core.Google.Events
{
    [Serializable]
    internal sealed class GroundOverlayEvents : StringEnum
    {
        /// <summary>
        ///   This event is fired when the DOM click event is fired on the GroundOverlay.
        /// </summary>
        public static readonly GroundOverlayEvents Click = new GroundOverlayEvents(1, "click");

        /// <summary>
        ///   This event is fired when the DOM dblclick event is fired on the GroundOverlay.
        /// </summary>
        public static readonly GroundOverlayEvents DblClick = new GroundOverlayEvents(2, "dblclick");

        private GroundOverlayEvents(int value, string name) : base(value, name)
        {
        }
    }
}