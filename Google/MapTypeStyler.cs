using System;
using System.Drawing;
using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Enums;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google
{
    /// <summary>
    /// A styler affects how a map's elements will be styled.
    /// </summary>
    internal class MapTypeStyler
    {
        /// <summary>
        /// Sets the color of the feature. Valid values: An RGB hex string, i.e. '#ff0000'.
        /// </summary>
        public Color? Color { get; set; }

        /// <summary>
        /// Gamma. Modifies the gamma by raising the lightness to the given power. Valid values: Floating point numbers, [0.01, 10], with 1.0 representing no change.
        /// </summary>
        public double? Gamma { get; set; }

        /// <summary>
        /// Sets the hue of the feature to match the hue of the color supplied. Note that the saturation and lightness of the feature is conserved, which means that the feature will not match the color supplied exactly. Valid values: An RGB hex string, i.e. '#ff0000'.
        /// </summary>
        public Color? Hue { get; set; }

        /// <summary>
        /// Inverts lightness. A value of true will invert the lightness of the feature while preserving the hue and saturation.
        /// </summary>
        public bool? InvertLightness { get; set; }

        /// <summary>
        /// Lightness. Shifts lightness of colors by a percentage of the original value if decreasing and a percentage of the remaining value if increasing. Valid values: [-100, 100].
        /// </summary>
        public int? Lightness { get; set; }

        /// <summary>
        /// Saturation. Shifts the saturation of colors by a percentage of the original value if decreasing and a percentage of the remaining value if increasing. Valid values: [-100, 100].
        /// </summary>
        public int? Saturation { get; set; }

        /// <summary>
        /// Visibility: Valid values: 'on', 'off' or 'simplifed'.
        /// </summary>
        public MapTypeStylerVisibility? Visibility { get; set; }

        /// <summary>
        /// Sets the weight of the feature, in pixels. Valid values: Integers greater than or equal to zero.
        /// </summary>
        public int? Weight { get; set; }

        public override string ToString()
        {
            var values = new AdvancedCollection("[", "]", ",", ":");

            values.Add<double>("gamma", Gamma, Gamma.HasValue);
            values.Add<bool>("invert_lightness", InvertLightness, InvertLightness.HasValue);
            values.Add<int>("lightness", Lightness, Lightness.HasValue);
            values.Add<int>("saturation", Saturation, Saturation.HasValue);
            values.Add<int>("weight", Weight, Weight.HasValue);

            if (Color.HasValue)
            {
                values.Add<string>("color", JavascriptHelper.GetStringFromColor(Color.Value));
            }

            if (Hue.HasValue)
            {
                values.Add<string>("hue", JavascriptHelper.GetStringFromColor(Hue.Value));
            }

            if (Visibility.HasValue)
            {
                values.Add<string>("visibility", Visibility.Value.ToString().ToLowerInvariant());
            }

            return values.ToString();
        }
    }
}
