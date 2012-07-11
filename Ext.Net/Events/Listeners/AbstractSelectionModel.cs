/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    public partial class AbstractSelectionModelListeners : ComponentListeners
    {
        private ComponentListener selectionChange;

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
        [ConfigOption("selectionchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a selection change has occurred")]
        public virtual ComponentListener SelectionChange
        {
            get
            {
                return this.selectionChange ?? (this.selectionChange = new ComponentListener());
            }
        }
    }
}
