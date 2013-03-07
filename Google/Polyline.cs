using Subgurim.Maps.Google.Abstract;
using Subgurim.Maps.Google.Options;

namespace Subgurim.Maps.Google
{
    internal class Polyline : BaseMapObject<PolylineOptions>
    {
        public Polyline() : this(new PolylineOptions())
        {
        }

        public Polyline(Polygon polygon)
        {
            AddFromPolygon(polygon, true);
        }

        public Polyline(PolylineOptions options)
        {
            this.Options = options;
        }

        public Polyline(PolylineOptions options, string id) : this(options)
        {
            this.Id = id;
        }

        public void Add(LatLng point)
        {
            Options.Path.Add(point);
        }

        public void AddFromPolygon(Polygon polygon, bool setPolygonStyles)
        {
            foreach (LatLng latLng in polygon.Options.Paths[0])
            {
                Options.Path.Add(latLng);
            }

            if (setPolygonStyles)
            {
                Options.StrokeColor = polygon.Options.StrokeColor;
                Options.StrokeOpacity = polygon.Options.StrokeOpacity;
                Options.StrokeWeight = polygon.Options.StrokeWeight;
            }
        }

        public override string ToString()
        {
            return string.Format("var {0}=_sg.cs.createPolyline({1}, '{0}')", Id, Options);
        }

        public string ToStringPath()
        {
            if (Options.Path != null)
            {
                return Options.SerializedPath;
            }

            return string.Empty;
        }
    }
}
