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
    public partial class DragTrackerListeners : ComponentListeners
    {
        private ComponentListener drag;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("drag", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Drag
        {
            get
            {
                if (this.drag == null)
                {
                    this.drag = new ComponentListener();
                }

                return this.drag;
            }
        }

        private ComponentListener dragend;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dragend", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener DragEnd
        {
            get
            {
                if (this.dragend == null)
                {
                    this.dragend = new ComponentListener();
                }

                return this.dragend;
            }
        }

        private ComponentListener dragstart;

		/// <summary>
		/// 
		/// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dragstart", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
		[Description("")]
        public virtual ComponentListener DragStart
        {
            get
            {
                if (this.dragstart == null)
                {
                    this.dragstart = new ComponentListener();
                }

                return this.dragstart;
            }
        }

        private ComponentListener mousedown;

		/// <summary>
		/// 
		/// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mousedown", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
		[Description("")]
        public virtual ComponentListener MouseDown
        {
            get
            {
                if (this.mousedown == null)
                {
                    this.mousedown = new ComponentListener();
                }

                return this.mousedown;
            }
        }

        private ComponentListener mousemove;

		/// <summary>
		/// 
		/// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mousemove", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
		[Description("")]
        public virtual ComponentListener MouseMove
        {
            get
            {
                if (this.mousemove == null)
                {
                    this.mousemove = new ComponentListener();
                }

                return this.mousemove;
            }
        }

        private ComponentListener mouseup;

		/// <summary>
		/// 
		/// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseup", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
		[Description("")]
        public virtual ComponentListener MouseUp
        {
            get
            {
                if (this.mouseup == null)
                {
                    this.mouseup = new ComponentListener();
                }

                return this.mouseup;
            }
        }
    }
}