using System.Collections.Generic;
using System.Text;
using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Abstract;

namespace Subgurim.Maps.Google.MapTypes
{
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

        public StyledMapType(IEnumerable<MapTypeStyle> styles) : this(styles, new StyledMapOptions())
        {
        }

        public StyledMapType(IEnumerable<MapTypeStyle> styles, StyledMapOptions styledMapOptions)
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

            var styles = GetStyles();

            if (string.IsNullOrEmpty(styles))
            {
                styles = "[]";
            }

            var options = Options.ToString();

            if (string.IsNullOrEmpty(options))
            {
                options = "{}";
            }

            sb.AppendFormat("var {0}=new google.maps.StyledMapType(styles:{1}, options:{2});", Id, styles, options);

            return sb.ToString();
        }

        private string GetStyles()
        {
            var options = new JsArrayCollection();

            foreach (var style in _styles)
            {
                options.Add(style.ToString());
            }

            return options.ToString();
        }
    }
}