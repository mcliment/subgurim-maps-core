using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Abstract;

namespace Subgurim.Maps.Google.Options
{
    internal class GroundOverlayOptions : BaseOptions
    {
        /// <summary>
        /// If true, the ground overlay can receive click events.
        /// </summary>
        public bool? Clickable { get; set; }

        /// <summary>
        /// The map on which to display the overlay.
        /// </summary>
        public string Map { get; set; }

        /// <summary>
        /// The opacity of the overlay, expressed as a number between 0 and 1. Optional. Defaults to 1.
        /// </summary>
        public double? Opacity { get; set; }

        public override JsonCollection BuildParams()
        {
            JsonCollection options = new JsonCollection(false);

            if (Clickable.HasValue)
            {
                options.Add<bool>("clickable", Clickable.Value);
            }

            options.Add("map", Map, !string.IsNullOrEmpty(Map));

            if (Opacity.HasValue && Opacity.Value >= 0 && Opacity.Value < 1)
            {
                options.Add("opacity", Opacity.Value);
            }

            return options;
        }
    }
}