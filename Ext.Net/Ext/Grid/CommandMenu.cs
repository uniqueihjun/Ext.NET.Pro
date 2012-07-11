/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class CommandMenu : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CommandMenu() { }

        private MenuCommandCollection items;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("items", JsonMode.AlwaysArray)]
        [Category("2. CommandMenu")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [ViewStateMember]
        [Description("")]
        public virtual MenuCommandCollection Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new MenuCommandCollection();
                }

                return this.items;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. CommandMenu")]
        [NotifyParentProperty(true)]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool Shared
        {
            get
            {
                object obj = this.ViewState["Shared"];
                return obj != null ? (bool) obj : false;
            }
            set
            {
                this.ViewState["Shared"] = value;
            }
        }

        /// <summary>
        /// Whenever a menu gets so long that the items won't fit the viewable area, it provides the user with an easy UI to scroll the menu.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. CommandMenu")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Whenever a menu gets so long that the items won't fit the viewable area, it provides the user with an easy UI to scroll the menu.")]
        public virtual bool EnableScrolling
        {
            get
            {
                object obj = this.ViewState["EnableScrolling"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["EnableScrolling"] = value;
            }
        }

        /// <summary>
        /// The minimum width of the menu in pixels (defaults to 120).
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("2. CommandMenu")]
        [DefaultValue(120)]
        [NotifyParentProperty(true)]
        [Description("The minimum width of the menu in pixels (defaults to 120).")]
        public virtual int MinWidth
        {
            get
            {
                object obj = this.ViewState["MinWidth"];
                return (obj == null) ? 120 : (int)obj;
            }
            set
            {
                this.ViewState["MinWidth"] = value;
            }
        }

        /// <summary>
        /// The maximum height of the menu. Only applies when enableScrolling is set to True (defaults to null).
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("2. CommandMenu")]
        [DefaultValue(0)]
        [NotifyParentProperty(true)]
        [Description("The maximum height of the menu. Only applies when enableScrolling is set to True (defaults to null).")]
        public virtual int MaxHeight
        {
            get
            {
                object obj = this.ViewState["MaxHeight"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["MaxHeight"] = value;
            }
        }

        /// <summary>
        /// The amount to scroll the menu. Only applies when enableScrolling is set to True (defaults to 24).
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("2. CommandMenu")]
        [DefaultValue(24)]
        [NotifyParentProperty(true)]
        [Description("The amount to scroll the menu. Only applies when enableScrolling is set to True (defaults to 24).")]
        public virtual int ScrollIncrement
        {
            get
            {
                object obj = this.ViewState["ScrollIncrement"];
                return (obj == null) ? 24 : (int)obj;
            }
            set
            {
                this.ViewState["ScrollIncrement"] = value;
            }
        }

        /// <summary>
        /// True to show the icon separator. (defaults to true).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. CommandMenu")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to show the icon separator. (defaults to true).")]
        public virtual bool ShowSeparator
        {
            get
            {
                object obj = this.ViewState["ShowSeparator"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["ShowSeparator"] = value;
            }
        }

        /// <summary>
        /// True or \"sides\" for the default effect, \"frame\" for 4-way shadow, and \"drop\" for bottom-right shadow (defaults to \"sides\")
        /// </summary>
        [Meta]
        [ConfigOption(typeof(ShadowJsonConverter))]
        [Category("2. CommandMenu")]
        [DefaultValue(ShadowMode.Sides)]
        [NotifyParentProperty(true)]
        [Description("True or \"sides\" for the default effect, \"frame\" for 4-way shadow, and \"drop\" for bottom-right shadow (defaults to \"sides\")")]
        public virtual ShadowMode Shadow
        {
            get
            {
                object obj = this.ViewState["Shadow"];
                return (obj == null) ? ShadowMode.Sides : (ShadowMode)obj;
            }
            set
            {
                this.ViewState["Shadow"] = value;
            }
        }

        /// <summary>
        /// The Ext.Element.alignTo anchor position value to use for submenus of this menu (defaults to \"tl-tr?\")
        /// </summary>
        [Meta]
        [Category("2. CommandMenu")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The Ext.Element.alignTo anchor position value to use for submenus of this menu (defaults to \"tl-tr?\")")]
        public virtual string SubMenuAlign
        {
            get
            {
                return (string)this.ViewState["SubMenuAlign"] ?? "";
            }
            set
            {
                this.ViewState["SubMenuAlign"] = value;
            }
        }

        /// <summary>
        /// True to ignore clicks on any item in this menu that is a parent item (displays a submenu) so that the submenu is not dismissed when clicking the parent item (defaults to false).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. CommandMenu")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True to ignore clicks on any item in this menu that is a parent item (displays a submenu) so that the submenu is not dismissed when clicking the parent item (defaults to false).")]
        public virtual bool IgnoreParentClicks
        {
            get
            {
                object obj = this.ViewState["IgnoreParentClicks"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["IgnoreParentClicks"] = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class MenuCommandCollection : StateManagedCollection<MenuCommand> { }
}