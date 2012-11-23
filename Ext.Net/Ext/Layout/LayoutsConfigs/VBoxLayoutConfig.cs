/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class VBoxLayoutConfig : BoxLayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public VBoxLayoutConfig(VBoxAlign align, string defaultMargins, string padding, BoxPack pack, int scrollOffset, bool renderHidden, string extraCls)
            : base(defaultMargins, padding, pack, scrollOffset, renderHidden, extraCls)
        {
            this.Align = align;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public VBoxLayoutConfig()
        {
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [DefaultValue(VBoxAlign.Left)]
		[Description("")]
        public VBoxAlign Align
        {
            get
            {
                object obj = this.ViewState["Align"];
                return obj == null ? VBoxAlign.Left : (VBoxAlign)obj;
            }
            set
            {
                this.ViewState["Align"] = value;
            }
        }
    }
}