using System;
using System.Collections.Generic;
using System.Drawing;
using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Abstract;
using Subgurim.Maps.Google.Enums;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google.Options
{
    internal class MapOptions : BaseOptions
    {
        private static readonly Color DefaultBackColor = Color.Empty;
        private const bool DefaultDisableDefaultUi = false;
        private const bool DefaultDisableDoubleClickZoom = false;
        private const bool DefaultDraggable = true;
        private const bool DefaultKeyboardShortcuts = true;
        private const bool DefaultMapTypeControl = false;
        private const bool DefaultOverviewMapControl = false;
        private const bool DefaultNoClear = false; // If true, does not clear the map div
        private const bool DefaultPanControl = false;
        private const bool DefaultRotateControl = false;
        private const bool DefaultScaleControl = false;
        private const bool DefaultScrollwheel = true;
        private const bool DefaultStreetViewControl = false;
        private const bool DefaultZoomControl = false;

        private Type mapType;

        public Color BackgroundColor { get; set; }
        public LatLng Center { get; set; }
        public bool DisableDefaultUI { get; set; }
        public bool DisableDoubleClickZoom { get; set; }
        public bool Draggable { get; set; }
        public Cursor DraggableCursor { get; set; }
        public Cursor DraggingCursor { get; set; }
        public int? Heading { get; set; }
        public bool KeyboardShortcuts { get; set; }
        public bool? MapTypeControl { get; set; }
        public MapTypeControlOptions MapTypeControlOptions { get; set; }
        public MapTypeIds? MapTypeId { get; set; }
        public int? MaxZoom { get; set; }
        public int? MinZoom { get; set; }
        public bool NoClear { get; set; }
        public bool OverviewMapControl { get; set; }
        public OverviewMapControlOptions OverviewMapControlOptions { get; set; }
        public bool PanControl { get; set; }
        public PanControlOptions PanControlOptions { get; set; }
        public bool RotateControl { get; set; }
        public RotateControlOptions RotateControlOptions { get; set; }
        public bool ScaleControl { get; set; }
        public ScaleControlOptions ScaleControlOptions { get; set; }
        public bool Scrollwheel { get; set; }
        public StreetViewPanorama StreetView { get; set; }
        public bool StreetViewControl { get; set; }
        public StreetViewControlOptions StreetViewControlOptions { get; set; }
        public IList<MapTypeStyle> Styles { get; set; }
        public int? Tilt { get; set; }
        public int? Zoom { get; set; }
        public bool ZoomControl { get; set; }
        public ZoomControlOptions ZoomControlOptions { get; set; }

        public MapOptions(Type mapType)
        {
            this.mapType = mapType;

            DisableDefaultUI = DefaultDisableDefaultUi;
            DisableDoubleClickZoom = DefaultDisableDoubleClickZoom;
            Draggable = DefaultDraggable;
            KeyboardShortcuts = DefaultKeyboardShortcuts;
            MapTypeControl = DefaultMapTypeControl;
            NoClear = DefaultNoClear;
            OverviewMapControl = DefaultOverviewMapControl;
            PanControl = DefaultPanControl;
            ScaleControl = DefaultScaleControl;
            Scrollwheel = DefaultScrollwheel;
            StreetViewControl = DefaultStreetViewControl;

            Styles = new List<MapTypeStyle>();
        }

        public override string ToString()
        {
            return ToString(true);
        }

        /// <summary>
        /// Returns a Javascript array with the specified options.
        /// </summary>
        /// <param name="addInitialComma">Specify if you want an initial comma or just the array.</param>
        /// <returns></returns>
        public string ToString(bool addInitialComma)
        {
            return BuildParams(addInitialComma).ToString();
        }

        public override JsonCollection BuildParams()
        {
            return BuildParams(true);
        }

        public JsonCollection BuildParams(bool addInitialComma)
        {
            var optionList = new JsonCollection(addInitialComma);

            optionList.Add("backgroundColor", JavascriptHelper.GetStringFromColor(BackgroundColor), BackgroundColor != DefaultBackColor, typeof(string));
            optionList.Add("center", Center == null ? string.Empty : Center.ToStringNew(), Center != null);
            optionList.Add("disableDefaultUI", DisableDefaultUI, DisableDefaultUI != DefaultDisableDefaultUi, typeof(bool));
            optionList.Add("disableDoubleClickZoom", DisableDoubleClickZoom, DisableDoubleClickZoom != DefaultDisableDoubleClickZoom, typeof(bool));
            optionList.Add("draggable", Draggable, Draggable != DefaultDraggable, typeof(bool));
            optionList.Add("draggableCursor", DraggableCursor, DraggableCursor != Cursor.None, typeof(string));
            optionList.Add("draggingCursor", DraggingCursor, DraggingCursor != Cursor.None, typeof(string));
            optionList.Add("heading", Heading, Heading.HasValue);
            optionList.Add("keyboardShortcuts", KeyboardShortcuts, DisableDefaultUI || KeyboardShortcuts != DefaultKeyboardShortcuts, typeof(bool));
            // TODO :: MapMaker
            // optionList.Add("mapMaker", MapMaker, MapMaker != DefaultMapMaker, typeof(bool));
            if (MapTypeControl.HasValue)
            {
                optionList.Add<bool>("mapTypeControl", MapTypeControl.Value);
            }
            optionList.Add("mapTypeControlOptions", MapTypeControlOptions, MapTypeControlOptions != null);
            optionList.Add("mapTypeId", GetMapType(MapTypeId));
            optionList.Add("maxZoom", MaxZoom, MaxZoom.HasValue);
            optionList.Add("minZoom", MinZoom, MinZoom.HasValue);
            optionList.Add("noClear", NoClear, NoClear != DefaultNoClear, typeof(bool));
            optionList.Add("overviewMapControl", OverviewMapControl, OverviewMapControl != DefaultOverviewMapControl, typeof(bool));
            optionList.Add("overviewMapControlOptions", OverviewMapControlOptions, OverviewMapControlOptions != null);
            optionList.Add("panControl", PanControl, PanControl != DefaultPanControl, typeof(bool));
            optionList.Add("panControlOptions", PanControlOptions, PanControlOptions != null);
            optionList.Add("rotateControl", RotateControl, RotateControl != DefaultRotateControl, typeof(bool));
            optionList.Add("rotateControlOptions", RotateControlOptions, RotateControlOptions != null);
            optionList.Add("scaleControl", ScaleControl, ScaleControl != DefaultScaleControl, typeof(bool));
            optionList.Add("scaleControlOptions", ScaleControlOptions, ScaleControlOptions != null);
            optionList.Add("scrollwheel", Scrollwheel, Scrollwheel != DefaultScrollwheel, typeof(bool));
            optionList.Add("streetView", StreetView != null, StreetView != null, typeof(bool));
            optionList.Add("streetViewControl", StreetViewControl, StreetViewControl != DefaultStreetViewControl, typeof(bool));
            optionList.Add("streetViewControlOptions", StreetViewControlOptions, StreetViewControlOptions != null);
            optionList.Add("styles", Styles, Styles.Count > 0, typeof(bool));
            optionList.Add("tilt", Tilt, Tilt.HasValue);
            optionList.Add("zoom", Zoom, Zoom.HasValue, typeof(int));
            optionList.Add("zoomControl", ZoomControl, ZoomControl != DefaultZoomControl, typeof(bool));
            optionList.Add("zoomControlOptions", ZoomControlOptions, ZoomControlOptions != null);

            return optionList;
        }

        // TODO :: "G_MAPMAKER_NORMAL_MAP", "G_MAPMAKER_HYBRID_MAP" - MapMaker tiles not implemented v3
        internal static string GetMapType(MapTypeIds? ids)
        {
            if (ids.HasValue)
            {
                switch (ids.Value)
                {
                    case MapTypeIds.Hybrid:
                        return "google.maps.MapTypeId.HYBRID";
                    case MapTypeIds.Roadmap:
                        return "google.maps.MapTypeId.ROADMAP";
                    case MapTypeIds.Satellite:
                        return "google.maps.MapTypeId.SATELLITE";
                    case MapTypeIds.Terrain:
                        return "google.maps.MapTypeId.TERRAIN";
                }
            }

            return "google.maps.MapTypeId.ROADMAP";
        }
    }
}
