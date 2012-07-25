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
    public partial class ImageCommandColumnListeners : CellCommandColumnListeners
    {
        private ComponentListener groupCommand;

        /// <summary>
        /// Fires when a group command is clicked.
        /// </summary>
        [ListenerArgument(0, "item", typeof(object), "this")]
        [ListenerArgument(1, "command", typeof(object), "")]
        [ListenerArgument(2, "group", typeof(object), "")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupcommand", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a group command is clicked.")]
        public virtual ComponentListener GroupCommand
        {
            get
            {
                if (this.groupCommand == null)
                {
                    this.groupCommand = new ComponentListener();
                }

                return this.groupCommand;
            }
        }
    }
}
