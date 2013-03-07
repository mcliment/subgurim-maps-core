using System;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google
{
    [Serializable]
    internal class Point
    {
        private double x;

        private double y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return X.ToString(MapHelper.UsCulture) + "," + Y.ToString(MapHelper.UsCulture);
        }

        public string ToStringNew()
        {
            return string.Format("new google.maps.Point({0})", ToString());
        }

        public override bool Equals(object obj)
        {
            Point point = (Point) obj;

            return (X.Equals(point.X)) && (Y.Equals(point.Y));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
