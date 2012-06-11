/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// This is the layout style of choice for creating structural layouts in a multi-column format where the width of each column can be specified as a percentage or fixed width, but the height is allowed to vary based on the content. This class is intended to be extended or created via the layout:'column' Ext.container.Container.layout config, and should generally not need to be created directly via the new keyword.
    /// 
    /// ColumnLayout does not have any direct config options (other than inherited ones), but it does support a specific config property of columnWidth that can be included in the config of any panel added to it. The layout will use the columnWidth (if present) or width of each panel during layout to determine how to size each panel. If width or columnWidth is not specified for a given panel, its width will default to the panel's width (or auto).
    /// 
    /// The width property is always evaluated as pixels, and must be a number greater than or equal to 1. The columnWidth property is always evaluated as a percentage, and must be a decimal value greater than 0 and less than 1 (e.g., .25).
    /// 
    /// The basic rules for specifying column widths are pretty simple. The logic makes two passes through the set of contained panels. During the first layout pass, all panels that either have a fixed width or none specified (auto) are skipped, but their widths are subtracted from the overall container width.
    /// 
    /// During the second pass, all panels with columnWidths are assigned pixel widths in proportion to their percentages based on the total remaining container width. In other words, percentage width panels are designed to fill the space left over by all the fixed-width and/or auto-width panels. Because of this, while you can specify any number of columns with different percentages, the columnWidths must always add up to 1 (or 100%) when added together, otherwise your layout may not render as expected.
	/// </summary>
	[Description("")]
    public partial class ColumnLayoutConfig : LayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ColumnLayoutConfig() { }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("type")]
        [DefaultValue("")]
        protected override string LayoutType
        {
            get
            {
                return "column";
            }
        }
    }
}