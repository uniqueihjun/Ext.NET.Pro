/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A base class for all menu items that require menu-related functionality such as click handling, sub-menus, icons, etc.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A base class for all menu items that require menu-related functionality such as click handling, sub-menus, icons, etc.")]
    public partial class MenuItem : MenuItemBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public MenuItem() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        [Description("")]
        public MenuItem(string text)
        {
            this.Text = text;
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
                return "Ext.menu.Item";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "menuitem";
            }
        }

        private MenuItemListeners listeners;

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
        public MenuItemListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new MenuItemListeners();
                }

                return this.listeners;
            }
        }

        private MenuItemDirectEvents directEvents;

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
        public MenuItemDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new MenuItemDirectEvents(this);
                }

                return this.directEvents;
            }
        }

        /// <summary>
        /// Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).
        /// </summary>
        [Description("Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).")]
        public event ComponentDirectEvent.DirectEventHandler DirectClick
        {
            add
            {
                this.DirectEvents.Click.Event += value;
                this.CheckForceId();
            }
            remove
            {
                this.DirectEvents.Click.Event -= value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue("")]
        [Description("")]
        public virtual string DirectClickUrl
        {
            get
            {

                return this.DirectEvents.Click.Url;
            }
            set
            {
                this.DirectEvents.Click.Url = value;
            }
        }
    }
}