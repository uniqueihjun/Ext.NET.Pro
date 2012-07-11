/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A menu object. This is the container to which you add all other menu items. Menu can also serve as a base class when you want a specialized menu based off of another component.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:Menu runat=\"server\"><Items><{0}:MenuItem runat=\"server\" Text=\"Item1\" /><{0}:MenuItem runat=\"server\" Text=\"Item2\" /><{0}:MenuItem runat=\"server\" Text=\"Item3\" /></Items></ext:Menu>")]
    [ToolboxBitmap(typeof(Menu), "Build.ToolboxIcons.Menu.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("A menu object. This is the container to which you add all other menu items. Menu can also serve as a base class when you want a specialized menu based off of another component.")]
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
        [ViewStateMember]
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
        [ViewStateMember]
        [Description("Server-side DirectEventHandlers")]
        public MenuDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new MenuDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}