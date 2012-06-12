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
    [ToolboxBitmap(typeof(BottomTitle), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:BottomTitle runat=\"server\" />")]
    [Description("")]
    public partial class BottomTitle : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public BottomTitle() { }

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

                string theme = "";

                if (this.ResourceManager.Theme != Theme.Default)
                {
                    theme = "-" + this.ResourceManager.Theme.ToString().ToLowerInvariant();
                }

                baseList.Add(new ClientStyleItem(typeof(BottomTitle), "Ext.Net.Build.Ext.Net.ux.plugins.bottomtitle.css.bottomtitle"+theme+"-embedded.css", "/ux/plugins/bottomtitle/css/bottomtitle"+theme+".css"));
                baseList.Add(new ClientScriptItem(typeof(BottomTitle), "Ext.Net.Build.Ext.Net.ux.plugins.bottomtitle.bottomtitle.js", "/ux/plugins/bottomtitle/bottomtitle.js"));

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
                return "Ext.net.BottomTitle";
            }
        }
    }
}