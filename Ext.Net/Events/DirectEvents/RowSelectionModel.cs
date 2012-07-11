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
	[Description("")]
    public partial class RowSelectionModelDirectEvents : ComponentBaseDirectEvents
    {
        private ComponentDirectEvent beforeRowSelect;

        /// <summary>
        /// Fires when a row is being selected, return false to cancel.
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "SelectionModel")]
        [ListenerArgument(1, "rowIndex", typeof(int), "The selected index")]
        [ListenerArgument(2, "keepExisting", typeof(bool), "False if other selections will be cleared")]
        [ListenerArgument(3, "record", typeof(object), "The record to be selected")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforerowselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a row is being selected, return false to cancel.")]
        public virtual ComponentDirectEvent BeforeRowSelect
        {
            get
            {
                if (this.beforeRowSelect == null)
                {
                    this.beforeRowSelect = new ComponentDirectEvent();
                }

                return this.beforeRowSelect;
            }
        }

        private ComponentDirectEvent rowDeselect;

        /// <summary>
        /// Fires when a row is deselected.
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "SelectionModel")]
        [ListenerArgument(1, "rowIndex", typeof(int), "The selected index")]
        [ListenerArgument(2, "record", typeof(object), "The selected record")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("rowdeselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a row is deselected.")]
        public virtual ComponentDirectEvent RowDeselect
        {
            get
            {
                if (this.rowDeselect == null)
                {
                    this.rowDeselect = new ComponentDirectEvent();
                }

                return this.rowDeselect;
            }
        }

        private ComponentDirectEvent rowSelect;

        /// <summary>
        /// Fires when a row is selected.
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "SelectionModel")]
        [ListenerArgument(1, "rowIndex", typeof(int), "The selected index")]
        [ListenerArgument(2, "record", typeof(object), "The selected record")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("rowselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a row is selected.")]
        public virtual ComponentDirectEvent RowSelect
        {
            get
            {
                if (this.rowSelect == null)
                {
                    this.rowSelect = new ComponentDirectEvent();
                }

                return this.rowSelect;
            }
        }

        private ComponentDirectEvent selectionChange;

        /// <summary>
        /// Fires when the selection changes
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "SelectionModel")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("selectionchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the selection changes.")]
        public virtual ComponentDirectEvent SelectionChange
        {
            get
            {
                if (this.selectionChange == null)
                {
                    this.selectionChange = new ComponentDirectEvent();
                }

                return this.selectionChange;
            }
        }

        private ComponentDirectEvent beforeCheckAllClick;

        /// <summary>
        /// Fires when click on the check all
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "SelectionModel")]
        [ListenerArgument(1, "checked", typeof(bool), "checked state")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforecheckallclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when click on the check all.")]
        public virtual ComponentDirectEvent BeforeCheckAllClick
        {
            get
            {
                if (this.beforeCheckAllClick == null)
                {
                    this.beforeCheckAllClick = new ComponentDirectEvent();
                }

                return this.beforeCheckAllClick;
            }
        }

        private ComponentDirectEvent afterCheckAllClick;

        /// <summary>
        /// Fires when click on the check all
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "SelectionModel")]
        [ListenerArgument(1, "checked", typeof(bool), "checked state")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("aftercheckallclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when click on the check all.")]
        public virtual ComponentDirectEvent AfterCheckAllClick
        {
            get
            {
                if (this.afterCheckAllClick == null)
                {
                    this.afterCheckAllClick = new ComponentDirectEvent();
                }

                return this.afterCheckAllClick;
            }
        }
    }
}