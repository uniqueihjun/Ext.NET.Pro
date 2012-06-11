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
	/// A layout that arranges items horizontally across a Container. This layout optionally divides available horizontal space between child items containing a numeric flex configuration.
    /// This layout may also be used to set the heights of child items by configuring it with the align option.
	/// </summary>
	[Description("")]
    public partial class HBoxLayoutConfig : BoxLayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public HBoxLayoutConfig() { }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("type")]
        [DefaultValue("")]
        protected override string LayoutType
        {
            get
            {
                return "hbox";
            }
        }

        /// <summary>
        /// Controls how the child items of the container are aligned. Acceptable configuration values for this property are:
        ///     top : Default child items are aligned vertically at the top of the container
        ///     middle : child items are aligned vertically in the middle of the container
        ///     stretch : child items are stretched vertically to fill the height of the container
        ///     stretchmax : child items are stretched vertically to the height of the largest item.
        /// Defaults to: "top"
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [DefaultValue(HBoxAlign.Top)]
        public HBoxAlign Align
        {
            get
            {
                return this.State.Get<HBoxAlign>("Align", HBoxAlign.Top);
            }
            set
            {
                this.State.Set("Align", value);
            }
        }
    }
}