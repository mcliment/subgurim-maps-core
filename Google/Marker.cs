using System;
using System.Text;
using Subgurim.Maps.Google.Abstract;
using Subgurim.Maps.Google.Options;

namespace Subgurim.Maps.Google
{
    [Serializable]
    internal class Marker : BaseMapObject<MarkerOptions>
    {
        public Marker() : this(new MarkerOptions())
        {
        }

        public Marker(LatLng position)
        {
            this.Options = new MarkerOptions();

            Options.Position = position;
        }

        public Marker(MarkerOptions options)
        {
            this.Options = options;
        }

        public Marker(MarkerOptions options, string id) : this(options)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (!string.IsNullOrEmpty(Options.PreText))
            {
                sb.Append(Options.PreText);
            }

            if (!string.IsNullOrEmpty(Id))
            {
                sb.AppendFormat("var {0}=_sg.cs.createMarker({1}, '{0}');", Id, Options.ToString());
            }
            else
            {
                sb.AppendFormat("_sg.cs.createMarker({0});", Options.ToString());
            }

            return sb.ToString();
        }
    }
}
