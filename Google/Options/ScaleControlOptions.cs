using System;
using Subgurim.Maps.Core.Collections;
using Subgurim.Maps.Core.Google.Enums;

namespace Subgurim.Maps.Core.Google.Options
{
    public class ScaleControlOptions
    {
        public ControlPosition? Position { get; set; }
        public ScaleControlStyle Style { get; set; }

        public enum ScaleControlStyle
        {
            /// <summary>
            /// The standard scale control.
            /// </summary>
            Default
        }

        public override string ToString()
        {
            var options = new JsonCollection(false);

            if (Position.HasValue)
            {
                options.Add("position", "google.maps.ControlPosition." + Position.Value.ToString().ToUpperInvariant(), Position.Value != ControlPosition.Bottom_Left);
            }

            options.Add("style", "google.maps.ScaleControlStyle." + Enum.GetName(typeof(ScaleControlStyle), this.Style).ToUpperInvariant(), this.Style != ScaleControlStyle.Default);

            return options.ToString();
        }
    }
}
