/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
        private ComponentDirectEvent click;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
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
                if (this.click == null)
                {
                    this.click = new ComponentDirectEvent();
                }

                return this.click;
            }
        }

        private ComponentDirectEvent leftClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
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
                if (this.leftClick == null)
                {
                    this.leftClick = new ComponentDirectEvent();
                }

                return this.leftClick;
            }
        }

        private ComponentDirectEvent middleClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
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
                if (this.middleClick == null)
                {
                    this.middleClick = new ComponentDirectEvent();
                }

                return this.middleClick;
            }
        }

        private ComponentDirectEvent rightClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
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
                if (this.rightClick == null)
                {
                    this.rightClick = new ComponentDirectEvent();
                }

                return this.rightClick;
            }
        }

        private ComponentDirectEvent mouseDown;

        /// <summary>
        /// Fires when the mouse button is depressed.
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
                if (this.mouseDown == null)
                {
                    this.mouseDown = new ComponentDirectEvent();
                }

                return this.mouseDown;
            }
        }

        private ComponentDirectEvent mouseUp;

        /// <summary>
        /// Fires when the mouse key is released.
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
                if (this.mouseUp == null)
                {
                    this.mouseUp = new ComponentDirectEvent();
                }

                return this.mouseUp;
            }
        }
    }
}