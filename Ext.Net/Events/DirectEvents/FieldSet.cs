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
    public partial class FieldSetDirectEvents : ContainerDirectEvents 
    {
        public FieldSetDirectEvents() { }

        public FieldSetDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforeCollapse;

        /// <summary>
        /// Fires before this FieldSet is collapsed. Return false to prevent the collapse.
        /// Parameters
        /// item : Ext.form.FieldSet
        /// </summary>
        [ListenerArgument(0, "item", typeof(FieldSet), "the FieldSet being collapsed.")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforecollapse", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before this FieldSet is collapsed. Return false to prevent the collapse.")]
        public virtual ComponentDirectEvent BeforeCollapse
        {
            get
            {
                return this.beforeCollapse ?? (this.beforeCollapse = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent beforeExpand;

        /// <summary>
        /// Fires before this FieldSet is expanded. Return false to prevent the expand.
        /// Parameters
        /// item : Ext.form.FieldSet
        /// </summary>
        [ListenerArgument(0, "item", typeof(FieldSet), "The FieldSet being expanded.")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeexpand", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before this FieldSet is expanded. Return false to prevent the expand.")]
        public virtual ComponentDirectEvent BeforeExpand
        {
            get
            {
                return this.beforeExpand ?? (this.beforeExpand = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent collapse;

        /// <summary>
        /// Fires after this FieldSet has collapsed.
        /// Parameters
        /// item : Ext.form.FieldSet
        /// </summary>
        [ListenerArgument(0, "item", typeof(FieldSet), "The FieldSet that has been collapsed.")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("collapse", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after this FieldSet has collapsed.")]
        public virtual ComponentDirectEvent Collapse
        {
            get
            {
                return this.collapse ?? (this.collapse = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent expand;

        /// <summary>
        /// Fires after this FieldSet has expanded.
        /// Parameters
        /// item : Ext.form.FieldSet
        /// </summary>
        [ListenerArgument(0, "item", typeof(FieldSet), "The FieldSet that has been expanded.")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("expand", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after this FieldSet has expanded.")]
        public virtual ComponentDirectEvent Expand
        {
            get
            {
                return this.expand ?? (this.expand = new ComponentDirectEvent(this));
            }
        }
    }
}