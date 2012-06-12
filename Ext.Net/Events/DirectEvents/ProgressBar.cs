/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ProgressBarDirectEvents : BoxComponentDirectEvents
    {
        private ComponentDirectEvent update;

        /// <summary>
        /// Fires after each update interval
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
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
                if (this.update == null)
                {
                    this.update = new ComponentDirectEvent();
                }

                return this.update;
            }
        }
    }
}