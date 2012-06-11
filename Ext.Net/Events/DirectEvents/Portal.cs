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
    public partial class PortalDirectEvents : PanelDirectEvents
    {
        public PortalDirectEvents() { }

        public PortalDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent validateDrop;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("validatedrop", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent ValidateDrop
        {
            get
            {
                if (this.validateDrop == null)
                {
                    this.validateDrop = new ComponentDirectEvent(this);
                }

                return this.validateDrop;
            }
        }

        private ComponentDirectEvent beforeDragOver;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforedragover", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeDragOver
        {
            get
            {
                if (this.beforeDragOver == null)
                {
                    this.beforeDragOver = new ComponentDirectEvent(this);
                }

                return this.beforeDragOver;
            }
        }

        private ComponentDirectEvent dragOver;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dragover", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent DragOver
        {
            get
            {
                if (this.dragOver == null)
                {
                    this.dragOver = new ComponentDirectEvent(this);
                }

                return this.dragOver;
            }
        }

        private ComponentDirectEvent beforeDrop;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforedrop", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeDrop
        {
            get
            {
                if (this.beforeDrop == null)
                {
                    this.beforeDrop = new ComponentDirectEvent(this);
                }

                return this.beforeDrop;
            }
        }

        private ComponentDirectEvent drop;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("drop", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Drop
        {
            get
            {
                if (this.drop == null)
                {
                    this.drop = new ComponentDirectEvent(this);
                }

                return this.drop;
            }
        }
    }
}