/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PanelResizerDirectEvents : ComponentDirectEvents
    {
        private ComponentDirectEvent dragStart;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(PanelResizer))]
        [ListenerArgument(1, "e", typeof(Object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dragstart", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent DragStart
        {
            get
            {
                if (this.dragStart == null)
                {
                    this.dragStart = new ComponentDirectEvent();
                }

                return this.dragStart;
            }
        }

        private ComponentDirectEvent drag;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(PanelResizer))]
        [ListenerArgument(1, "e", typeof(Object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("drag", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
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

        private ComponentDirectEvent dragEnd;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(PanelResizer))]
        [ListenerArgument(1, "e", typeof(Object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dragend", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent DragEnd
        {
            get
            {
                if (this.dragEnd == null)
                {
                    this.dragEnd = new ComponentDirectEvent();
                }

                return this.dragEnd;
            }
        }
    }
}