/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class RowEditorDirectEvents : ComponentDirectEvents
    {
        public RowEditorDirectEvents() { }

        public RowEditorDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent afterEdit;

        /// <summary>
        /// Fired after a row is edited and passes validation.
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "o", typeof(object), "Object with changes made to the record.")]
        [ListenerArgument(2, "r", typeof(object), "The Record that was edited")]
        [ListenerArgument(3, "rowIndex", typeof(object), "The rowIndex of the row just edited")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("afteredit", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a row is edited and passes validation.")]
        public virtual ComponentDirectEvent AfterEdit
        {
            get
            {
                if (this.afterEdit == null)
                {
                    this.afterEdit = new ComponentDirectEvent(this);
                }

                return this.afterEdit;
            }
        }

        private ComponentDirectEvent beforeEdit;

        /// <summary>
        /// Fired before the row editor is activated.
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "rowIndex")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeedit", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired before the row editor is activated.")]
        public virtual ComponentDirectEvent BeforeEdit
        {
            get
            {
                if (this.beforeEdit == null)
                {
                    this.beforeEdit = new ComponentDirectEvent(this);
                }

                return this.beforeEdit;
            }
        }

        private ComponentDirectEvent validateEdit;

        /// <summary>
        /// Fired after a row is edited and passes validation.
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "o", typeof(object), "Object with changes made to the record.")]
        [ListenerArgument(2, "r", typeof(object), "The Record that was edited")]
        [ListenerArgument(3, "rowIndex", typeof(object), "The rowIndex of the row just edited")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("validateedit", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a row is edited and passes validation.")]
        public virtual ComponentDirectEvent ValidateEdit
        {
            get
            {
                if (this.validateEdit == null)
                {
                    this.validateEdit = new ComponentDirectEvent(this);
                }

                return this.validateEdit;
            }
        }

        private ComponentDirectEvent preEdit;

        /// <summary>
        /// Fired for each field's value.
        /// </summary>
        [ListenerArgument(0, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("preedit", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired for each field's value.")]
        public virtual ComponentDirectEvent PreEdit
        {
            get
            {
                if (this.preEdit == null)
                {
                    this.preEdit = new ComponentDirectEvent(this);
                }

                return this.preEdit;
            }
        }
    }
}