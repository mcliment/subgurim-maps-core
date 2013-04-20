using Subgurim.Maps.Core.Google.Abstract;

namespace Subgurim.Maps.Core.Google.Layers
{
    internal class CloudLayer : BaseMapObject
    {
        public override string ToString()
        {
            return string.Format("var {0}=new google.maps.weather.CloudLayer();{0}.setMap({1});", Id, this.Map);
        }
    }
}
