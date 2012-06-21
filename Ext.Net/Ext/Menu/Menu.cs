/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A menu object. This is the container to which you may add menu items.
    /// Menus may contain either menu items, or general Components. Menus may also contain docked items because it extends Ext.panel.Panel.
    /// To make a contained general Component line up with other menu items, specify plain: true. This reserves a space for an icon, and indents the Component in line with the other menu items.
    /// By default, Menus are absolutely positioned, floating Components. By configuring a Menu with floating: false, a Menu may be used as a child of a Container.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:Menu runat=\"server\"><Items><{0}:MenuItem runat=\"server\" Text=\"Item1\" /><{0}:MenuItem runat=\"server\" Text=\"Item2\" /><{0}:MenuItem runat=\"server\" Text=\"Item3\" /></Items></ext:Menu>")]
    [ToolboxBitmap(typeof(Menu), "Build.ToolboxIcons.Menu.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("A menu object. This is the container to which you may add menu items.")]
    public partial class Menu : MenuBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Menu() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "menu";
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
                return "Ext.menu.Menu";
            }
        }
        
        private MenuListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]        
        [Description("Client-side JavaScript Event Handlers")]
        public MenuListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new MenuListeners();
                }

                return this.listeners;
            }
        }

        private MenuDirectEvents directEvents;

        /// <summary>
        /// Server-side DirectEvent Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]        
        [Description("Server-side DirectEventHandlers")]
        public MenuDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new MenuDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}