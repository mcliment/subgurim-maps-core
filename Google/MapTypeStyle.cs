using System;
using System.Collections.Generic;
using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Enums;

namespace Subgurim.Maps.Google
{
    [Serializable]
    internal class MapTypeStyle
    {
        public MapTypeStyleElementType ElementType { get; set; }

        public MapTypeStyleFeatureType FeatureType { get; set; }

        public MapTypeStyler Styler { get; set; }

        public override string ToString()
        {
            var options = new JsonCollection(false);

            options.Add<string>("elementType", GetElementType());
            options.Add<string>("featureType", GetFeatureType());
            options.Add("stylers", Styler.ToString());

            return options.ToString();
        }

        internal static string GetStyles(IEnumerable<MapTypeStyle> styles)
        {
            var options = new JsArrayCollection();

            foreach (var style in styles)
            {
                options.Add(style.ToString());
            }

            return options.ToString();
        }

        private string GetElementType()
        {
            return ElementType.ToString().ToLowerInvariant().Replace("__", ".");
        }

        private string GetFeatureType()
        {
            return FeatureType.ToString().ToLowerInvariant().Replace("__", ".");
        }
    }
}
