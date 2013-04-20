using Subgurim.Maps.Core.Google.Abstract;
using Subgurim.Maps.Core.Google.Options;

namespace Subgurim.Maps.Core.Google
{
    internal class Circle : BaseMapObject<CircleOptions>
    {
        public Circle() : this(new CircleOptions())
        {
        }

        public Circle(CircleOptions options)
        {
            this.Options = options;
        }

        public override string ToString()
        {
            return string.Format("new google.maps.Circle({0})", Options);
        }
    }
}
