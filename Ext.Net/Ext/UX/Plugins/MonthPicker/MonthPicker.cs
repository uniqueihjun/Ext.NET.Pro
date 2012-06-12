/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(MonthPicker), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:MonthPicker runat=\"server\" />")]
    [Description("")]
    public partial class MonthPicker : Plugin
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public MonthPicker()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                baseList.Add(new ClientScriptItem(typeof(MonthPicker), "Ext.Net.Build.Ext.Net.ux.plugins.monthpicker.monthpicker.js", "/ux/plugins/monthpicker/monthpicker.js"));

                return baseList;
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.ux.MonthPicker";
            }
        }
    }
}