/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class DefaultSelectionModelDirectEvents : ComponentDirectEvents
    {
        private ComponentDirectEvent beforeSelect;

        /// <summary>
        /// Fires before the selected node changes, return false to cancel the change
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "newNode")]
        [ListenerArgument(2, "oldNode")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before the selected node changes, return false to cancel the change")]
        public virtual ComponentDirectEvent BeforeSelect
        {
            get
            {
                if (this.beforeSelect == null)
                {
                    this.beforeSelect = new ComponentDirectEvent();
                }

                return this.beforeSelect;
            }
        }

        private ComponentDirectEvent selectionChange;

        /// <summary>
        /// Fires when the selected node changes
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "node")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("selectionchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the selected node changes")]
        public virtual ComponentDirectEvent SelectionChange
        {
            get
            {
                if (this.selectionChange == null)
                {
                    this.selectionChange = new ComponentDirectEvent();
                }

                return this.selectionChange;
            }
        }
    }
}