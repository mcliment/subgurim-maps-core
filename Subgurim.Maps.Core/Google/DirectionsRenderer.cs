using Subgurim.Maps.Core.Collections;
using Subgurim.Maps.Core.Google.Abstract;

namespace Subgurim.Maps.Core.Google
{
    internal class DirectionsRenderer : BaseMapObject<DirectionsRendererOptions>
    {
        public DirectionsRenderer(DirectionsRendererOptions options)
        {
            this.Options = options;
        }
    }

    internal enum DirectionsRendererEvents
    {
        /// <summary>
        /// This event is fired when the rendered directions change, either when a new DirectionsResult is set or when the user finishes dragging a change to the directions path.
        /// </summary>
        Directions_Changed
    }

    internal class DirectionsRendererOptions : BaseOptions
    {
        public override JsonCollection BuildParams()
        {
            throw new System.NotImplementedException();
        }
    }
}
