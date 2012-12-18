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
    /// The Ext.grid.plugin.CellEditing plugin injects editing at a cell level for a Grid. Only a single cell will be editable at a time. The field that will be used for the editor is defined at the field. The editor can be a field instance or a field configuration.
    /// 
    /// If an editor is not specified for a particular column then that cell will not be editable and it will be skipped when activated via the mouse or the keyboard.
    /// 
    /// The editor may be shared for each column in the grid, or a different one may be specified for each column. An appropriate field type should be chosen to match the data structure that it will be editing. For example, to edit a date, it would be useful to specify Ext.form.field.Date as the editor.
    /// </summary>
    [Meta]
    public partial class CellEditing : GridEditing
    {
        /// <summary>
        /// 
        /// </summary>
        public CellEditing()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.grid.plugin.CellEditing";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [ConfigOption("ptype")]
        [DefaultValue("")]
        [Description("")]
        public override string PType
        {
            get
            {
                return "cellediting";
            }
        }

        private CellEditingListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]        
        [Description("Client-side JavaScript Event Handlers")]
        public CellEditingListeners Listeners
        {
            get
            {
                return this.listeners ?? (this.listeners = new CellEditingListeners());
            }
        }

        private CellEditingDirectEvents directEvents;

        /// <summary>
        /// Server-side Ajax Event Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]        
        [Description("Server-side Ajax Event Handlers")]
        public CellEditingDirectEvents DirectEvents
        {
            get
            {
                return this.directEvents ?? (this.directEvents = new CellEditingDirectEvents(this));
            }
        }

        /// <summary>
        /// Starts editing by position (row/column)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public virtual void StartEditByPosition(int row, int column)
        {
            this.Call("startEditByPosition", new { row, column });
        }
    }
}
