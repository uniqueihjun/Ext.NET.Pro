/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class HBoxLayoutConfig : BoxLayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public HBoxLayoutConfig(HBoxAlign align, string defaultMargins, string padding, BoxPack pack, int scrollOffset, bool renderHidden, string extraCls)
            : base(defaultMargins, padding, pack, scrollOffset, renderHidden, extraCls)
        {
            this.Align = align;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public HBoxLayoutConfig() { }

        /// <summary>
        /// Controls how the child items of the container are aligned. 
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [DefaultValue(HBoxAlign.Top)]
        public HBoxAlign Align
        {
            get
            {
                object obj = this.ViewState["Align"];
                return obj == null ? HBoxAlign.Top : (HBoxAlign)obj;
            }
            set
            {
                this.ViewState["Align"] = value;
            }
        }
    }
}