using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Abstract;

namespace Subgurim.Maps.Google.Options
{
    internal class StreetViewPanoramaOptions : BaseOptions
    {
        /// <summary>
        /// The enabled/disabled state of the address control.
        /// </summary>
        public bool? AddressControl { get; set; }

        /// <summary>
        /// The display options for the address control.
        /// </summary>
        public StreetViewAddressControlOptions AddressControlOptions { get; set; }

        /// <summary>
        /// Enables/disables zoom on double click. Enabled by default.
        /// </summary>
        public bool? DisableDoubleClickZoom { get; set; }

        /// <summary>
        /// If true, the close button is displayed. Disabled by default.
        /// </summary>
        public bool? EnableCloseButton { get; set; }

        /// <summary>
        /// The enabled/disabled state of the imagery acquisition date control.
        /// </summary>
        public bool? ImageDateControl { get; set; }

        /// <summary>
        /// The enabled/disabled state of the links control.
        /// </summary>
        public bool? LinksControl { get; set; }

        /// <summary>
        /// The enabled/disabled state of the pan control.
        /// </summary>
        public bool? PanControl { get; set; }

        /// <summary>
        /// The display options for the pan control.
        /// </summary>
        public PanControlOptions PanControlOptions { get; set; }

        /// <summary>
        /// The panorama ID, which should be set when specifying a custom panorama.
        /// </summary>
        public string Pano { get; set; }

        /// <summary>
        /// Function(string):StreetViewPanoramaData	Custom panorama provider, which takes a string pano id and returns an object defining the panorama given that id. This function must be defined to specify custom panorama imagery.
        /// </summary>
        public string PanoProvider { get; set; }

        /// <summary>
        /// The LatLng position of the Street View panorama.
        /// </summary>
        public LatLng Position { get; set; }

        /// <summary>
        /// The camera orientation, specified as heading, pitch, and zoom, for the panorama.
        /// </summary>
        public StreetViewPov Pov { get; set; }

        /// <summary>
        /// If false, disables scrollwheel zooming in Street View. The scrollwheel is enabled by default.
        /// </summary>
        public bool? Scrollwheel { get; set; }

        /// <summary>
        /// If true, the Street View panorama is visible on load.
        /// </summary>
        public bool? Visible { get; set; }

        /// <summary>
        /// The enabled/disabled state of the zoom control.
        /// </summary>
        public bool? ZoomControl { get; set; }

        /// <summary>
        /// The display options for the zoom control.
        /// </summary>
        public ZoomControlOptions ZoomControlOptions { get; set; }

        public override JsonCollection BuildParams()
        {
            JsonCollection options = new JsonCollection(false);

            options.Add("addressControl", AddressControl.Value, AddressControl.HasValue, typeof(bool));
            options.Add("addressControlOptions", AddressControlOptions.ToString(), AddressControlOptions != null);
            options.Add("disableDoubleClickZoom", DisableDoubleClickZoom.Value, DisableDoubleClickZoom.HasValue, typeof(bool));
            options.Add("enableCloseButton", EnableCloseButton.Value, EnableCloseButton.HasValue, typeof(bool));
            options.Add("imageDateControl", ImageDateControl.Value, ImageDateControl.HasValue, typeof(bool));
            options.Add("linksControl", LinksControl.Value, LinksControl.HasValue, typeof(bool));
            options.Add("panControl", PanControl.Value, PanControl.HasValue, typeof(bool));
            options.Add("panControlOptions", PanControlOptions.ToString(), PanControlOptions != null);
            options.Add("pano", Pano, !string.IsNullOrEmpty(Pano), typeof(string));
            options.Add("panoProvider", PanoProvider, !string.IsNullOrEmpty(PanoProvider));
            options.Add("position", Position.ToStringNew(), Position != null);
            options.Add("pov", Pov.ToString(), Pov != null);
            options.Add("scrollwheel", Scrollwheel.Value, Scrollwheel.HasValue, typeof(bool));
            options.Add("visible", Visible.Value, Visible.HasValue, typeof(bool));
            options.Add("zoomControl", ZoomControl.Value, ZoomControl.HasValue, typeof(bool));
            options.Add("zoomControlOptions", ZoomControlOptions.ToString(), ZoomControlOptions != null);

            return options;
        }
    }
}