/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class MenuListeners : ContainerListeners
    {
        private ComponentListener click;

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
        [ConfigOption("click", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this menu is clicked")]
        public virtual ComponentListener Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentListener());
            }
        }

        private ComponentListener mouseEnter;

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
        [ConfigOption("mouseenter", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse enters this menu")]
        public virtual ComponentListener MouseEnter
        {
            get
            {
                return this.mouseEnter ?? (this.mouseEnter = new ComponentListener());
            }
        }

        private ComponentListener mouseLeave;

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
        [ConfigOption("mouseleave", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse leaves this menu")]
        public virtual ComponentListener MouseLeave
        {
            get
            {                
                return this.mouseLeave ?? (this.mouseLeave = new ComponentListener());
            }
        }

        private ComponentListener mouseOver;

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
        [ConfigOption("mouseover", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse is hovering over this menu")]
        public virtual ComponentListener MouseOver
        {
            get
            {
                return this.mouseOver ?? (this.mouseOver = new ComponentListener());
            }
        }
    }
}