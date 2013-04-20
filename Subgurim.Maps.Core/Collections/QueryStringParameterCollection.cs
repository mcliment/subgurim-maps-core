namespace Subgurim.Maps.Core.Collections
{
    public class QueryStringParameterCollection : AdvancedCollection
    {
        public QueryStringParameterCollection() : base("?", string.Empty, "&", "=")
        {
        }
    }
}