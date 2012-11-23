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
	[Description("")]
    public partial class ClickRepeaterDirectEvents : ComponentDirectEvents
    {
        public ClickRepeaterDirectEvents() { }

        public ClickRepeaterDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent click;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires on a specified interval during the time the element is pressed.")]
        public virtual ComponentDirectEvent Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent leftClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("leftclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires on a specified interval during the time the element is pressed.")]
        public virtual ComponentDirectEvent LeftClick
        {
            get
            {
                return this.leftClick ?? (this.leftClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent middleClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("middleclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires on a specified interval during the time the element is pressed.")]
        public virtual ComponentDirectEvent MiddleClick
        {
            get
            {
                return this.middleClick ?? (this.middleClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent rightClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("rightclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires on a specified interval during the time the element is pressed.")]
        public virtual ComponentDirectEvent RightClick
        {
            get
            {
                return this.rightClick ?? (this.rightClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseDown;

        /// <summary>
        /// Fires when the mouse button is depressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mousedown", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse button is depressed.")]
        public virtual ComponentDirectEvent MouseDown
        {
            get
            {
                return this.mouseDown ?? (this.mouseDown = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseUp;

        /// <summary>
        /// Fires when the mouse key is released.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseup", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse key is released.")]
        public virtual ComponentDirectEvent MouseUp
        {
            get
            {
                return this.mouseUp ?? (this.mouseUp = new ComponentDirectEvent(this));
            }
        }
    }
}