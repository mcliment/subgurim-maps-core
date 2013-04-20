using System;
using System.Text;
using Subgurim.Maps.Core.Google.Utilities.Options;

namespace Subgurim.Maps.Core.Google.Utilities
{
    internal enum StyledIconType
    {
        /// <summary>
        /// Resembles a default Marker. Can alter color, have an optional character or two placed
        /// within it, or a have a star on its corner.
        /// </summary>
        Marker,

        /// <summary>
        /// Resembles a small InfoWindow with a single line of text. Can alter color or have a string
        /// of text placed in it.
        /// </summary>
        Bubble,
        // Class - TODO :: Support Class for default options, but as the code is generated may not be necessary
    }

    internal class StyledIcon
    {
        private readonly StyledIconType _iconType;
        private readonly StyledIconOptions _options;

        public StyledIcon(StyledIconType iconType, StyledIconOptions options)
        {
            _iconType = iconType;
            _options = options;
        }

        public StyledIconType IconType { get { return _iconType; } }

        public StyledIconOptions Options { get { return _options; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("new StyledIcon(");

            switch (IconType)
            {
                case StyledIconType.Marker:
                    sb.Append("StyledIconTypes.MARKER");
                    break;
                case StyledIconType.Bubble:
                    sb.Append("StyledIconTypes.BUBBLE");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            sb.AppendFormat(",{0})", Options);

            return sb.ToString();
        }
    }
}