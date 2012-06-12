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
    public partial class TextFieldListeners : FieldListeners
    {
        private ComponentListener autoSize;

        /// <summary>
        /// Fires when the autosize function is triggered. The field may or may not have actually changed size according to the default logic, but this event provides a hook for the developer to apply additional logic at runtime to resize the field if needed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This text field")]
        [ListenerArgument(1, "width", typeof(int), "The new field width")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("autosize", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the autosize function is triggered. The field may or may not have actually changed size according to the default logic, but this event provides a hook for the developer to apply additional logic at runtime to resize the field if needed.")]
        public virtual ComponentListener AutoSize
        {
            get
            {
                if (this.autoSize == null)
                {
                    this.autoSize = new ComponentListener();
                }

                return this.autoSize;
            }
        }

        private ComponentListener keyDown;

        /// <summary>
        /// Keydown input field event. This event only fires if enableKeyEvents is set to true.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This text field")]
        [ListenerArgument(1, "e", typeof(object), "EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("keydown", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Keydown input field event. This event only fires if enableKeyEvents is set to true.")]
        public virtual ComponentListener KeyDown
        {
            get
            {
                if (this.keyDown == null)
                {
                    this.keyDown = new ComponentListener();
                }

                return this.keyDown;
            }
        }

        private ComponentListener keyPress;

        /// <summary>
        /// Keypress input field event. This event only fires if enableKeyEvents is set to true.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This text field")]
        [ListenerArgument(1, "e", typeof(object), "EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("keypress", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Keypress input field event. This event only fires if enableKeyEvents is set to true.")]
        public virtual ComponentListener KeyPress
        {
            get
            {
                if (this.keyPress == null)
                {
                    this.keyPress = new ComponentListener();
                }

                return this.keyPress;
            }
        }

        private ComponentListener keyUp;

        /// <summary>
        /// Keyup input field event. This event only fires if enableKeyEvents is set to true.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This text field")]
        [ListenerArgument(1, "e", typeof(object), "EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("keyup", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Keyup input field event. This event only fires if enableKeyEvents is set to true.")]
        public virtual ComponentListener KeyUp
        {
            get
            {
                if (this.keyUp == null)
                {
                    this.keyUp = new ComponentListener();
                }

                return this.keyUp;
            }
        }

        private ComponentListener iconClick;

        /// <summary>
        /// Icon click event
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This text field")]
        [ListenerArgument(1, "e", typeof(object), "The Ext.EventObject encapsulating the DOM event")]
        [ListenerArgument(2, "t", typeof(object), "The target of the event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("iconclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Icon click event")]
        public virtual ComponentListener IconClick
        {
            get
            {
                if (this.iconClick == null)
                {
                    this.iconClick = new ComponentListener();
                }

                return this.iconClick;
            }
        }
    }
}