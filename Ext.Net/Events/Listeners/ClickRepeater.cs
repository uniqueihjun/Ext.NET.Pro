/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
                if (this.click == null)
                {
                    this.click = new ComponentListener();
                }

                return this.click;
            }
        }

        private ComponentListener leftClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
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
                if (this.leftClick == null)
                {
                    this.leftClick = new ComponentListener();
                }

                return this.leftClick;
            }
        }

        private ComponentListener middleClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
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
                if (this.middleClick == null)
                {
                    this.middleClick = new ComponentListener();
                }

                return this.middleClick;
            }
        }

        private ComponentListener rightClick;

        /// <summary>
        /// Fires on a specified interval during the time the element is pressed.
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
                if (this.rightClick == null)
                {
                    this.rightClick = new ComponentListener();
                }

                return this.rightClick;
            }
        }

        private ComponentListener mouseDown;

        /// <summary>
        /// Fires when the mouse button is depressed.
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
                if (this.mouseDown == null)
                {
                    this.mouseDown = new ComponentListener();
                }

                return this.mouseDown;
            }
        }

        private ComponentListener mouseUp;

        /// <summary>
        /// Fires when the mouse key is released.
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
                if (this.mouseUp == null)
                {
                    this.mouseUp = new ComponentListener();
                }

                return this.mouseUp;
            }
        }
    }
}