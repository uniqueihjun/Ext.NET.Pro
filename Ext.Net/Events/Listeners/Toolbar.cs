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
	[Description("")]
    public partial class ToolbarListeners : ContainerListeners
    {
        private ComponentListener overFlowChange;

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
        [ConfigOption("overflowchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the overflow state has changed.")]
        public virtual ComponentListener OverFlowChange
        {
            get
            {
                return this.overFlowChange ?? (this.overFlowChange = new ComponentListener());
            }
        }
    }
}