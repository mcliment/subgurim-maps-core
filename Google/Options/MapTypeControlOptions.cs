using System;
using System.Collections.Generic;
using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Enums;

namespace Subgurim.Maps.Google.Options
{
    internal class MapTypeControlOptions
    {
        private Type mapType;

        public List<string> MapTypeIds { get; set; }
        public ControlPosition? Position { get; set; }
        public MapTypeControlStyle Style { get; set; }

        public MapTypeControlOptions(Type mapType)
        {
            // TODO :: Quitar el MapType
            this.mapType = mapType;
        }

        public enum MapTypeControlStyle
        {
            /// <summary>
            /// Uses the default map type control. The control which DEFAULT maps to will vary according to window size and other factors. It may change in future versions of the API.
            /// </summary>
            Default,
            /// <summary>
            /// A dropdown menu for the screen realestate conscious.
            /// </summary>
            DropDown_Menu,
            /// <summary>
            /// The standard horizontal radio buttons bar.
            /// </summary>
            Horizontal_Bar
        }

        public override string ToString()
        {
            var options = new JsonCollection(false);

            if (Position.HasValue)
            {
                options.Add("position", "google.maps.ControlPosition." + Position.Value.ToString().ToUpperInvariant());
            }

            options.Add("style", "google.maps.MapTypeControlStyle." + Enum.GetName(typeof(MapTypeControlStyle), Style).ToUpperInvariant(), Style != MapTypeControlStyle.Default);

            // TODO :: Review MapType
            if ((mapType == typeof(Map) || mapType.Name == "GMap") && MapTypeIds.Count > 0)
            {
                var types = new JsArrayCollection();

                foreach (var mapTypeId in MapTypeIds)
                {
                    types.Add(mapTypeId);
                }

                options.Add("mapTypeIds", types);
            }

            return options.ToString();
        }
    }
}
