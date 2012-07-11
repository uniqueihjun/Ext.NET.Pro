/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
	[Description("")]
    public partial class MenuDirectEvents : ContainerDirectEvents
    {
        public MenuDirectEvents() { }

        public MenuDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent click;

        /// <summary>
        /// Fires when this menu is clicked
        /// Parameters
        /// item : Ext.menu.Menu
        ///     The menu which has been clicked
        /// menuItem : Ext.Component
        ///     The menu item that was clicked. undefined if not applicable.
        /// e : Ext.EventObject
        ///     The underlying Ext.EventObject.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Menu), "this")]
        [ListenerArgument(1, "menuItem", typeof(object))]
        [ListenerArgument(2, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this menu is clicked")]
        public virtual ComponentDirectEvent Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseEnter;

        /// <summary>
        /// Fires when the mouse enters this menu
        /// Parameters
        /// item : Ext.menu.Menu
        ///     The menu
        /// e : Ext.EventObject
        ///     The underlying Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Menu), "this")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseenter", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse enters this menu")]
        public virtual ComponentDirectEvent MouseEnter
        {
            get
            {
                return this.mouseEnter ?? (this.mouseEnter = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseLeave;

        /// <summary>
        /// Fires when the mouse leaves this menu
        /// Parameters
        /// item : Ext.menu.Menu
        ///     The menu
        /// e : Ext.EventObject
        ///     The underlying Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Menu), "this")]
        [ListenerArgument(1, "e", typeof(Menu), "Ext.EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseleave", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse leaves this menu")]
        public virtual ComponentDirectEvent MouseLeave
        {
            get
            {
                return this.mouseLeave ?? (this.mouseLeave = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseOver;

        /// <summary>
        /// Fires when the mouse is hovering over this menu
        /// Parameters
        /// item : Ext.menu.Menu
        ///     The menu
        /// menuItem : Ext.Component
        ///     The menu item that the mouse is over. undefined if not applicable.
        /// e : Ext.EventObject
        ///     The underlying Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Menu), "this")]
        [ListenerArgument(1, "menuItem", typeof(object))]
        [ListenerArgument(2, "e", typeof(Menu), "Ext.EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseover", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse is hovering over this menu")]
        public virtual ComponentDirectEvent MouseOver
        {
            get
            {
                return this.mouseOver ?? (this.mouseOver = new ComponentDirectEvent(this));
            }
        }
    }
}