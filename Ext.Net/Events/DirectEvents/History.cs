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
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class HistoryDirectEvents : ComponentDirectEvents
    {
        public HistoryDirectEvents() { }

        public HistoryDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent change;

        /// <summary>
        /// Handle this change event in order to restore the UI to the appropriate history state
        /// </summary>
        [ListenerArgument(0, "token", typeof(string))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("change", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Handle this change event in order to restore the UI to the appropriate history state")]
        public virtual ComponentDirectEvent Change
        {
            get
            {
                if (this.change == null)
                {
                    this.change = new ComponentDirectEvent(this);
                }

                return this.change;
            }
        }
    }
}