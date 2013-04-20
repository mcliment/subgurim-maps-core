using System.Collections.Generic;
using System.Text;
using Subgurim.Maps.Core.Google;

namespace Subgurim.Maps.Core.Helpers
{
    public class ArrayHelper
    {
        internal static string CreateLatLngArray(IList<LatLng> path, string arrayName)
        {
            var sb = new StringBuilder();

            sb.AppendFormat("var {0} = [", arrayName);

            string[] points = new string[path.Count];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = path[i].ToStringNew();
            }

            sb.Append(string.Join(",", points));

            sb.Append("];");

            return sb.ToString();
        }

        internal static string CreateLatLngArray(IList<IList<LatLng>> paths, string arrayName)
        {
            var sb = new StringBuilder();

            sb.AppendFormat("var {0} = [", arrayName);

            string[] pathArray = new string[paths.Count];

            for (int i = 0; i < pathArray.Length; i++)
            {
                sb.Append("[");

                string[] points = new string[paths[i].Count];

                for (int j = 0; j < points.Length; j++)
                {
                    points[j] = paths[i][j].ToStringNew();
                }

                sb.Append(string.Join(",", points));

                if (i < pathArray.Length - 1)
                {
                    sb.Append("],");
                }
                else
                {
                    sb.Append("]");
                }
            }

            sb.Append(string.Join(",", pathArray));

            sb.Append("];");

            return sb.ToString();
        }
    }
}
