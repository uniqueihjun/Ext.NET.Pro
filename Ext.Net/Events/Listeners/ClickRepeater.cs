/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class ClickRepeaterListeners : ComponentListeners
    {
        private ComponentListener click;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires on a specified interval during the time the element is pressed.")]
        public virtual ComponentListener Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentListener());
            }
        }

        private ComponentListener leftClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("leftclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires on a specified interval during the time the element is pressed.")]
        public virtual ComponentListener LeftClick
        {
            get
            {
                return this.leftClick ?? (this.leftClick = new ComponentListener());
            }
        }

        private ComponentListener middleClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("middleclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires on a specified interval during the time the element is pressed.")]
        public virtual ComponentListener MiddleClick
        {
            get
            {
                return this.middleClick ?? (this.middleClick = new ComponentListener());
            }
        }

        private ComponentListener rightClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("rightclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires on a specified interval during the time the element is pressed.")]
        public virtual ComponentListener RightClick
        {
            get
            {
                return this.rightClick ?? (this.rightClick = new ComponentListener());
            }
        }

        private ComponentListener mouseDown;

        /// <summary>
        /// Fires when the mouse button is depressed.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mousedown", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse button is depressed.")]
        public virtual ComponentListener MouseDown
        {
            get
            {
                return this.mouseDown ?? (this.mouseDown = new ComponentListener());
            }
        }

        private ComponentListener mouseUp;

        /// <summary>
        /// Fires when the mouse key is released.
        /// Parameters
        /// item : Ext.util.ClickRepeater
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseup", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the mouse key is released.")]
        public virtual ComponentListener MouseUp
        {
            get
            {
                return this.mouseUp ?? (this.mouseUp = new ComponentListener());
            }
        }
    }
}