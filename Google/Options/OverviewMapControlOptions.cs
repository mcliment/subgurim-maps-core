using Subgurim.Maps.Core.Collections;

namespace Subgurim.Maps.Core.Google.Options
{
    public class OverviewMapControlOptions
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
