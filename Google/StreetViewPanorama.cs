using Subgurim.Maps.Google.Abstract;
using Subgurim.Maps.Google.Options;

namespace Subgurim.Maps.Google
{
    internal class StreetViewPanorama : BaseMapObject<StreetViewPanoramaOptions>
    {
        private readonly string container;

        public StreetViewPanorama(string container, StreetViewPanoramaOptions options)
        {
            this.container = container;
            this.Options = options;
        }

        public override string ToString()
        {
            return string.Format("new google.maps.StreetViewPanorama({0}, {1});", container, Options);
        }
    }
}
