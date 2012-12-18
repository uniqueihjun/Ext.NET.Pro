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
	/// 
	/// </summary>
	[Description("")]
    public partial class ButtonDirectEvents : AbstractComponentDirectEvents
    {
        public ButtonDirectEvents() { }

        public ButtonDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent click;

        /// <summary>
        /// Fires when this button is clicked, before the configured handler is invoked. Execution of the handler may be vetoed by returning false to this event.
        /// Parameters
        /// item : Ext.button.Button
        /// e : Event
        /// The click event
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this button is clicked, before the configured handler is invoked. Execution of the handler may be vetoed by returning false to this event.")]
        public virtual ComponentDirectEvent Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent menuHide;

        /// <summary>
        /// If this button has a menu, this event fires when it is hidden.
        /// Parameters
        /// item : Ext.button.Button
        /// menu : Ext.menu.Menu
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "menu", typeof(object), "Menu")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("menuhide", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("If this button has a menu, this event fires when it is hidden.")]
        public virtual ComponentDirectEvent MenuHide
        {
            get
            {
                return this.menuHide ?? (this.menuHide = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent menuShow;

        /// <summary>
        /// If this button has a menu, this event fires when it is shown.
        /// Parameters
        /// item : Ext.button.Button
        /// menu : Ext.menu.Menu
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "menu", typeof(object), "Menu")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("menushow", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("If this button has a menu, this event fires when it is shown.")]
        public virtual ComponentDirectEvent MenuShow
        {
            get
            {
                return this.menuShow ?? (this.menuShow = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent menuTriggerOut;

        /// <summary>
        /// If this button has a menu, this event fires when the mouse leaves the menu triggering element.
        /// Parameters
        /// item : Ext.button.Button
        /// menu : Ext.menu.Menu
        /// e : Event
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "menu", typeof(object), "Menu")]
        [ListenerArgument(1, "e", typeof(object), "EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("menutriggerout", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("If this button has a menu, this event fires when the mouse leaves the menu triggering element.")]
        public virtual ComponentDirectEvent MenuTriggerOut
        {
            get
            {
                return this.menuTriggerOut ?? (this.menuTriggerOut = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent menuTriggerOver;

        /// <summary>
        /// If this button has a menu, this event fires when the mouse enters the menu triggering element.
        /// Parameters
        /// item : Ext.button.Button
        /// menu : Ext.menu.Menu
        /// e : Event
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "menu", typeof(object), "Menu")]
        [ListenerArgument(1, "e", typeof(object), "EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("menutriggerover", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("If this button has a menu, this event fires when the mouse enters the menu triggering element.")]
        public virtual ComponentDirectEvent MenuTriggerOver
        {
            get
            {
                return this.menuTriggerOver ?? (this.menuTriggerOver = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseOut;

        /// <summary>
        /// Fires when the mouse exits the button.
        /// Parameters
        /// item : Ext.button.Button
        /// e : Event
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseout", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse exits the button.")]
        public virtual ComponentDirectEvent MouseOut
        {
            get
            {
                return this.mouseOut ?? (this.mouseOut = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseOver;

        /// <summary>
        /// Fires when the mouse hovers over the button.
        /// Parameters
        /// item : Ext.button.Button
        /// e : Event
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseover", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse hovers over the button.")]
        public virtual ComponentDirectEvent MouseOver
        {
            get
            {
                return this.mouseOver ?? (this.mouseOver = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent toggle;

        /// <summary>
        /// Fires when the 'pressed' state of this button changes (only if enableToggle = true).
        /// Parameters
        /// item : Ext.button.Button
        /// pressed : Boolean
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "pressed", typeof(bool), "Pressed")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("toggle", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the 'pressed' state of this button changes (only if enableToggle = true).")]
        public virtual ComponentDirectEvent Toggle
        {
            get
            {
                return this.toggle ?? (this.toggle = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent textchange;

        /// <summary>
        /// Fired when the button's text is changed by the setText} method.
        /// Parameters
        /// item : Ext.button.Button
        /// oldText : String
        /// newText : String
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "oldText")]
        [ListenerArgument(2, "newText")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("textchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired when the button's text is changed by the setText} method.")]
        public virtual ComponentDirectEvent TextChange
        {
            get
            {
                return this.textchange ?? (this.textchange = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent iconchange;

        /// <summary>
        /// Fired when the button's icon is changed by the setIcon or setIconCls methods.
        /// Parameters
        /// item : Ext.button.Button
        /// oldIcon : String
        /// newIcon : String
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "oldIcon")]
        [ListenerArgument(2, "newIcon")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("iconchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired when the button's icon is changed by the setIcon or setIconCls methods.")]
        public virtual ComponentDirectEvent IconChange
        {
            get
            {
                return this.iconchange ?? (this.iconchange = new ComponentDirectEvent(this));
            }
        }
    }
}