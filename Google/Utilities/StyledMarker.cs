using System;
using Subgurim.Maps.Google.Utilities.Options;

namespace Subgurim.Maps.Google.Utilities
{
    [JavascriptResource("StyledMarker.min")]
    [Serializable]
    internal class StyledMarker : Marker
    {
        #region Properties

        private StyledMarkerOptions _markerOptions = new StyledMarkerOptions();

        public new StyledMarkerOptions Options
        {
            get { return _markerOptions; }
            set { _markerOptions = value; }
        }

        #endregion

        #region Initialization

        public StyledMarker()
        {
        }

        public StyledMarker(LatLng position)
            : base(position)
        {
        }

        public StyledMarker(StyledMarkerOptions options)
            : base(options)
        {
            this.Options = options;
        }

        public StyledMarker(StyledMarkerOptions options, string id)
            : base(options, id)
        {
            this.Options = options;
        }

        #endregion

        #region ToString

        public override string ToString()
        {
            return string.Format(@"var {0}=new StyledMarker({1});", Id, Options);
        }

        #endregion
    }
}