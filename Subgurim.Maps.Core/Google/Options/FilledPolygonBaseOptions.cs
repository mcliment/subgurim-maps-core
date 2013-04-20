using Subgurim.Maps.Core.Collections;

namespace Subgurim.Maps.Core.Google.Options
{
    internal abstract class FilledPolygonBaseOptions : PolygonBaseOptions
    {
        /// <summary>
        /// The fill color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public string FillColor { get; set; }

        /// <summary>
        /// The fill opacity between 0.0 and 1.0
        /// </summary>
        public double? FillOpacity { get; set; }

        public override JsonCollection BuildParams()
        {
            JsonCollection options = base.BuildParams();

            options.Add("fillColor", this.FillColor, !string.IsNullOrEmpty(FillColor), typeof(string));
            options.Add("fillOpacity", this.FillOpacity.Value, this.FillOpacity.HasValue, typeof(double));

            return options;
        }
    }
}