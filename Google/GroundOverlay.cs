using Subgurim.Maps.Core.Google.Abstract;
using Subgurim.Maps.Core.Google.Options;

namespace Subgurim.Maps.Core.Google
{
    internal class GroundOverlay : BaseMapObject<GroundOverlayOptions>
    {
        private readonly string url;
        private readonly LatLngBounds bounds;

        public GroundOverlay(string url, LatLngBounds bounds, GroundOverlayOptions options)
        {
            this.url = url;
            this.bounds = bounds;
            this.Options = options;
        }

        public LatLngBounds Bounds
        {
            get { return bounds; }
        }

        public string Url
        {
            get { return url; }
        }

        public override string ToString()
        {
            if (Options == null)
            {
                return string.Format("var {0} = new google.maps.GroundOverlay('{1}',{2});", Id, Url, Bounds);
            }

            return string.Format("var {0} = new google.maps.GroundOverlay('{1}',{2},{3});", Id, Url, Bounds, Options);
        }
    }
}
