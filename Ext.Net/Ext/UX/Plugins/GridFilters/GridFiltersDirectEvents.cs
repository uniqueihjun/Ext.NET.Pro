/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    [ToolboxItem(false)]
    [TypeConverter(typeof(DirectEventsConverter))]
    public partial class GridFiltersDirectEvents : ComponentDirectEvents
    {
        private ComponentDirectEvent filterUpdate;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(object), "plugin")]
        [ListenerArgument(1, "filter", typeof(object), "filter")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("filterupdate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent FilterUpdate
        {
            get
            {
                if (this.filterUpdate == null)
                {
                    this.filterUpdate = new ComponentDirectEvent();
                }

                return this.filterUpdate;
            }
        }
    }
}