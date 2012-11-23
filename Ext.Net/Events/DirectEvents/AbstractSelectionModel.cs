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
    public partial class AbstractSelectionModelDirectEvents : ComponentDirectEvents
    {
        public AbstractSelectionModelDirectEvents() { }

        public AbstractSelectionModelDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent selectionChange;

        /// <summary>
        /// Fired after a selection change has occurred
        /// Parameters
        /// item : Ext.selection.Model
        /// selected : Array
        /// The selected records
        /// </summary>
        [ListenerArgument(0, "item", typeof(AbstractSelectionModel), "this")]
        [ListenerArgument(1, "selected", typeof(object), "")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("selectionchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a selection change has occurred")]
        public virtual ComponentDirectEvent SelectionChange
        {
            get
            {
                return this.selectionChange ?? (this.selectionChange = new ComponentDirectEvent(this));
            }
        }
    }
}
