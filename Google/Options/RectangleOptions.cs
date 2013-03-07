using Subgurim.Maps.Collections;

namespace Subgurim.Maps.Google.Options
{
    internal class RectangleOptions : FilledPolygonBaseOptions
    {
        /// <summary>
        /// The bounds.
        /// </summary>
        public LatLngBounds Bounds { get; set; }

        public override JsonCollection BuildParams()
        {
            JsonCollection options = base.BuildParams();

            options.Add("bounds", this.Bounds, this.Bounds != null);

            return options;
        }
    }
}
