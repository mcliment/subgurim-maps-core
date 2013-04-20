using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;
using Subgurim.Maps.Core.Google;
using Subgurim.Maps.Core.Google.Enums;
using Subgurim.Maps.Core.Google.MapTypes;

namespace Subgurim.Maps.Core.Tests.Google
{
    [TestFixture]
    public class StyledMapTypeTests
    {
        [Test]
        public void Unstyled_Styled_Map_Renders_Ok()
        {
            var styledMap = new StyledMapType();

            var js = styledMap.ToString();
        }

        [Test]
        public void Styled_Map_With_Options_Renders_Ok()
        {
            var options = new StyledMapOptions()
                              {
                                  Name = "Styled_Map",
                                  Alt = "My custom styled map",
                                  MinZoom = 3,
                                  MaxZoom = 10
                              };

            var styledMap = new StyledMapType(options);

            var js = styledMap.ToString();
        }

        [Test]
        public void Styled_Map_With_Styles_Renders_Ok()
        {
            var styles = new List<MapTypeStyle>()
                             {
                                 new MapTypeStyle()
                                     {
                                         ElementType = MapTypeStyleElementType.Geometry__Stroke,
                                         FeatureType = MapTypeStyleFeatureType.Landscape__Man_Made,
                                         Styler = new MapTypeStyler()
                                                      {
                                                          Color = Color.FromArgb(23, 43, 23)
                                                      }
                                     }
                             };


            var styledMap = new StyledMapType(styles);

            var js = styledMap.ToString();
        }

        [Test]
        public void MapTypeStyler_Renders_Ok()
        {
            var styler = new MapTypeStyler()
                             {
                                 Color = Color.FromArgb(23, 43, 23),
                                 Gamma = 0.4,
                                 Hue = Color.Firebrick,
                                 InvertLightness = true,
                                 Lightness = 50,
                                 Saturation = -32,
                                 Visibility = MapTypeStylerVisibility.Simplified,
                                 Weight = 3
                             };

            var js = styler.ToString();
        }
    }
}
