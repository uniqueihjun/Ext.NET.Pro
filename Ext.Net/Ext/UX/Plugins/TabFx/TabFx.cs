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
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(TabFx), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:TabFx runat=\"server\" />")]
    [Description("")]
    public partial class TabFx : Plugin
    {
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

                baseList.Add(new ClientScriptItem(typeof(TabFx), "Ext.Net.Build.Ext.Net.ux.plugins.tabfx.tabfx.js", "/ux/plugins/tabfx/tabfx.js"));

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
                return "Ext.ux.plugins.TabFx";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [Category("3. TabFx")]
        [DefaultValue("Frame")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string Name
        {
            get
            {
                return (string)this.ViewState["Name"] ?? "Frame";
            }
            set
            {
                this.ViewState["Name"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("3. TabFx")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string Args
        {
            get
            {
                return (string)this.ViewState["Args"] ?? "";
            }
            set
            {
                this.ViewState["Args"] = value;
            }
        }
    }
}