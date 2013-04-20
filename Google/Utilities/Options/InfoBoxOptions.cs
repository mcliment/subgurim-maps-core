using System;
using Subgurim.Maps.Core.Collections;
using Subgurim.Maps.Core.Google.Options;

namespace Subgurim.Maps.Core.Google.Utilities.Options
{
    [Serializable]
    internal class InfoBoxOptions : InfoWindowOptions
    {
        public InfoBoxOptions()
        {
        }

        public InfoBoxOptions(InfoWindowOptions options)
        {
            this.Content = options.Content;
            this.DisableAutoPan = options.DisableAutoPan;
            this.MaxWidth = options.MaxWidth;
            this.PixelOffset = options.PixelOffset;
            this.Position = options.Position;
            this.ZIndex = options.ZIndex;
        }

        /// <summary>
        /// Align the bottom left corner of the InfoBox to the position location (default is false 
        /// which means that the top left corner of the InfoBox is aligned).
        /// </summary>
        public bool? AlignBottom { get; set; }

        /// <summary>
        /// The name of the CSS class defining the styles for the InfoBox container. 
        /// The default name is infoBox.
        /// </summary>
        public string BoxClass { get; set; }

        /// <summary>
        /// An object literal whose properties define specific CSS style values to be applied to the InfoBox.
        /// Style values defined here override those that may be defined in the boxClass style sheet.
        /// If this property is changed after the InfoBox has been created, all previously set styles
        /// (except those defined in the style sheet) are removed from the InfoBox before the new style
        /// values are applied.
        /// </summary>
        public string BoxStyle { get; set; }

        /// <summary>
        /// The CSS margin style value for the close box. The default is "2px" (a 2-pixel margin on all sides).
        /// </summary>
        public string CloseBoxMargin { get; set; }

        /// <summary>
        /// The URL of the image representing the close box. Note: The default is the URL for Google's standard
        /// close box. Set this property to "" if no close box is required.
        /// </summary>
        public string CloseBoxUrl { get; set; }

        /// <summary>
        /// Propagate mousedown, click, dblclick, and contextmenu events in the InfoBox (default is false
        /// to mimic the behavior of a google.maps.InfoWindow). Set this property to true if the InfoBox
        /// is being used as a map label. iPhone note: This property setting has no effect; events are
        /// always propagated.
        /// </summary>
        public bool? EnableEventPropagation { get; set; }

        /// <summary>
        /// Minimum offset (in pixels) from the InfoBox to the map edge after an auto-pan.
        /// </summary>
        public Size InfoBoxClearance { get; set; }

        /// <summary>
        /// Hide the InfoBox on open (default is false).
        /// </summary>
        public bool? IsHidden { get; set; }

        /// <summary>
        /// The pane where the InfoBox is to appear (default is "floatPane"). Set the pane to "mapPane"
        /// if the InfoBox is being used as a map label. Valid pane names are the property names for the
        /// google.maps.MapPanes object.
        /// </summary>
        public string Pane { get; set; }

        public override JsonCollection BuildParams()
        {
            JsonCollection options = base.BuildParams();

            options.Add<bool>("alignBottom", AlignBottom, AlignBottom.HasValue);
            options.Add<string>("boxClass", BoxClass, !string.IsNullOrEmpty(BoxClass));
            options.Add("boxStyle", BoxStyle, !string.IsNullOrEmpty(BoxStyle));
            options.Add<string>("closeBoxMargin", CloseBoxMargin, !string.IsNullOrEmpty(CloseBoxMargin));
            options.Add<string>("closeBoxURL", CloseBoxUrl, !string.IsNullOrEmpty(CloseBoxUrl));
            // options.Add<string>("content", Content, !string.IsNullOrEmpty(Content));
            // options.Add<bool>("disableAutoPan", DisableAutoPan, DisableAutoPan);
            options.Add<bool>("enableEventPropagation", EnableEventPropagation, EnableEventPropagation.HasValue);

            if (InfoBoxClearance != null)
            {
                options.Add("infoBoxClearance", InfoBoxClearance.ToStringNew());
            }

            options.Add<bool>("isHidden", IsHidden, IsHidden.HasValue);
            // options.Add<int>("maxWidth", MaxWidth, MaxWidth.HasValue);
            options.Add<string>("pane", Pane, !string.IsNullOrEmpty(Pane));

            //if (PixelOffset != null)
            //{
            //    options.Add("pixelOffset", PixelOffset.ToStringNew());
            //}

            //if (Position != null)
            //{
            //    options.Add("position", Position.ToStringNew());
            //}

            //options.Add<int>("zIndex", ZIndex, ZIndex.HasValue);

            return options;
        }
    }
}