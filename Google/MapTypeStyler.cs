namespace Subgurim.Maps.Google
{
    internal class MapTypeStyler
    {
        public enum MapTypeStylerVisibility
        {
            On,
            Off,
            Simplified
        }

        /// <summary>
        /// Gamma. Modifies the gamma by raising the lightness to the given power. Valid values: Floating point numbers, [0.01, 10], with 1.0 representing no change.
        /// </summary>
        public double Gamma { get; set; }

        /// <summary>
        /// Sets the hue of the feature to match the hue of the color supplied. Note that the saturation and lightness of the feature is conserved, which means that the feature will not match the color supplied exactly. Valid values: An RGB hex string, i.e. '#ff0000'.
        /// </summary>
        public string Hue { get; set; }

        /// <summary>
        /// Inverts lightness. A value of true will invert the lightness of the feature while preserving the hue and saturation.
        /// </summary>
        public bool InvertLightness { get; set; }

        /// <summary>
        /// Lightness. Shifts lightness of colors by a percentage of the original value if decreasing and a percentage of the remaining value if increasing. Valid values: [-100, 100].
        /// </summary>
        public int Lightness { get; set; }

        /// <summary>
        /// Saturation. Shifts the saturation of colors by a percentage of the original value if decreasing and a percentage of the remaining value if increasing. Valid values: [-100, 100].
        /// </summary>
        public int Stauration { get; set; }

        /// <summary>
        /// Visibility: Valid values: 'on', 'off' or 'simplifed'.
        /// </summary>
        public MapTypeStylerVisibility Visibility { get; set; }
    }
}
