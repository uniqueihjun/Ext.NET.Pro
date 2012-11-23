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
    public partial class FieldSetListeners : ContainerListeners 
    {
        private ComponentListener beforeCollapse;

        /// <summary>
        /// Fires before this FieldSet is collapsed. Return false to prevent the collapse.
        /// Parameters
        /// item : Ext.form.FieldSet
        /// </summary>
        [ListenerArgument(0, "item", typeof(FieldSet), "the FieldSet being collapsed.")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforecollapse", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before this FieldSet is collapsed. Return false to prevent the collapse.")]
        public virtual ComponentListener BeforeCollapse
        {
            get
            {
                return this.beforeCollapse ?? (this.beforeCollapse = new ComponentListener());
            }
        }

        private ComponentListener beforeExpand;

        /// <summary>
        /// Fires before this FieldSet is expanded. Return false to prevent the expand.
        /// Parameters
        /// item : Ext.form.FieldSet
        /// </summary>
        [ListenerArgument(0, "item", typeof(FieldSet), "The FieldSet being expanded.")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeexpand", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before this FieldSet is expanded. Return false to prevent the expand.")]
        public virtual ComponentListener BeforeExpand
        {
            get
            {
                return this.beforeExpand ?? (this.beforeExpand = new ComponentListener());
            }
        }

        private ComponentListener collapse;

        /// <summary>
        /// Fires after this FieldSet has collapsed.
        /// Parameters
        /// item : Ext.form.FieldSet
        /// </summary>
        [ListenerArgument(0, "item", typeof(FieldSet), "The FieldSet that has been collapsed.")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("collapse", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after this FieldSet has collapsed.")]
        public virtual ComponentListener Collapse
        {
            get
            {
                return this.collapse ?? (this.collapse = new ComponentListener());
            }
        }

        private ComponentListener expand;

        /// <summary>
        /// Fires after this FieldSet has expanded.
        /// Parameters
        /// item : Ext.form.FieldSet
        /// </summary>
        [ListenerArgument(0, "item", typeof(FieldSet), "The FieldSet that has been expanded.")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("expand", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after this FieldSet has expanded.")]
        public virtual ComponentListener Expand
        {
            get
            {
                return this.expand ?? (this.expand = new ComponentListener());
            }
        }
    }
}