using Subgurim.Maps.Google.Abstract;
using Subgurim.Maps.Google.Options;

namespace Subgurim.Maps.Google
{
    internal class Rectangle : BaseMapObject<RectangleOptions>
    {
        public Rectangle() : this(new RectangleOptions())
        {
        }

        public Rectangle(RectangleOptions options)
        {
            this.Options = options;
        }

        public override string ToString()
        {
            return string.Format("new google.maps.Rectangle({0})", Options);
        }
    }
}
