/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
    /// Base Class for HBoxLayout and VBoxLayout Classes.
	/// </summary>
	[Description("")]
    public abstract partial class BoxLayoutConfig : LayoutConfig
    {
        /// <summary>
        /// If the individual contained items do not have a margins property specified, the default margins from this property will be applied to each item.
        /// The order of the sides associated with each value matches the way CSS processes margin values:
        ///    If there is only one value, it applies to all sides.
        ///    If there are two values, the top and bottom borders are set to the first value and the right and left are set to the second.
        ///    If there are three values, the top is set to the first value, the left and right are set to the second, and the bottom is set to the third.
        ///    If there are four values, they apply to the top, right, bottom, and left, respectively.
        /// </summary>
        [DefaultValue("")]
        public string DefaultMargins
        {
            get
            {
                return this.State.Get<string>("DefaultMargins", "");
            }
            set
            {
                this.State.Set("DefaultMargins", value);
            }
        }

        [ConfigOption("defaultMargins", JsonMode.Raw)]
        [DefaultValue("")]
        protected string DefaultMarginsProxy
        {
            get
            {
                if (this.DefaultMargins.IsEmpty())
                {
                    return "";
                }

                return "Ext.util.Format.parseBox(" + JSON.Serialize(this.DefaultMargins) + ")";
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
        /// Defaults to: "0"
        /// </summary>
        [ConfigOption("padding")]
        [DefaultValue("0")]
        public string Padding
        {
            get
            {
                return this.State.Get<string>("Padding", "0");
            }
            set
            {
                this.State.Set("Padding", value);
            }
        }

        /// <summary>
        /// Controls how the child items of the container are packed together. Acceptable configuration values for this property are:
        /// start - child items are packed together at left side of container (*default**)
        /// center - child items are packed together at mid-width of container
        /// end - child items are packed together at right side of container
        /// Defaults to: "start"
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [DefaultValue(BoxPack.Start)]
        public BoxPack Pack
        {
            get
            {
                return this.State.Get<BoxPack>("Pack", BoxPack.Start);
            }
            set
            {
                this.State.Set("Pack", value);
            }
        }

        /// <summary>
        /// Allows stretchMax calculation to take into account the max perpendicular size (height for HBox layout and width for VBox layout) of another Box layout when calculating its maximum perpendicular child size.
        /// If specified as a string, this may be either a known Container ID, or a ComponentQuery selector which is rooted at this layout's Container (ie, to find a sibling, use "^>#siblingItemId).
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        public string StretchMaxPartner
        {
            get
            {
                return this.State.Get<string>("StretchMaxPartner", "");
            }
            set
            {
                this.State.Set("StretchMaxPartner", value);
            }
        }
    }
}