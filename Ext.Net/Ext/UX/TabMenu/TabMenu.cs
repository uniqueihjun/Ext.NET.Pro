/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    [ToolboxBitmap(typeof(TabMenu), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:TabMenu runat=\"server\" />")]
    [Description("")]
    public partial class TabMenu : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public TabMenu() { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 2;

                baseList.Add(new ClientScriptItem(typeof(TabMenu), "Ext.Net.Build.Ext.Net.ux.tabmenu.tabmenu.js", "/ux/plugins/tabmenu/tabmenu.js"));
                baseList.Add(new ClientStyleItem(typeof(TabMenu), "Ext.Net.Build.Ext.Net.ux.resources.tabmenu-embedded.css", "/ux/resources/tabmenu.css"));

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
                return "Ext.net.TabMenu";
            }
        }
    }
}