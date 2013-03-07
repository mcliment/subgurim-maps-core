using System.Text;
using Subgurim.Maps.Google.Abstract;
using Subgurim.Maps.Google.Options;

namespace Subgurim.Maps.Google
{
    internal class Map : BaseMapObject<MapOptions>
    {
        private readonly MapCss _css = new MapCss();
        private string _name;

        #region Properties

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = Id;
                }

                return _name;
            }

            private set { _name = value; }
        }

        public MapCss Css { get { return _css; } }

        #endregion

        #region Constructors

        public Map()
            : this(new MapOptions(typeof(Map)))
        {
        }

        public Map(MapOptions options)
        {
            this.SetOptions(options);
        }

        #endregion

        #region Rendering

        public string RenderScripts()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("var {0}_options={1};", Name, Options.ToString(false));
            sb.AppendFormat("var {0}=new google.maps.Map(document.getElementById(\"{1}\"), {0}_options);", Id, Name);

            return sb.ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("<div id=\"{0}\"{1}></div>", this.Name, this.Css);

            return sb.ToString();
        }

        #endregion

        #region Api Access

        private static Apis.GeoCoding.GeoCoder geoCoder;

        public static Apis.GeoCoding.GeoCoder GeoCoding
        { 
            get { return geoCoder ?? (geoCoder = new Apis.GeoCoding.GeoCoder()); }
        }

        #endregion

        public void SetId(string id)
        {
            this.Id = id;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}
