using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Abstract;

namespace Subgurim.Maps.Google.Options
{
    internal abstract class PolygonBaseOptions : BaseOptions
    {
        private string mapId;

        /// <summary>
        /// Indicates whether this polygon handles click events. Defaults to true.
        /// </summary>
        public bool? Clickable { get; set; }

        /// <summary>
        /// If set to true, the user can edit this polygon by dragging the control points shown at the corners and on each edge. Defaults to false.
        /// </summary>
        public bool? Editable { get; set; }

        /// <summary>
        /// Map on which to display the polygon.
        /// </summary>
        public Map Map { get; set; }

        public string MapId
        {
            get
            {
                if (Map != null)
                {
                    return Map.Id;
                }

                return mapId;
            }
            set { mapId = value; }
        }

        /// <summary>
        /// The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public string StrokeColor { get; set; }

        /// <summary>
        /// The stroke opacity between 0.0 and 1.0
        /// </summary>
        public double? StrokeOpacity { get; set; }

        /// <summary>
        /// The stroke width in pixels.
        /// </summary>
        public int? StrokeWeight { get; set; }

        /// <summary>
        /// Whether this polygon is visible on the map. Defaults to true.
        /// </summary>
        public bool? Visible { get; set; }

        /// <summary>
        /// The zIndex compared to other polys.
        /// </summary>
        public int? ZIndex { get; set; }

        public override JsonCollection BuildParams()
        {
            JsonCollection options = new JsonCollection(false);

            if (Map != null)
            {
                options.Add("map", this.Map.Id, !string.IsNullOrEmpty(this.Map.Id));
            }

            options.AddIfValue("clickable", this.Clickable, typeof (bool));
            options.AddIfValue("editable", this.Editable, typeof(bool));
            options.Add("strokeColor", this.StrokeColor, !string.IsNullOrEmpty(StrokeColor), typeof (string));
            options.AddIfValue("strokeOpacity", this.StrokeOpacity, typeof(double));
            options.AddIfValue("strokeWeight", this.StrokeWeight, typeof(int));
            options.AddIfValue("visible", this.Visible, typeof(bool));
            options.AddIfValue("zIndex", this.ZIndex, typeof(int));

            return options;
        }
    }
}