using System;
using System.Globalization;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google
{
    [Serializable]
    internal class LatLng
    {
        private double lat;
        private double lng;
        private readonly bool noWrap;

        public LatLng(double lat, double lng) : this(lat, lng, false)
        {
        }

        public LatLng(double lat, double lng, bool noWrap)
        {
            this.lat = lat;
            this.lng = lng;
            this.noWrap = noWrap;
        }

        /// <summary>
        /// Latitude. [-90, 90]
        /// </summary>
        public double Lat
        {
            get { return lat; }
            set
            {
                lat = value;

                if (lat < -180 || lat > 180)
                {
                    throw new Exception("Latitude must be beetwen -90 and 90");
                }
            }
        }

        /// <summary>
        /// Longitude. [-180, 180]
        /// </summary>
        public double Lng
        {
            get { return lng; }
            set
            {
                lng = value;

                if (lng < -360 || lng > 360)
                {
                    throw new Exception("Longitude must be beetwen -180 and 180");
                }
            }
        }

        #region ToString

        public override string ToString()
        {
            return Serialize();
        }

        public string ToStringNew()
        {
            if (noWrap)
            {
                return string.Format("new google.maps.LatLng({0},true)", ToString());
            }

            return string.Format("new google.maps.LatLng({0})", ToString());
        }

        #endregion

        #region Operators

        public static LatLng operator *(LatLng latlng, double x)
        {
            return new LatLng(latlng.lat * x, latlng.lng * x);
        }

        public static LatLng operator /(LatLng latlng, double x)
        {
            return new LatLng(latlng.lat / x, latlng.lng / x);
        }

        public static LatLng operator +(LatLng a, LatLng b)
        {
            double latAux = SetLatCoordinate(a.lat + b.lat);
            double lngAux = SetLngCoordinate(a.lng + b.lng);
            return new LatLng(latAux, lngAux);
        }

        public static LatLng operator -(LatLng a, LatLng b)
        {
            double latAux = SetLatCoordinate(a.lat - b.lat);
            double lngAux = SetLngCoordinate(a.lng - b.lng);
            return new LatLng(latAux, lngAux);
        }

        public static bool operator ==(LatLng a, LatLng b)
        {
            bool anull = ReferenceEquals(a, null);
            bool bnull = ReferenceEquals(b, null);

            if (anull && bnull) return true;
            if (anull || bnull) return false;

            return a.Equals(b);
        }

        public static bool operator !=(LatLng a, LatLng b)
        {
            bool anull = ReferenceEquals(a, null);
            bool bnull = ReferenceEquals(b, null);

            if (anull && bnull) return false;
            if (anull || bnull) return true;

            return !a.Equals(b);
        }

        public override bool Equals(object _b)
        {
            if (ReferenceEquals(_b, null)) return false;

            LatLng b = (LatLng)_b;

            return (lat == b.lat) && (lng == b.lng);
        }

        /// <summary>
        /// Get the distance between this point and point b (in meters)
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double DistanceFrom(LatLng b)
        {
            return Distance(this, b);
        }

        #endregion

        #region Methods

        public string Serialize()
        {
            return Serialize(this);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public LatLng Clone()
        {
            return new LatLng(lat, lng);
        }

        public LatLng Abs()
        {
            return new LatLng(Math.Abs(lat), Math.Abs(lng));
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Get the distance between two points (in meters)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Distance(LatLng a, LatLng b)
        {
            double distance = 0.0;

            double lat1 = a.lng * Math.PI / 180.0;
            double lon1 = a.lat * Math.PI / 180.0;
            double lat2 = b.lng * Math.PI / 180.0;
            double lon2 = b.lat * Math.PI / 180.0;

            distance += 1000 * 6378.7 * Math.Acos
                                        (Math.Sin(lat1) * Math.Sin(lat2) +
                                         Math.Cos(lat1) * Math.Cos(lat2) * Math.Cos(lon2 - lon1));

            return Math.Round(distance);
        }

        public static string Serialize(LatLng latLng)
        {
            return string.Format("{0},{1}", latLng.lat.ToString(MapHelper.UsCulture), latLng.lng.ToString(MapHelper.UsCulture));
        }

        public static LatLng DeSerialize(string serializedLatLng)
        {
            if (!string.IsNullOrEmpty(serializedLatLng))
            {
                string[] serializedLatLngArray = serializedLatLng.Split(',');

                if (serializedLatLngArray.Length == 2)
                {
                    double _auxlat, _auxlng;
                    if (double.TryParse(serializedLatLngArray[0], NumberStyles.Float, MapHelper.UsCulture, out _auxlat) &&
                        double.TryParse(serializedLatLngArray[1], NumberStyles.Float, MapHelper.UsCulture, out _auxlng))
                    {
                        return new LatLng(_auxlat, _auxlng);
                    }
                }
            }

            return null;
        }

        #endregion

        #region Privates

        private static double SetLatCoordinate(double iLat)
        {
            if (Math.Abs(iLat) > 90)
                return (Math.Asin(Math.Sin(iLat * Math.PI / 180))) * 180 / Math.PI;

            return iLat;
        }

        private static double SetLngCoordinate(double iLng)
        {
            if (Math.Abs(iLng) > 180)
            {
                double sign = Math.Sign(Math.Sin(iLng * Math.PI / 180));
                double abs = Math.Abs(Math.Acos(Math.Cos(iLng * Math.PI / 180)) * 180 / Math.PI);
                return sign * abs;
                //if ((iLng < (-2*baseTransform)) || ((iLng > 2*baseTransform)))
                //    iLng = iLng%2*baseTransform;

                //if (iLng < (-1 * baseTransform))
                //    iLng = iLng + 2 * baseTransform;

                //if (iLng >  baseTransform)
                //    iLng = iLng - 2 * baseTransform;
            }

            return iLng;
        }

        #endregion
    }
}
