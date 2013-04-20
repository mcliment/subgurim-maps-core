using System;
using Subgurim.Maps.Core.Collections;
using Subgurim.Maps.Core.Google.Abstract;

namespace Subgurim.Maps.Core.Google
{
    [Serializable]
    internal class MarkerShape : BaseMapObject
    {
        public enum ShapeType
        {
            Cirle,
            Poly,
            Rect
        }

        public MarkerShape(string[] coords, ShapeType type)
        {
            this.Coords = coords;
            this.Type = type;
        }

        /// <summary>
        /// The format of this attribute depends on the value of the type and follows the w3 AREA
        /// coords specification found at http://www.w3.org/TR/REC-html40/struct/objects.html#adef-coords.
        /// The coords attribute is an array of integers that specify the pixel position of the shape
        /// relative to the top-left corner of the target image. The coordinates depend on the value
        /// of type as follows:
        /// <ul>
        /// <li>circle: coords is [x1,y1,r] where x1,y2 are the coordinates of the center of the circle,
        /// and r is the radius of the circle.</li>
        /// <li>poly: coords is [x1,y1,x2,y2...xn,yn] where each x,y pair contains the coordinates of one
        /// vertex of the polygon.</li>
        /// <li>rect: coords is [x1,y1,x2,y2] where x1,y1 are the coordinates of the upper-left corner of
        /// the rectangle and x2,y2 are the coordinates of the lower-right coordinates of the rectangle.</li>
        /// </ul>>
        /// </summary>
        public string[] Coords { get; set; }

        /// <summary>
        /// Describes the shape's type
        /// </summary>
        public ShapeType Type { get; set; }

        public override string ToString()
        {
            var options = new JsonCollection(false);

            options.Add("coords", string.Format("[{0}]", string.Join(",", Coords)));
            options.Add("type", Type.ToString(), typeof(string));

            return string.Format("new google.maps.MarkerShape({0})", options);
        }
    }
}