namespace Subgurim.Maps.Collections
{
    public class QueryStringParameterCollection : AdvancedCollection
    {
        public QueryStringParameterCollection() : base("?", string.Empty, "&", "=")
        {
        }
    }
}