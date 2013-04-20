using System;
using Subgurim.Maps.Core.Collections;
using Subgurim.Maps.Core.Google.Enums;

namespace Subgurim.Maps.Core.Google.Options
{
    public class ZoomControlOptions
    {
        public enum ZoomControlStyle
        {
            /// <summary>
            /// The default zoom control. The control which DEFAULT maps to will vary according to map size and other factors. It may change in future versions of the API.
            /// </summary>
            Default,
            /// <summary>
            /// The larger control, with the zoom slider in addition to +/- buttons.
            /// </summary>
            Large,
            /// <summary>
            /// A small control with buttons to zoom in and out.
            /// </summary>
            Small
        }

        public ControlPosition? Position { get; set; }

        public ZoomControlStyle Style { get; set; }

        public override string ToString()
        {
            var options = new JsonCollection(false);

            if (Position.HasValue)
            {
                options.Add("position", "google.maps.ControlPosition." + Position.Value.ToString().ToUpperInvariant(), Position.Value != ControlPosition.Top_Left);
            }
            options.Add("style", "google.maps.ZoomControlStyle." + Enum.GetName(typeof(ZoomControlStyle), this.Style).ToUpperInvariant(), this.Style != ZoomControlStyle.Default);

            return options.ToString();
        }
    }
}
