using Subgurim.Maps.Core.Collections;
using Subgurim.Maps.Core.Google.Enums;

namespace Subgurim.Maps.Core.Google.Options
{
    public class StreetViewControlOptions
    {
        public ControlPosition? Position { get; set; }

        public override string ToString()
        {
            var options = new JsonCollection(false);

            if (Position.HasValue)
            {
                options.Add("position", "google.maps.ControlPosition." + Position.Value.ToString().ToUpperInvariant(), Position != ControlPosition.Top_Left);
            }

            return options.ToString();
        }
    }
}
