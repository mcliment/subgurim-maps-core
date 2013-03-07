namespace Subgurim.Maps.Google.Enums
{
    /// <summary>
    /// Identifiers used to specify the placement of controls on the map. Controls are positioned relative to other controls in the same layout position. Controls that are added first are positioned closer to the edge of the map. 
    /// </summary>
    internal enum ControlPosition
    {
        /// <summary>
        /// Elements are positioned in the center of the bottom row.
        /// </summary>
        Bottom_Center,

        /// <summary>
        /// Elements are positioned in the bottom left and flow towards the middle. Elements are positioned to the right of the Google logo.
        /// </summary>
        Bottom_Left,

        /// <summary>
        /// Elements are positioned in the bottom right and flow towards the middle. Elements are positioned to the left of the copyrights.
        /// </summary>
        Bottom_Right,

        /// <summary>
        /// Elements are positioned on the left, above bottom-left elements, and flow upwards.
        /// </summary>
        Left_Bottom,

        /// <summary>
        /// Elements are positioned in the center of the left side.
        /// </summary>
        Left_Center,

        /// <summary>
        /// Elements are positioned on the left, below top-left elements, and flow downwards.
        /// </summary>
        Left_Top,

        /// <summary>
        /// Elements are positioned on the right, above bottom-right elements, and flow upwards.
        /// </summary>
        Right_Bottom,

        /// <summary>
        /// Elements are positioned in the center of the right side.
        /// </summary>
        Right_Center,

        /// <summary>
        /// Elements are positioned on the right, below top-right elements, and flow downwards.
        /// </summary>
        Right_Top,

        /// <summary>
        /// Elements are positioned in the center of the top row.
        /// </summary>
        Top_Center,

        /// <summary>
        /// Elements are positioned in the top left and flow towards the middle.
        /// </summary>
        Top_Left,

        /// <summary>
        /// Elements are positioned in the top right and flow towards the middle.
        /// </summary>
        Top_Right,
    }
}
