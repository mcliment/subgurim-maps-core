using System;

namespace Subgurim.Maps.Core.Google.Utilities
{
    [Serializable]
    [JavascriptResource("infobox_packed")]
    internal class InfoBox : InfoWindow
    {
        #region Properties

        protected override string ClassName
        {
            get
            {
                return "InfoBox";
            }
        }

        #endregion

        #region Constructor

        public InfoBox() : this(new Options.InfoBoxOptions())
        {
        }

        public InfoBox(Options.InfoBoxOptions options) : base(options)
        {
            this.Options = options;
        }

        public InfoBox(Options.InfoBoxOptions options, string id)
            : this(options)
        {
            this.Id = id;
        }

        #endregion
    }
}
