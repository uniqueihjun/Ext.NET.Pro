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
    public partial class RowExpanderDirectEvents : ContainerDirectEvents
    {
        private ComponentDirectEvent beforeExpand;

        /// <summary>
        /// Fires before a row expand
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowExpander), "this")]
        [ListenerArgument(1, "record", typeof(object))]
        [ListenerArgument(2, "body", typeof(object))]
        [ListenerArgument(3, "rowIndex", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeexpand", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a row expand")]
        public virtual ComponentDirectEvent BeforeExpand
        {
            get
            {
                if (this.beforeExpand == null)
                {
                    this.beforeExpand = new ComponentDirectEvent();
                }

                return this.beforeExpand;
            }
        }

        private ComponentDirectEvent expand;

        /// <summary>
        /// Fires afyter a row expand
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowExpander), "this")]
        [ListenerArgument(1, "record", typeof(object))]
        [ListenerArgument(2, "body", typeof(object))]
        [ListenerArgument(3, "rowIndex", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("expand", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires afyter a row expand")]
        public virtual ComponentDirectEvent Expand
        {
            get
            {
                if (this.expand == null)
                {
                    this.expand = new ComponentDirectEvent();
                }

                return this.expand;
            }
        }

        private ComponentDirectEvent beforeCollapse;

        /// <summary>
        /// Fires before a row collapse
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowExpander), "this")]
        [ListenerArgument(1, "record", typeof(object))]
        [ListenerArgument(2, "body", typeof(object))]
        [ListenerArgument(3, "rowIndex", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforecollapse", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a row collapse")]
        public virtual ComponentDirectEvent BeforeCollapse
        {
            get
            {
                if (this.beforeCollapse == null)
                {
                    this.beforeCollapse = new ComponentDirectEvent();
                }

                return this.beforeCollapse;
            }
        }

        private ComponentDirectEvent collapse;

        /// <summary>
        /// Fires after a row collapse
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowExpander), "this")]
        [ListenerArgument(1, "record", typeof(object))]
        [ListenerArgument(2, "body", typeof(object))]
        [ListenerArgument(3, "rowIndex", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("collapse", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after a row collapse")]
        public virtual ComponentDirectEvent Collapse
        {
            get
            {
                if (this.collapse == null)
                {
                    this.collapse = new ComponentDirectEvent();
                }

                return this.collapse;
            }
        }
    }
}
