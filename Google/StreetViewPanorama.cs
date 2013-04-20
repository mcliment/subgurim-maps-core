using Subgurim.Maps.Core.Google.Abstract;
using Subgurim.Maps.Core.Google.Options;

namespace Subgurim.Maps.Core.Google
{
    public class StreetViewPanorama : BaseMapObject<StreetViewPanoramaOptions>
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
