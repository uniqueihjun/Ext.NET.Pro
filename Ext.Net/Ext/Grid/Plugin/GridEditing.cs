/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// This class provides an abstract grid editing plugin on selected columns. The editable columns are specified by providing an editor in the column configuration.
    /// </summary>
    [Meta]
    public abstract partial class GridEditing : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        protected override System.Type RequiredOwnerType
        {
            get
            {
                return typeof(TablePanel);
            }
        }
        
        /// <summary>
        /// The number of clicks on a grid required to display the editor (defaults to 2).
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(2)]
        [Description("The number of clicks on a grid required to display the editor (defaults to 2).")]
        public virtual int ClicksToEdit
        {
            get
            {
                return this.State.Get<int>("ClicksToEdit", 2);
            }
            set
            {
                this.State.Set("ClicksToEdit", value);
            }
        }

        /// <summary>
        /// The event which triggers editing. Supercedes the clicksToEdit configuration. Maybe one of:
        /// 
        /// cellclick
        /// celldblclick
        /// cellfocus
        /// rowfocus
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [Description("The event which triggers editing. Supercedes the clicksToEdit configuration.")]
        public virtual string TriggerEvent
        {
            get
            {
                return this.State.Get<string>("TriggerEvent", "");
            }
            set
            {
                this.State.Set("TriggerEvent", value);
            }
        }

        /// <summary>
        /// Start editing the specified record, using the specified Column definition to define which field is being edited.
        /// </summary>
        /// <param name="recordId">The Store data record id which backs the row to be edited.</param>
        /// <param name="dataIndex">The Column object dataIndex defining the column to be edited.</param>
        public virtual void StartEdit(object recordId, string dataIndex)
        {
            this.Call("startEdit", 
                new JRawValue("{0}.grid.store.getById({1})".FormatWith(this.CallID, JSON.Serialize(recordId))),
                new JRawValue("{0}.grid.headerCt.down('gridcolumn[dataIndex={1}]')".FormatWith(this.ClientID, dataIndex)));
        }

        /// <summary>
        /// Start editing the specified record, using the specified Column definition to define which field is being edited.
        /// </summary>
        /// <param name="recordIndex">The Store data record index which backs the row to be edited.</param>
        /// <param name="columnIndex">The Column object index defining the column to be edited.</param>
        public virtual void StartEdit(int recordIndex, int columnIndex)
        {
            this.Call("startEdit", recordIndex, columnIndex);
        }

        /// <summary>
        /// Start editing the specified record, using the specified Column definition to define which field is being edited.
        /// </summary>
        /// <param name="record">The Store data record which backs the row to be edited.</param>
        /// <param name="columnIndex">The Column object index defining the column to be edited.</param>
        public virtual void StartEdit(ModelProxy record, int columnIndex)
        {
            this.Call("startEdit", JRawValue.From(record.ModelInstance), columnIndex);
        }

        /// <summary>
        /// Start editing the specified record, using the specified Column definition to define which field is being edited.
        /// </summary>
        /// <param name="record">The Store data record which backs the row to be edited.</param>
        /// <param name="dataIndex">The Column object dataIndex defining the column to be edited.</param>
        public virtual void StartEdit(ModelProxy record, string dataIndex)
        {
            this.Call("startEdit",
                JRawValue.From(record.ModelInstance),
                new JRawValue("{0}.grid.headerCt.down('gridcolumn[dataIndex={1}]')".FormatWith(this.ClientID, dataIndex)));
        }

        /// <summary>
        /// Cancel any active edit that is in progress.
        /// </summary>
        public virtual void CancelEdit()
        {
            this.Call("cancelEdit");
        }

        /// <summary>
        /// Complete the edit if there is an active edit in progress.
        /// </summary>
        public virtual void CompleteEdit()
        {
            this.Call("completeEdit");
        }
    }
}
