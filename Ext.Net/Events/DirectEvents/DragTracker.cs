/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class DragTrackerDirectEvents : ComponentDirectEvents
    {
        private ComponentDirectEvent drag;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("drag", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        public virtual ComponentDirectEvent Drag
        {
            get
            {
                if (this.drag == null)
                {
                    this.drag = new ComponentDirectEvent();
                }

                return this.drag;
            }
        }

        private ComponentDirectEvent dragend;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dragend", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        public virtual ComponentDirectEvent DragEnd
        {
            get
            {
                if (this.dragend == null)
                {
                    this.dragend = new ComponentDirectEvent();
                }

                return this.dragend;
            }
        }

        private ComponentDirectEvent dragstart;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dragstart", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        public virtual ComponentDirectEvent DragStart
        {
            get
            {
                if (this.dragstart == null)
                {
                    this.dragstart = new ComponentDirectEvent();
                }

                return this.dragstart;
            }
        }

        private ComponentDirectEvent mousedown;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mousedown", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        public virtual ComponentDirectEvent MouseDown
        {
            get
            {
                if (this.mousedown == null)
                {
                    this.mousedown = new ComponentDirectEvent();
                }

                return this.mousedown;
            }
        }

        private ComponentDirectEvent mousemove;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mousemove", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        public virtual ComponentDirectEvent MouseMove
        {
            get
            {
                if (this.mousemove == null)
                {
                    this.mousemove = new ComponentDirectEvent();
                }

                return this.mousemove;
            }
        }

        private ComponentDirectEvent mouseup;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "e", typeof(object), "Event object")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseup", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        public virtual ComponentDirectEvent MouseUp
        {
            get
            {
                if (this.mouseup == null)
                {
                    this.mouseup = new ComponentDirectEvent();
                }

                return this.mouseup;
            }
        }
    }
}
