using Subgurim.Maps.Collections;

namespace Subgurim.Maps.Google.Options
{
    internal class OverviewMapControlOptions
    {
        public bool Opened { get; set; }

        public override string ToString()
        {
            var options = new JsonCollection(false);

            options.Add("opened", Opened, Opened, typeof(bool));
            
            return options.ToString();
        }
    }
}
