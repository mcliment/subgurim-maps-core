using System;
using System.Collections.Generic;
using System.Text;
using Subgurim.Maps.Google.Abstract;

namespace Subgurim.Maps.Google.MapTypes
{
    [Serializable]
    internal class StyledMapType : BaseMapObject<StyledMapOptions>
    {
        private readonly List<MapTypeStyle> _styles = new List<MapTypeStyle>();

        public StyledMapType() : this(new StyledMapOptions())
        {
        }

        public StyledMapType(StyledMapOptions styledMapOptions)
        {
            Options = styledMapOptions;
        }

        public StyledMapType(IEnumerable<MapTypeStyle> styles) : this(new StyledMapOptions(), styles)
        {
        }

        public StyledMapType(StyledMapOptions styledMapOptions, IEnumerable<MapTypeStyle> styles)
        {
            _styles.AddRange(styles);
            Options = styledMapOptions;
        }

        public void AddStyles(IEnumerable<MapTypeStyle> styles)
        {
            _styles.AddRange(styles);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var styles = MapTypeStyle.GetStyles(_styles);

            if (string.IsNullOrEmpty(styles))
            {
                styles = "[]";
            }

            var options = Options.ToString();

            if (string.IsNullOrEmpty(options))
            {
                options = "{}";
            }

            sb.AppendFormat("var {0}=new google.maps.StyledMapType({1}, {2});", Id, styles, options);

            return sb.ToString();
        }
    }
}