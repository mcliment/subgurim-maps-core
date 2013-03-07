using System.Collections.Generic;
using Subgurim.Maps.Collections;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google.Options
{
    internal class PolygonOptions : FilledPolygonBaseOptions
    {
        private string serializedPath;
        private string pathArrayName;

        private readonly IList<IList<LatLng>> paths = new List<IList<LatLng>>();

        /// <summary>
        /// When true, render each edge as a geodesic (a segment of a "great circle"). A geodesic is the shortest path between two points along the surface of the Earth. When false, render each edge as a straight line on screen. Defaults to false.
        /// </summary>
        public bool? Geodesic { get; set; }

        /// <summary>
        /// The ordered sequence of coordinates of the Polyline. This path may be specified using either a simple array of LatLngs, or an MVCArray of LatLngs. Note that if you pass a simple array, it will be converted to an MVCArray Inserting or removing LatLngs in the MVCArray will automatically update the polyline on the map.
        /// </summary>
        public IList<IList<LatLng>> Paths
        {
            get
            {
                if (paths.Count == 0)
                {
                    paths.Add(new List<LatLng>());
                }

                return paths;
            }
        }

        internal string PathArrayName
        {
            get
            {
                if (string.IsNullOrEmpty(pathArrayName) && Paths != null)
                {
                    SerializePath();
                }

                return pathArrayName;
            }
        }

        internal string SerializedPaths
        {
            get
            {
                if (string.IsNullOrEmpty(serializedPath) && Paths != null)
                {
                    SerializePath();
                }

                return serializedPath;
            }
        }

        public override JsonCollection BuildParams()
        {
            JsonCollection options = base.BuildParams();

            options.AddIfValue("geodesic", this.Geodesic, typeof (bool));

            if (Paths != null)
            {
                options.Add("path", PathArrayName, this.Paths != null);
            }

            options.Add("map", MapId, !string.IsNullOrEmpty(MapId));

            return options;
        }

        private void SerializePath()
        {
            pathArrayName = "polygon_" + MapHelper.UniqueId;

            serializedPath = ArrayHelper.CreateLatLngArray(this.Paths, pathArrayName);
        }
    }
}
