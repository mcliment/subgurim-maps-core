using System;
using Subgurim.Maps.Core.Collections;
using Subgurim.Maps.Core.Google.Abstract;

namespace Subgurim.Maps.Core.Google.Options
{
    internal enum Animation
    {
        None = 0,
        /// <summary>
        /// Marker bounces until animation is stopped.
        /// </summary>
        Bounce,
        /// <summary>
        /// Marker falls from the top of the map ending with a small bounce.
        /// </summary>
        Drop
    }

    [Serializable]
    internal class MarkerOptions : BaseOptions
    {
        /// <summary>
        /// Which animation to play when marker is added to a map.
        /// </summary>
        public Animation Animation { get; set; }

        /// <summary>
        /// If true, the marker receives mouse and touch events. Default value is true.
        /// </summary>
        public bool? Clickable { get; set; }

        /// <summary>
        /// Mouse cursor to show on hover
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// If true, the marker can be dragged. Default value is false.
        /// </summary>
        public bool? Draggable { get; set; }

        /// <summary>
        /// If true, the marker shadow will not be displayed.
        /// </summary>
        public bool? Flat { get; set; }

        /// <summary>
        /// Icon for the foreground
        /// </summary>
        public MarkerImage Icon { get; set; }

        /// <summary>
        /// Raw javascript for the MarkerImage
        /// </summary>
        public string IconText { get; set; }

        /// <summary>
        /// Map on which to display Marker.
        /// </summary>
        public string Map { get; set; }

        /// <summary>
        /// Optimization renders many markers as a single static element.
        /// Optimized rendering is enabled by default.
        /// Disable optimized rendering for animated GIFs or PNGs, or when each marker
        /// must be rendered as a separate DOM element (advanced usage only).
        /// </summary>
        public bool? Optimized { get; set; }

        /// <summary>
        /// Marker position. Required.
        /// </summary>
        public LatLng Position { get; set; }

        /// <summary>
        /// To specify a function to get the position from.
        /// </summary>
        public string PositionLiteral { get; set; }

        /// <summary>
        /// If false, disables raising and lowering the marker on drag. This option is true by default.
        /// </summary>
        public bool? RaiseOnDrag { get; set; }

        /// <summary>
        /// Shadow image
        /// </summary>
        public MarkerImage Shadow { get; set; }

        /// <summary>
        /// Raw Javascript value for shadow
        /// </summary>
        public string ShadowText { get; set; }

        /// <summary>
        /// Image map region definition used for drag/click.
        /// </summary>
        public MarkerShape Shape { get; set; }

        /// <summary>
        /// Raw JS value for the Shape.
        /// </summary>
        public string ShapeText { get; set; }

        /// <summary>
        /// Rollover text
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// If true, the marker is visible
        /// </summary>
        public bool? Visible { get; set; }

        /// <summary>
        /// All markers are displayed on the map in order of their zIndex, 
        /// with higher values displaying in front of markers with lower values. 
        /// By default, markers are displayed according to their vertical position on screen, 
        /// with lower markers appearing in front of markers further up the screen.
        /// </summary>
        public int? ZIndex { get; set; }

        /// <summary>
        /// This allows us to do some things before calling the JS constructor in order to
        /// create variables needed by IconText or ShadowText
        /// </summary>
        public string PreText { get; set; }

        public override JsonCollection BuildParams()
        {
            JsonCollection options = new JsonCollection(false);

            if (string.IsNullOrEmpty(PositionLiteral))
            {
                options.Add("position", Position == null ? string.Empty : this.Position.ToStringNew(), Position != null);
            }
            else
            {
                options.Add("position", PositionLiteral);
            }

            options.Add("animation", this.Animation.ToString().ToLowerInvariant(), Animation != Animation.None, typeof(string));
            options.Add("clickable", this.Clickable, this.Clickable.HasValue, typeof(bool));
            options.Add("clickable", this.Cursor, !string.IsNullOrEmpty(Cursor), typeof(string));
            options.Add("draggable", this.Draggable, this.Draggable.HasValue, typeof(bool));
            options.Add("flat", this.Flat, this.Flat.HasValue, typeof(bool));
            options.Add("map", this.Map);
            options.Add("optimized", this.Optimized, this.Optimized.HasValue, typeof(bool));
            options.Add("raiseOnDrag", this.RaiseOnDrag, this.RaiseOnDrag.HasValue, typeof(bool));
            options.Add("title", this.Title, !string.IsNullOrEmpty(Title), typeof(string));
            options.Add("visible", this.Visible, this.Visible.HasValue, typeof(bool));
            options.Add("zIndex", this.ZIndex, this.ZIndex.HasValue, typeof(int));

            if (!string.IsNullOrEmpty(this.IconText))
            {
                options.Add("icon", this.IconText);
            }
            else
            {
                options.Add("icon", this.Icon, this.Icon != null);
            }

            if (!string.IsNullOrEmpty(this.ShadowText))
            {
                options.Add("shadow", this.ShadowText);
            }
            else
            {
                options.Add("shadow", this.Shadow, this.Icon != null);
            }

            if (!string.IsNullOrEmpty(this.ShapeText))
            {
                options.Add("shape", this.ShapeText);
            }
            else
            {
                options.Add("shape", this.Shape, this.Shape != null);
            }

            return options;
        }
    }
}
