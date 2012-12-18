/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// This is a multi-pane, application-oriented UI layout style that supports multiple nested panels, automatic bars between regions and built-in expanding and collapsing of regions.
    /// This class is intended to be extended or created via the layout:'border' Ext.container.Container.layout config, and should generally not need to be created directly via the new keyword.
    /// 
    /// Notes
    /// When using the split option, the layout will automatically insert a Ext.resizer.Splitter into the appropriate place. This will modify the underlying items collection in the container.
    /// Any Container using the Border layout must have a child item with region:'center'. The child item in the center region will always be resized to fill the remaining space not used by the other regions in the layout.
    /// Any child items with a region of west or east may be configured with either an initial width, or a Ext.layout.container.Box.flex value, or an initial percentage width string (Which is simply divided by 100 and used as a flex value). The 'center' region has a flex value of 1.
    /// Any child items with a region of north or south may be configured with either an initial height, or a Ext.layout.container.Box.flex value, or an initial percentage height string (Which is simply divided by 100 and used as a flex value). The 'center' region has a flex value of 1.
    /// There is no BorderLayout.Region class in ExtJS 4.0+
    /// </summary>
    public partial class BorderLayoutConfig : LayoutConfig
    {
        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BorderLayoutConfig() { }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("type")]
        [DefaultValue("")]
        protected override string LayoutType
        {
            get
            {
                return "border";
            }
        }

        /// <summary>
        /// Sets the padding to be applied to all child items managed by this layout.
        /// 
        /// This property must be specified as a string containing space-separated, numeric padding values. The order of the sides associated with each value matches the way CSS processes padding values:
        /// 
        /// If there is only one value, it applies to all sides.
        /// If there are two values, the top and bottom borders are set to the first value and the right and left are set to the second.
        /// If there are three values, the top is set to the first value, the left and right are set to the second, and the bottom is set to the third.
        /// If there are four values, they apply to the top, right, bottom, and left, respectively.
        /// </summary>
        [ConfigOption("padding")]
        [DefaultValue("")]
        public string Padding
        {
            get
            {
                return this.State.Get<string>("Padding", "");
            }
            set
            {
                this.State.Set("Padding", value);
            }
        }
    }
}
