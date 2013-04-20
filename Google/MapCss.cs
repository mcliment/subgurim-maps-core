using Subgurim.Maps.Core.Collections;

namespace Subgurim.Maps.Core.Google
{
    public class MapCss
    {
        public string Width { get; set; }
        public string Height { get; set; }

        public override string ToString()
        {
            var css = new AdvancedCollection(" style=\"", "\"", ";", ":");

            css.Add("height", Height, Height != null);
            css.Add("width", Width, Width != null);

            return css.ToString();
        }
    }
}