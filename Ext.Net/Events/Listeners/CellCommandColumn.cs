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
    public partial class CellCommandColumnListeners : ColumnListeners
    {
        private ComponentListener command;

        /// <summary>
        /// Fires when a command is clicked.
        /// </summary>
        [ListenerArgument(0, "item", typeof(object), "this")]
        [ListenerArgument(1, "command", typeof(object), "")]
        [ListenerArgument(2, "record", typeof(object), "")]
        [ListenerArgument(3, "recordIndex", typeof(object), "")]
        [ListenerArgument(4, "cellIndex", typeof(object), "")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("command", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a command is clicked.")]
        public virtual ComponentListener Command
        {
            get
            {
                if (this.command == null)
                {
                    this.command = new ComponentListener();
                }

                return this.command;
            }
        }
    }
}
