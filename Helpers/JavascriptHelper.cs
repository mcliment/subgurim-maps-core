using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Subgurim.Maps.Helpers
{
    public static class JavascriptHelper
    {
        internal static string PrepareJavascript(string inJS, bool ultraMinimize)
        {
            if (String.IsNullOrEmpty(inJS)) return inJS;

            string outJS = inJS;

            outJS = outJS.Replace("'", "\\'");

            ////Only For Localhst
            //if (IsInLocalHost())
            //{
            //    return outJS;
            //}

            outJS = Minimize(outJS, ultraMinimize);

            return outJS;
        }

        internal static string Minimize(string inJS, bool ultraMinimize)
        {
#if DEBUG
            return inJS;
#endif
            string outJS = inJS.Trim();

            outJS = Regex.Replace(outJS, @"\s+", " ");
            outJS = Regex.Replace(outJS, @"[\r\n\t]", " ");

            if (ultraMinimize)
                outJS = Regex.Replace(outJS, @"\s?([{};()=+!',.])\s?", "$1");

            return outJS;
        }

        internal static Color GetColorFromString(string sColor)
        {
            sColor = sColor.ToUpper().Replace("#", "");

            bool invalid = (sColor.Length != 6) || Regex.IsMatch(sColor, "[^A-F0-9]");
            if (!invalid)
            {
                int R = Int32.Parse(sColor.Substring(0, 2), NumberStyles.HexNumber);
                int G = Int32.Parse(sColor.Substring(2, 2), NumberStyles.HexNumber);
                int B = Int32.Parse(sColor.Substring(4, 2), NumberStyles.HexNumber);

                return Color.FromArgb(R, G, B);
            }

            return Color.Empty;
        }

        internal static string GetStringFromColor(Color color)
        {
            return GetStringFromColor(color, true);
        }

        internal static string GetStringFromColor(Color color, bool includeSharp)
        {
            return String.Format("{3}{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B, includeSharp ? "#" : String.Empty);
        }
    }
}