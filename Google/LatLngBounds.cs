using System;

namespace Subgurim.Maps.Google
{
    internal class LatLngBounds
    {
        public LatLngBounds(LatLng sw, LatLng ne)
        {
            this.SW = new LatLng(sw.Lat, sw.Lng);
            this.NE = new LatLng(ne.Lat, ne.Lng);
        }

        public LatLngBounds(Polygon polygon) : this(new Polyline(polygon))
        {
        }

        public LatLngBounds(Polyline polyline)
        {
            if (polyline.Options.Path.Count > 0)
            {
                LatLng initialPoint = polyline.Options.Path[0];
                this.SW = new LatLng(initialPoint.Lat, initialPoint.Lng);
                this.NE = new LatLng(initialPoint.Lat, initialPoint.Lng);

                foreach (LatLng point in polyline.Options.Path)
                {
                    this.Extend(point);
                }
            }
        }

        public LatLng SW { get; set; }

        public LatLng NE { get; set; }

        public override string ToString()
        {
            return string.Format("new google.maps.LatLngBounds({0}, {1})", SW.ToStringNew(), NE.ToStringNew());
        }

        public LatLng GetCenter()
        {
            return SW + (ToSpan()/2);
        }

        public LatLng ToSpan()
        {
            return new LatLng(NE.Lat - SW.Lat, NE.Lng - SW.Lng);
        }

        public void Extend(LatLng latlng)
        {
            if (this.IsNull())
            {
                SW = latlng.Clone();
                NE = latlng.Clone();
            }

            ExtendLatitude(latlng);
            ExtendLongitude(latlng);
        }

        public bool IsEmpty()
        {
            return (SW == null) || (NE == null) || (SW == NE);
        }

        public bool IsNull()
        {
            return (SW == null) || (NE == null) || ((SW == new LatLng(0, 0)) && (NE == new LatLng(0, 0)));
        }

        private void ExtendLatitude(LatLng latlng)
        {
            if (this.IsEmpty() || !ContainsLatitude(latlng))
            {
                if (latlng.Lat > NE.Lat)
                {
                    NE.Lat = latlng.Lat;
                }
                else
                {
                    SW.Lat = latlng.Lat;
                }
            }
        }

        private void ExtendLongitude(LatLng latlng)
        {
            if (this.IsEmpty() || !ContainsLongitude(latlng))
            {
                double swDistance = Math.Abs(latlng.Lng - SW.Lng);
                double neDistance = Math.Abs(latlng.Lng - NE.Lng);

                if (swDistance > neDistance)
                {
                    NE.Lng = latlng.Lng;
                }
                else
                {
                    SW.Lng = latlng.Lng;
                }
            }
        }

        #region Contains

        public bool Contains(LatLng latlng)
        {
            bool containsLat = ContainsLatitude(latlng);
            bool containsLng = ContainsLongitude(latlng);

            return containsLat && containsLng;
        }

        private bool ContainsLongitude(LatLng latlng)
        {
            return (latlng.Lng <= NE.Lng) && (latlng.Lng >= SW.Lng);
        }

        private bool ContainsLatitude(LatLng latlng)
        {
            return (latlng.Lat <= NE.Lat) && (latlng.Lat >= SW.Lat);
        }

        #endregion
    }


}
