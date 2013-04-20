using System.Globalization;

namespace Subgurim.Maps.Core.Helpers
{
    public static class MapHelper
    {
        internal static readonly CultureInfo UsCulture = new CultureInfo("en-US", false);

        private static int _counter;

        private static int Counter
        {
            get { return _counter++; }
        }

        internal static string UniqueId
        {
            get { return string.Format("subgurim_{0}_", Counter); }
        }
    }
}