using System.IO;
using System.Net;
using Subgurim.Maps.Core.Collections;

namespace Subgurim.Maps.Core.Google.Apis.GeoCoding
{
    public class GeoCoder
    {
        private const string ApiUrl = "http://maps.google.com/maps/api/geocode";
        private const string ApiUrlSecure = "https://maps.googleapis.com/maps/api/geocode";

        private GeoCoderOutput _output = GeoCoderOutput.Xml;

        public GeoCoderOutput Output
        {
            get { return _output; }
            set { _output = value; }
        }

        public GeoCoderResponse Request(string address)
        {
            return new GeoCoderResponse(RequestCore(address));
        }

        private string RequestCore(string address)
        {
            _output = GeoCoderOutput.Xml;

            var queryString = new QueryStringParameterCollection();

            queryString.Add("address", address);
            queryString.Add("sensor", "false");

            var url = string.Format("{0}/{1}{2}", ApiUrl, _output.ToString().ToLowerInvariant(), queryString);

            var req = (HttpWebRequest) WebRequest.Create(url);
            var res = (HttpWebResponse) req.GetResponse();

            string responseString;

            if (res == null) throw new WebException("Can't get response from service.");

            var responseContent = res.GetResponseStream();

            if (responseContent == null) throw new WebException("Can't get response from service.");

            using (var reader = new StreamReader(responseContent))
            {
                responseString = reader.ReadToEnd();
            }

            return responseString;
        }
    }

    public enum GeoCoderOutput
    {
        Json,
        Xml
    }

    public class GeoCoderResponse
    {
        public GeoCoderResponse(string xmlResponse)
        {
            // TODO :: Completar
        }
    }
}