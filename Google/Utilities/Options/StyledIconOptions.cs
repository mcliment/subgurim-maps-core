using System.Drawing;
using Subgurim.Maps.Collections;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google.Utilities.Options
{
    internal class StyledIconOptions
    {
        /// <summary>
        /// Text that will appear within the Marker.
        /// Limited to 2 characters for Marker type and unlimited for Bubble type.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The color of the Marker. For Marker and Bubble types.
        /// </summary>
        public Color? Color { get; set; }

        /// <summary>
        /// The color of any text appearing within the Marker. For Marker and Bubble types.
        /// </summary>
        public Color? Fore { get; set; }

        /// <summary>
        /// The color of the star on the Marker. If this is null or omitted then no star will appear.
        /// This only applies to Marker types.
        /// </summary>
        public Color? StarColor { get; set; }

        public override string ToString()
        {
            JsonCollection options = new JsonCollection(false);

            options.Add<string>("text", JavascriptHelper.PrepareJavascript(Text, false), !string.IsNullOrEmpty(Text));

            if (Color.HasValue)
            {
                options.Add<string>("color", JavascriptHelper.GetStringFromColor(Color.Value));
            }
            
            if (Fore.HasValue)
            {
                options.Add<string>("fore", JavascriptHelper.GetStringFromColor(Fore.Value));
            }
            
            if (StarColor.HasValue)
            {
                options.Add<string>("starcolor", JavascriptHelper.GetStringFromColor(StarColor.Value));
            }

            return options.ToString();
        }
    }
}