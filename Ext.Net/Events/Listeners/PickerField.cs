/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class PickerFieldListeners : TriggerFieldListeners
    {
        private ComponentListener collapse;

        /// <summary>
        /// Fires when the field's picker is collapsed.
        /// Parameters
        /// item : Ext.form.field.Picker
        ///     This field instance
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("collapse", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Collapse
        {
            get
            {
                return this.collapse ?? (this.collapse = new ComponentListener());
            }
        }

        private ComponentListener expand;

        /// <summary>
        /// Fires when the field's picker is expanded.
        /// Parameters
        /// item : Ext.form.field.Picker
        ///     This field instance
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("expand", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Expand
        {
            get
            {
                return this.expand ?? (this.expand = new ComponentListener());
            }
        }

        private ComponentListener select;

        /// <summary>
        /// Fires when the field's picker is collapsed.
        /// 
        /// Parameters
        /// item : Ext.form.field.Picker
        ///     This field instance
        /// value : Mixed
        ///     The value that was selected. The exact type of this value is dependent on the individual field and picker implementations.
        /// </summary>        
        [ListenerArgument(0, "item", typeof(Field), "This field")]
        [ListenerArgument(1, "value", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentListener());
            }
        }
    }
}
