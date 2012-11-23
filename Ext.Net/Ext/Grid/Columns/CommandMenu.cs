/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class CommandMenu : BaseItem
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
                return this.State.Get<bool>("InShareddex", false);
            }
            set
            {
                this.State.Set("Shared", value);
            }
        }

        /// <summary>
        /// Whenever a menu gets so long that the items won't fit the viewable area, it provides the user with an easy UI to scroll the menu.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. CommandMenu")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("Whenever a menu gets so long that the items won't fit the viewable area, it provides the user with an easy UI to scroll the menu.")]
        public virtual bool EnableScrolling
        {
            get
            {
                return this.State.Get<bool>("EnableScrolling", true);
            }
            set
            {
                this.State.Set("EnableScrolling", value);
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
                return this.State.Get<int>("MinWidth", 120);
            }
            set
            {
                this.State.Set("MinWidth", value);
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
                return this.State.Get<int>("MaxHeight", 0);
            }
            set
            {
                this.State.Set("MaxHeight", value);
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
                return this.State.Get<int>("ScrollIncrement", 24);
            }
            set
            {
                this.State.Set("ScrollIncrement", value);
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
                return this.State.Get<bool>("ShowSeparator", true);
            }
            set
            {
                this.State.Set("ShowSeparator", value);
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
                return this.State.Get<ShadowMode>("Shadow", ShadowMode.Sides);
            }
            set
            {
                this.State.Set("Shadow", value);
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
                return this.State.Get<string>("SubMenuAlign", "");
            }
            set
            {
                this.State.Set("SubMenuAlign", value);
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
                return this.State.Get<bool>("IgnoreParentClicks", false);
            }
            set
            {
                this.State.Set("IgnoreParentClicks", value);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class MenuCommandCollection : BaseItemCollection<MenuCommand> { }
}