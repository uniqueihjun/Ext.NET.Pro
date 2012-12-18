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
	/// 
	/// </summary>
	[Description("")]
    public partial class ToolbarDirectEvents : ContainerDirectEvents 
    {
        public ToolbarDirectEvents() { }

        public ToolbarDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent overFlowChange;

        /// <summary>
        /// Fires after the overflow state has changed.
        /// Parameters
        /// item : Object
        ///     The Container
        /// lastOverflow : Boolean
        ///     overflow state
        /// </summary>
        [ListenerArgument(0, "item", typeof(AbstractContainer), "this")]
        [ListenerArgument(1, "lastOverflow")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("overflowchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the overflow state has changed.")]
        public virtual ComponentDirectEvent OverFlowChange
        {
            get
            {
                return this.overFlowChange ?? (this.overFlowChange = new ComponentDirectEvent(this));
            }
        }
    }
}