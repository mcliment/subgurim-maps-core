using System.Collections.Generic;
using System.Text;

namespace Subgurim.Maps.Core.Collections
{
    /// <summary>
    /// An object collection to be returned as a JSON array
    /// </summary>
    public class JsonCollection : AdvancedCollection
    {
        /// <summary>
        /// Creates a new instance of a JSON collection adding an initial comma
        /// </summary>
        public JsonCollection() : this(true)
        {
        }

        /// <summary>
        /// Creates a new instance of a JSON collection
        /// </summary>
        /// <param name="addInitialComma">If <c>true</c> the returned string will have a leading comma.</param>
        public JsonCollection(bool addInitialComma)
            : base(addInitialComma ? ",{" : "{", "}", ",", ":")
        {
        }

        public static string ToJSONArrayFromICollection(ICollection<string> collection)
        {
            StringBuilder sb = new StringBuilder();

            int i = 0;
            int count = collection.Count;
            sb.Append("[");

            foreach (string item in collection)
            {
                if (string.IsNullOrEmpty(item)) continue;

                sb.Append(item);

                if (++i < count)
                    sb.Append(",");
            }

            sb.Append("]");

            return sb.ToString();
        }
    }
}
