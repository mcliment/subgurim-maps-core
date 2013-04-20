using Subgurim.Maps.Core.Collections;

namespace Subgurim.Maps.Core.Google.Options
{
    internal class CircleOptions : FilledPolygonBaseOptions
    {
        /// <summary>
        /// The center.
        /// </summary>
        public LatLng Center { get; set; }
        
        /// <summary>
        /// The radius in meters on the Earth's surface
        /// </summary>
        public double? Radius { get; set; }
        
        public override JsonCollection BuildParams()
        {
            JsonCollection options = base.BuildParams();

            options.Add("center", this.Center.ToStringNew(), this.Center != null);
            options.Add("radius", this.Radius.Value, this.Radius.HasValue, typeof(double));

            return options;
        }
    }
}
