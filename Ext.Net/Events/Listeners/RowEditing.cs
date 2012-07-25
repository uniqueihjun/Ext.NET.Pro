/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class RowEditingListeners : ComponentListeners
    {
        private ComponentListener beforeEdit;

        /// <summary>
        /// Fires before row editing is triggered.  The edit event object has the following properties 
        /// grid - The grid this editor is on
        /// view - The grid view
        /// store - The grid store
        /// record - The record being edited
        /// row - The grid table row
        /// column - The grid Column defining the column that initiated the edit
        /// rowIdx - The row index that is being edited
        /// colIdx - The column index that initiated the edit
        /// cancel - Set this to true to cancel the edit or return false from your handler.
        /// 
        /// Parameters
        /// e : Object
        /// An edit event (see above for description)
        /// </summary>
        [ListenerArgument(0, "item", typeof(object))]
        [ListenerArgument(1, "e", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeedit", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before row editing is triggered.")]
        public virtual ComponentListener BeforeEdit
        {
            get
            {
                return this.beforeEdit ?? (this.beforeEdit = new ComponentListener());
            }
        }

        private ComponentListener cancelEdit;

        /// <summary>
        /// Fires when the user has started editing a row but then cancelled the edit.  
        /// 
        /// The edit event object has the following properties:
        /// grid - The grid this editor is on
        /// view - The grid view
        /// store - The grid store
        /// record - The record being edited
        /// row - The grid table row
        /// column - The grid Column defining the column that initiated the edit
        /// rowIdx - The row index that is being edited
        /// colIdx - The column index that initiated the edit
        /// cancel - Set this to true to cancel the edit or return false from your handler.
        /// 
        /// Parameters
        /// item : Ext.grid.plugin.Editing
        /// e : Object
        /// An edit event (see above for description)
        /// </summary>
        [ListenerArgument(0, "item", typeof(object))]
        [ListenerArgument(1, "e", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("canceledit", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the user has started editing a row but then cancelled the edit.")]
        public virtual ComponentListener CancelEdit
        {
            get
            {
                return this.cancelEdit ?? (this.cancelEdit = new ComponentListener());
            }
        }

        private ComponentListener edit;

        /// <summary>
        /// Fires after a row is edited.  The edit event object has the following properties 
        /// grid - The grid this editor is on
        /// view - The grid view
        /// store - The grid store
        /// record - The record being edited
        /// row - The grid table row
        /// column - The grid Column defining the column that initiated the edit
        /// rowIdx - The row index that is being edited
        /// colIdx - The column index that initiated the edit
        /// 
        /// Parameters
        /// item : Ext.grid.plugin.Editing
        /// e : Object
        /// An edit event (see above for description)
        /// </summary>
        [ListenerArgument(0, "item", typeof(object))]
        [ListenerArgument(1, "e", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("edit", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after a row is edited.")]
        public virtual ComponentListener Edit
        {
            get
            {
                return this.edit ?? (this.edit = new ComponentListener());
            }
        }

        private ComponentListener validateEdit;

        /// <summary>
        /// Fires after a cell is edited, but before the value is set in the record. Return false to cancel the change. The edit event object has the following properties 
        /// grid - The grid this editor is on
        /// view - The grid view
        /// store - The grid store
        /// record - The record being edited
        /// row - The grid table row
        /// column - The grid Column defining the column that initiated the edit
        /// rowIdx - The row index that is being edited
        /// colIdx - The column index that initiated the edit
        /// cancel - Set this to true to cancel the edit or return false from your handler.
        /// 
        /// Usage example showing how to remove the red triangle (dirty record indicator) from some records (not all). By observing the grid's validateedit event, it can be cancelled if the edit occurs on a targeted row (for example) and then setting the field's new value in the Record directly:
        /// 
        /// grid.on('validateedit', function(ed, e) {
        ///   var myTargetRow = 6;
        /// 
        ///   if (e.row == myTargetRow) {
        ///     e.cancel = true;
        ///     e.record.data[e.field] = e.value;
        ///   }
        /// });
        /// 
        /// Parameters
        /// item : Ext.grid.plugin.Editing
        /// e : Object
        /// An edit event (see above for description)
        /// </summary>
        [ListenerArgument(0, "item", typeof(object))]
        [ListenerArgument(1, "e", typeof(object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("validateedit", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after a cell is edited, but before the value is set in the record.")]
        public virtual ComponentListener ValidateEdit
        {
            get
            {
                return this.validateEdit ?? (this.validateEdit = new ComponentListener());
            }
        }
    }
}
