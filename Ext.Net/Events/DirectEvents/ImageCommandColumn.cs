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
    public partial class ImageCommandColumnDirectEvents : CellCommandColumnDirectEvents
    {
        public ImageCommandColumnDirectEvents() { }

        public ImageCommandColumnDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent groupCommand;

        /// <summary>
        /// Fires when a group command is clicked.
        /// </summary>
        [ListenerArgument(0, "item", typeof(object), "this")]
        [ListenerArgument(1, "command", typeof(object), "")]
        [ListenerArgument(2, "group", typeof(object), "")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupcommand", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a group command is clicked.")]
        public virtual ComponentDirectEvent GroupCommand
        {
            get
            {
                if (this.groupCommand == null)
                {
                    this.groupCommand = new ComponentDirectEvent(this);
                }

                return this.groupCommand;
            }
        }
    }
}
