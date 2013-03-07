using System;
using Subgurim.Maps.Helpers;

namespace Subgurim.Maps.Google
{
    [Serializable]
    internal class Size
    {
        private double width;
        private double height;

        private readonly string widthUnit;
        private readonly string heightUnit;

        public Size() : this(7, 7)
        {
        }

        public Size(double width, double height) : this(width, height, null, null)
        {
        }

        internal Size(double width, double height, string widthUnit, string heightUnit)
        {
            this.width = width;
            this.height = height;
            this.widthUnit = widthUnit;
            this.heightUnit = heightUnit;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        #region ToString

        public override string ToString()
        {
            return width.ToString(MapHelper.UsCulture) + "," + height.ToString(MapHelper.UsCulture);
        }
        
        public string ToStringNew()
        {
            return string.Format("new google.maps.Size({0})", ToString());
        }

        #endregion
    }
}
