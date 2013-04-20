using NUnit.Framework;
using Subgurim.Maps.Core.Google.Apis.GeoCoding;

namespace Subgurim.Maps.Core.Tests.Apis.GeoCoding
{
    [TestFixture]
    public class GeoCoderTests
    {
        [Test]
        public void GeoCode_Country_Gets_Info()
        {
            var geoCoder = new GeoCoder();

            var result = geoCoder.Request("Spain");

            Assert.That(result, Is.Not.Null);
        }
    }
}
