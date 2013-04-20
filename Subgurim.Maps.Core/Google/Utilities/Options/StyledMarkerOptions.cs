using System;
using Subgurim.Maps.Core.Collections;
using Subgurim.Maps.Core.Google.Options;

namespace Subgurim.Maps.Core.Google.Utilities.Options
{
    [Serializable]
    internal class StyledMarkerOptions : MarkerOptions
    {
        #region Properties

        public StyledIcon StyleIcon { get; set; }

        #endregion

        #region Initialization
        
        public StyledMarkerOptions()
        {
        }

        public StyledMarkerOptions(StyledIcon styleIcon)
        {
            this.StyleIcon = styleIcon;
        }

        internal StyledMarkerOptions(MarkerOptions options)
        {
            this.Animation = options.Animation;
            this.Clickable = options.Clickable;
            this.Cursor = options.Cursor;
            this.Draggable = options.Draggable;
            this.Flat = options.Flat;
            this.Icon = options.Icon;
            this.Map = options.Map;
            this.Optimized = options.Optimized;
            this.Position = options.Position;
            this.PositionLiteral = options.PositionLiteral;
            this.RaiseOnDrag = options.RaiseOnDrag;
            this.Shadow = options.Shadow;
            this.Shape = options.Shape;
            this.Title = options.Title;
            this.Visible = options.Visible;
            this.ZIndex = options.ZIndex;
        }

        #endregion

        #region Methods

        #endregion

        #region ToString

        public override JsonCollection BuildParams()
        {
            JsonCollection options = base.BuildParams();

            if (StyleIcon != null)
            {
                options.Add("styleIcon", StyleIcon.ToString());
            }

            return options;
        }

        #endregion
    }
}