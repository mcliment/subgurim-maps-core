using System.Collections.Generic;

namespace Subgurim.Maps.Google
{
    internal class MapTypeStyle
    {
        public enum MapTypeStyleElementType
        {
            All,
            Geometry,
            Labels
        }

        public enum MapTypeStyleFeatureType
        {
            Administrative,
            Administrative__Country,
            Aadministrative__Land_Parcel,
            Aadministrative__Locality,
            Administrative__Neighborhood,
            Aministrative__Province,
            All,
            Landscape,
            Landscape__Man_Made,
            Landscape__Natural,
            Poi,
            Poi__Attraction,
            Poi__Business,
            Poi__Government,
            Poi__Medical,
            Poi__Park,
            Poi__Place_Of_Worship,
            Poi__School,
            Poi__Sports_Complex,
            Road,
            Road__Arterial,
            Road__Highway,
            Road__Local,
            Transit,
            Transit__Line,
            Transit__Station,
            Transit__Station__Airport,
            Transit__Station__Bus,
            Transit__Station__Rail,
            Water
        }

        public MapTypeStyleElementType ElementType { get; set; }

        public MapTypeStyleFeatureType FeatureType { get; set; }

        public IList<MapTypeStyler> Stylers { get; set; }
    }
}
