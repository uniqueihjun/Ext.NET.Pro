/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class MultiSelectionModelDirectEvents : ComponentDirectEvents
    {
        public MultiSelectionModelDirectEvents() { }

        public MultiSelectionModelDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent selectionChange;

        /// <summary>
        /// Fires when the selected nodes change
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "nodes")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("selectionchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the selected nodes change")]
        public virtual ComponentDirectEvent SelectionChange
        {
            get
            {
                if (this.selectionChange == null)
                {
                    this.selectionChange = new ComponentDirectEvent(this);
                }

                return this.selectionChange;
            }
        }
    }
}