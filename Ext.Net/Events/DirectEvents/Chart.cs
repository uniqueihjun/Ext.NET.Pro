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
    public partial class ChartDirectEvents : AbstractComponentDirectEvents
    {
        public ChartDirectEvents() { }

        public ChartDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforerefresh;

        /// <summary>
        /// Fires before a refresh to the chart data is called. If the beforerefresh handler returns false the refresh action will be cancelled.
        /// Parameters
        /// item : Ext.chart.Chart
        /// </summary>
        [ListenerArgument(0, "item", typeof(Chart), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforerefresh", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a refresh to the chart data is called. If the beforerefresh handler returns false the refresh action will be cancelled.")]
        public virtual ComponentDirectEvent BeforeRefresh
        {
            get
            {
                return this.beforerefresh ?? (this.beforerefresh = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent refresh;

        /// <summary>
        /// Fires after the chart data has been refreshed.
        /// Parameters
        /// item : Ext.chart.Chart
        /// </summary>
        [ListenerArgument(0, "item", typeof(Chart), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("refresh", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the chart data has been refreshed.")]
        public virtual ComponentDirectEvent Refresh
        {
            get
            {
                return this.refresh ?? (this.refresh = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent select;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Chart), "this")]
        [ListenerArgument(1, "box")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentDirectEvent(this));
            }
        }
    }
}
