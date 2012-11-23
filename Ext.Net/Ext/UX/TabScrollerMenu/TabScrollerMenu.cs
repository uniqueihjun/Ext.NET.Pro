/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    [ToolboxBitmap(typeof(TabScrollerMenu), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:TabScrollerMenu runat=\"server\" />")]
    [Description("")]
    public partial class TabScrollerMenu : Plugin
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TabScrollerMenu() { }

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

                baseList.Add(new ClientScriptItem(typeof(TabScrollerMenu), "Ext.Net.Build.Ext.Net.ux.tabscrollermenu.tabscrollermenu.js", "/ux/tabscrollermenu/tabscrollermenu.js"));
                baseList.Add(new ClientStyleItem(typeof(TabScrollerMenu), "Ext.Net.Build.Ext.Net.ux.resources.tabscrollermenu-embedded.css", "/ux/resources/tabscrollermenu.css"));

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
                return "Ext.ux.TabScrollerMenu";
            }
        }

        /// <summary>
        /// The page size.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. TabScrollerMenu")]
        [DefaultValue(10)]
        [NotifyParentProperty(true)]
        [Description("The page size.")]
        public virtual int PageSize
        {
            get
            {
                return this.State.Get<int>("PageSize", 10);
            }
            set
            {
                this.State.Set("PageSize", value);
            }
        }

        /// <summary>
        /// The maximum text length to truncate.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. TabScrollerMenu")]
        [DefaultValue(15)]
        [NotifyParentProperty(true)]
        [Description("The maximum text length to truncate.")]
        public virtual int MaxText
        {
            get
            {
                return this.State.Get<int>("MaxText", 15);
            }
            set
            {
                this.State.Set("MaxText", value);
            }
        }

        /// <summary>
        /// Menu prefix text.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. TabScrollerMenu")]
        [Localizable(true)]
        [DefaultValue("Items")]
        [NotifyParentProperty(true)]
        [Description("Menu prefix text.")]
        public virtual string MenuPrefixText
        {
            get
            {
                return this.State.Get<string>("MenuPrefixText", "Items");
            }
            set
            {
                this.State.Set("MenuPrefixText", value);
            }
        }
    }
}