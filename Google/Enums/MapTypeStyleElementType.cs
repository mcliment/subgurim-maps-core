namespace Subgurim.Maps.Google.Enums
{
    internal enum MapTypeStyleElementType
    {
        /// <summary>
        /// Apply the rule to all elements of the specified feature.
        /// </summary>
        All,
        /// <summary>
        /// Apply the rule to the feature's geometry.
        /// </summary>
        Geometry,
        /// <summary>
        /// Apply the rule to the fill of the feature's geometry.
        /// </summary>
        Geometry__Fill,
        /// <summary>
        /// Apply the rule to the stroke of the feature's geometry.
        /// </summary>
        Geometry__Stroke,
        /// <summary>
        /// Apply the rule to the feature's labels.
        /// </summary>
        Labels,
        /// <summary>
        /// Apply the rule to icons within the feature's labels.
        /// </summary>
        Labels__Icon,
        /// <summary>
        /// Apply the rule to the text in the feature's label.
        /// </summary>
        Labels__Text,
        /// <summary>
        /// Apply the rule to the fill of the text in the feature's labels.
        /// </summary>
        Labels__Text__Fill,
        /// <summary>
        /// Apply the rule to the stroke of the text in the feature's labels.
        /// </summary>
        Labels__Text__Stroke
    }
}