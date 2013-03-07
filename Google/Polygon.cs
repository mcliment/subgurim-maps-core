using Subgurim.Maps.Google.Abstract;
using Subgurim.Maps.Google.Options;

namespace Subgurim.Maps.Google
{
    internal class Polygon : BaseMapObject<PolygonOptions>
    {
        public Polygon() : this(new PolygonOptions())
        {
        }

        public Polygon(PolygonOptions options)
        {
            this.Options = options;
        }

        public Polygon(PolygonOptions options, string id) : this(options)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return string.Format("var {0}=_sg.cs.createPolygon({1}, '{0}')", Id, Options);
        }

        public string ToStringPath()
        {
            if (Options.Paths != null)
            {
                return Options.SerializedPaths;
            }

            return string.Empty;
        }
    }
}
