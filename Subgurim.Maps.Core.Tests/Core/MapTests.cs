using NUnit.Framework;
using Subgurim.Maps.Core.Google;

namespace Subgurim.Maps.Core.Tests.Core
{
    [TestFixture]
    public class MapTests
    {
        [Test]
        public void Map_Renders_MapDiv_With_Default_Options()
        {
            var map = new Map();

            var html = map.ToString();

            Assert.That(html, Is.Not.Null);
        }

        [Test]
        public void Map_RenderScripts_Renders_Default()
        {
            var map = new Map();

            var script = map.RenderScripts();

            Assert.That(script, Is.Not.Null);
        }
    }
}
