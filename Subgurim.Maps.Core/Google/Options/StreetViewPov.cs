using Subgurim.Maps.Core.Collections;

namespace Subgurim.Maps.Core.Google.Options
{
    public class StreetViewPov
    {
        /// <summary>
        /// The camera heading in degrees relative to true north. True north is 0°, east is 90°, south is 180°, west is 270°.
        /// </summary>
        public double? Heading { get; set; }

        /// <summary>
        /// The camera pitch in degrees, relative to the street view vehicle. Ranges from 90° (directly upwards) to -90° (directly downwards).
        /// </summary>
        public double? Pitch { get; set; }

        /// <summary>
        /// The zoom level. Fully zoomed-out is level 0, zooming in increases the zoom level.
        /// </summary>
        public int? Zoom { get; set; }

        public override string ToString()
        {
            JsonCollection options = new JsonCollection(false);

            options.Add("heading", Heading.Value, Heading.HasValue, typeof (double));
            options.Add("pitch", Pitch.Value, Pitch.HasValue, typeof(double));
            options.Add("zoom", Zoom.Value, Zoom.HasValue, typeof(int));

            return options.ToString();
        }
    }
}