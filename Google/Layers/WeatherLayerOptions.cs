using Subgurim.Maps.Core.Collections;
using Subgurim.Maps.Core.Google.Abstract;

namespace Subgurim.Maps.Core.Google.Layers
{
    internal class WeatherLayerOptions : BaseOptions
    {
        /// <summary>
        /// If true, the layer receives mouse events. Default value is true.
        /// </summary>
        public bool? Clickable { get; set; }

        /// <summary>
        /// The color of labels on the weather layer. If this is not explicitly set, 
        /// the label color is chosen automatically depending on the map type.
        /// </summary>
        public WeatherLayer.LabelColor LabelColor { get; set; }

        /// <summary>
        /// Suppress the rendering of info windows when weather icons are clicked.
        /// </summary>
        public bool? SuppressInfoWindows { get; set; }

        /// <summary>
        /// The units to use for temperature.
        /// </summary>
        public WeatherLayer.TemperatureUnit TemperatureUnits { get; set; }

        /// <summary>
        /// The units to use for wind speed.
        /// </summary>
        public WeatherLayer.WindSpeedUnit WindSpeedUnits { get; set; }

        public override JsonCollection BuildParams()
        {
            var options = new JsonCollection(false);

            if (Clickable.HasValue)
            {
                options.Add<bool>("clickable", Clickable.Value);
            }

            if (SuppressInfoWindows.HasValue)
            {
                options.Add<bool>("supressInfoWindows", SuppressInfoWindows.Value);
            }

            options.Add("labelColor", "google.maps.weather.LabelColor." + LabelColor.ToString().ToUpperInvariant(), LabelColor != WeatherLayer.LabelColor.Auto);
            options.Add("temperatureUnits", "google.maps.weather.TemperatureUnit." + TemperatureUnits.ToString().ToUpperInvariant(), TemperatureUnits != WeatherLayer.TemperatureUnit.Default);
            options.Add("windSpeedUnits", "google.maps.weather.WindSpeedUnit." + WindSpeedUnits.ToString().ToUpperInvariant(), WindSpeedUnits != WeatherLayer.WindSpeedUnit.Default);

            return options;
        }
    }
}