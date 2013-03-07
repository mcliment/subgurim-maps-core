using System;
using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Abstract;

namespace Subgurim.Maps.Google.MapTypes
{
    [Serializable]
    internal class StyledMapOptions : BaseOptions
    {
        /// <summary>
        /// Text to display when this MapType's button is hovered over in the map type control.
        /// </summary>
        public string Alt { get; set; }

        /// <summary>
        /// The maximum zoom level for the map when displaying this MapType. Optional.
        /// </summary>
        public int? MaxZoom { get; set; }

        /// <summary>
        /// The minimum zoom level for the map when displaying this MapType. Optional.
        /// </summary>
        public int? MinZoom { get; set; }

        /// <summary>
        /// The name to display in the map type control.
        /// </summary>
        public string Name { get; set; }

        public override JsonCollection BuildParams()
        {
            var options = new JsonCollection(false);

            options.Add("alt", Alt, !string.IsNullOrEmpty(Alt), typeof(string));
            options.Add("name", Name, !string.IsNullOrEmpty(Name), typeof(string));

            options.Add("maxZoom", this.MaxZoom, this.MaxZoom.HasValue, typeof(int));
            options.Add("minZoom", this.MinZoom, this.MinZoom.HasValue, typeof(int));

            return options;
        }
    }
}