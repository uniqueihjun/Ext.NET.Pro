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
    public partial class CheckColumnDirectEvents : ColumnDirectEvents
    {
        public CheckColumnDirectEvents() { }

        public CheckColumnDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent checkChange;

        /// <summary>
        /// Fires when the checked state of a row changes
        /// Parameters:
        ///     - item
        ///     - rowIndex
        ///         The row index
        ///     - record
        ///         The record
        ///     - checked
        ///         True if the box is checked
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "rowIndex")]
        [ListenerArgument(2, "record")]
        [ListenerArgument(3, "checked")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("checkchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the checked state of a row changes")]
        public virtual ComponentDirectEvent CheckChange
        {
            get
            {
                return this.checkChange ?? (this.checkChange = new ComponentDirectEvent(this));
            }
        }
    }
}
