using Subgurim.Maps.Core.Google.Abstract;

namespace Subgurim.Maps.Core.Google.Layers
{
    internal class WeatherLayer : BaseMapObject<WeatherLayerOptions>
    {
        public enum LabelColor
        {
            Auto = 0,
            Black,
            White
        }

        public enum TemperatureUnit
        {
            Default = 0,
            Celsius,
            Fahrenheit
        }

        public enum WindSpeedUnit
        {
            Default = 0,
            Kilometers_Per_Hour,
            Meters_Per_Second,
            Miles_Per_Hour
        }

        public WeatherLayer(WeatherLayerOptions options)
        {
            this.SetOptions(options);
        }

        public override string ToString()
        {
            if (Options != null)
            {
                return string.Format("var {0}=new google.maps.weather.WeatherLayer({2});{0}.setMap({1});", Id, this.Map, this.Options);
            }

            return string.Format("var {0}=new google.maps.weather.WeatherLayer();{0}.setMap({1});", Id, this.Map);

        }
    }
}