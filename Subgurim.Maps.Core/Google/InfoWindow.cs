using System;
using System.Text;
using Subgurim.Maps.Core.Google.Abstract;
using Subgurim.Maps.Core.Google.Events;
using Subgurim.Maps.Core.Google.Options;

namespace Subgurim.Maps.Core.Google
{
    [Serializable]
    internal class InfoWindow : BaseMapObject<InfoWindowOptions>
    {
        private string mapId;
        private BaseMapObject anchor;

        private MarkerEvents _markerEvent = MarkerEvents.Click;
        private PolygonEvents _polygonEvent = PolygonEvents.Click;
        private PolylineEvents _polylineEvent = PolylineEvents.Click;

        #region Constructor

        public InfoWindow() : this(new InfoWindowOptions())
        {
        }

        public InfoWindow(Marker marker, string html)
        {
            this.SetAnchor(marker);

            this.Options = new InfoWindowOptions()
                               {
                                   Content = html
                               };
        }

        public InfoWindow(InfoWindowOptions options)
        {
            this.Options = options;
        }

        public InfoWindow(InfoWindowOptions options, string id) : this(options)
        {
            this.Id = id;
        }

        #endregion

        #region Properties

        public bool OpenOnLoad { get; set; }

        public string OpenFunction { get; set; }

        public string CloseFunction { get; set; }

        /// <summary>
        /// If true, behaves as Maps API v3 and keeps all InfoWindows open when a new InfoWindow is
        /// opened. If false, all InfoWindows are closed when other is openen. Default is false.
        /// </summary>
        public bool KeepOpenWindows { get; set; }

        protected virtual string ClassName
        {
            get { return "google.maps.InfoWindow"; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sets the object to anchor the Window to.
        /// </summary>
        /// <param name="anchorObject">An object, typically a Marker, Polygon or Polyline</param>
        public void SetAnchor(BaseMapObject anchorObject)
        {
            this.anchor = anchorObject;
        }

        public Marker GetMarker()
        {
            return this.anchor as Marker;
        }

        public void SetMapId(string map)
        {
            this.mapId = map;
        }

        public void SetAnchorEvent(MarkerEvents anchorEvent)
        {
            this._markerEvent = anchorEvent;
        }

        public void SetAnchorEvent(PolygonEvents polygonEvent)
        {
            this._polygonEvent = polygonEvent;
        }

        public void SetAnchorEvent(PolylineEvents polylineEvent)
        {
            this._polylineEvent = polylineEvent;
        }

        #endregion

        #region ToString

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (anchor != null)
            {
                // TODO :: Old classes conversion -> TO ASP.NET
                //if (anchor.GetType().IsAssignableFrom(typeof(Marker)))
                //{
                //    anchor = ((Marker) anchor).ToMarker(this.mapId);
                //}
                //else if (anchor.GetType() == typeof(Polygon))
                //{
                //    anchor = ((Polygon)anchor).ToPolygon(this.mapId);
                //}
                //else if (anchor.GetType() == typeof(Polyline))
                //{
                //    anchor = ((Polyline)anchor).ToPolyline(this.mapId);
                //}

                if (anchor is Marker)
                {
                    Marker marker = (Marker) anchor;

                    sb.Append(marker.ToString());

                    // Create Window
                    if (!string.IsNullOrEmpty(Id))
                    {
                        sb.AppendFormat("var {0}=new {2}({1});", Id, Options, ClassName);
                    }
                    else
                    {
                        sb.AppendFormat("new {1}({0});", Options, ClassName);
                    }

                    // Assign event
                    if (!KeepOpenWindows)
                    {
                        sb.AppendFormat("google.maps.event.addListener({0},'{1}',function(){{closeWindows('{3}');{2}.open({3},{0});}});",
                                        marker.Id, _markerEvent, Id, mapId);
                    }
                    else
                    {
                        sb.AppendFormat("google.maps.event.addListener({0},'{1}',function(){{{2}.open({3},{0});}});",
                                        marker.Id, _markerEvent, Id, mapId);
                    }

                    if (OpenOnLoad)
                    {
                        if (!KeepOpenWindows)
                        {
                            sb.AppendFormat("closeWindows('{0}');", mapId);
                        }

                        sb.AppendFormat("{0}.open({1},{2});", Id, mapId, marker.Id);
                    }
                }
                else if (anchor.GetType() == typeof (Polygon))
                {
                    Polygon polygon = (Polygon) anchor;

                    polygon.Options.Clickable = true;

                    LatLngBounds latLngBounds = new LatLngBounds(polygon);

                    Options.Position = latLngBounds.GetCenter();

                    // Create poly
                    sb.AppendFormat("{0}{1};", polygon.ToStringPath(), polygon);

                    // Create Window
                    if (!string.IsNullOrEmpty(Id))
                    {
                        sb.AppendFormat("var {0}=new {2}({1});", Id, Options, ClassName);
                    }
                    else
                    {
                        sb.AppendFormat("new {1}({0});", Options, ClassName);
                    }

                    // Assign event
                    if (!KeepOpenWindows)
                    {
                        sb.AppendFormat("google.maps.event.addListener({0},'{1}',function(){{closeWindows('{3}');{2}.open({3});}});",
                                        polygon.Id, _polygonEvent, Id, mapId);
                    }
                    else
                    {
                        sb.AppendFormat("google.maps.event.addListener({0},'{1}',function(){{{2}.open({3});}});",
                                        polygon.Id, _polygonEvent, Id, mapId);
                    }

                    if (OpenOnLoad)
                    {
                        if (!KeepOpenWindows)
                        {
                            sb.AppendFormat("closeWindows('{0}');", mapId);
                        }

                        sb.AppendFormat("{0}.open({1});", Id, mapId);
                    }
                }
                else if (anchor.GetType() == typeof (Polyline))
                {
                    Polyline polyline = (Polyline) anchor;

                    polyline.Options.Clickable = true;

                    LatLngBounds latLngBounds = new LatLngBounds(polyline);

                    Options.Position = latLngBounds.GetCenter();

                    // Create poly
                    sb.AppendFormat("{0}{1};", polyline.ToStringPath(), polyline);

                    // Create Window
                    if (!string.IsNullOrEmpty(Id))
                    {
                        sb.AppendFormat("var {0}=new {2}({1});", Id, Options, ClassName);
                    }
                    else
                    {
                        sb.AppendFormat("new {1}({0});", Options, ClassName);
                    }

                    // Assign event
                    if (!KeepOpenWindows)
                    {
                        sb.AppendFormat(
                            "google.maps.event.addListener({0},'{1}',function(){{closeWindows('{3}');{2}.open({3});}});",
                            polyline.Id, _polylineEvent, Id, mapId);
                    }
                    else
                    {
                        sb.AppendFormat(
                            "google.maps.event.addListener({0},'{1}',function(){{{2}.open({3});}});",
                            polyline.Id, _polylineEvent, Id, mapId);
                    }

                    if (OpenOnLoad)
                    {
                        if (!KeepOpenWindows)
                        {
                            sb.AppendFormat("closeWindows('{0}');", mapId);
                        }

                        sb.AppendFormat("{0}.open({1});", Id, mapId);
                    }
                }
            }

            if (anchor == null)
            {
                if (!string.IsNullOrEmpty(Id))
                {
                    sb.AppendFormat("var {0}=new {2}({1});", Id, Options, ClassName);
                }
                else
                {
                    sb.AppendFormat("new {1}({0});", Options, ClassName);
                }

                if (!KeepOpenWindows)
                {
                    sb.AppendFormat("closeWindows('{0}');", mapId);
                }

                sb.AppendFormat("{0}.open({1});", Id, mapId);
            }
            
            if (!string.IsNullOrEmpty(mapId) && !string.IsNullOrEmpty(Id))
            {
                sb.AppendFormat("GMapsProperties['{0}']['windowArray'].push(['{1}',{1}]);", mapId, Id);
            }

            // Events
            if (!string.IsNullOrEmpty(OpenFunction))
            {
                sb.AppendFormat("google.maps.event.addListener({0},'domready',{1});", Id, OpenFunction);
            }

            if (!string.IsNullOrEmpty(CloseFunction))
            {
                sb.AppendFormat("google.maps.event.addListener({0},'closeclick',{1});", Id, CloseFunction);
            }

            return sb.ToString();
        }

        #endregion
    }
}
