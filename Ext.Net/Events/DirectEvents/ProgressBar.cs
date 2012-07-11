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
    public partial class ProgressBarDirectEvents : AbstractComponentDirectEvents
    {
        public ProgressBarDirectEvents() { }

        public ProgressBarDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent update;

        /// <summary>
        /// Fires after each update interval
        /// Parameters
        /// item : Ext.ProgressBar
        /// value : Number
        ///     The current progress value
        /// text : String
        ///     The current progress text
        /// </summary>
        [ListenerArgument(0, "item", typeof(AbstractComponent), "this")]
        [ListenerArgument(1, "value", typeof(int), "current progress value")]
        [ListenerArgument(2, "text", typeof(int), "current progress text")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("update", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after each update interval")]
        public virtual ComponentDirectEvent Update
        {
            get
            {
                return this.update ?? (this.update = new ComponentDirectEvent(this));
            }
        }
    }
}