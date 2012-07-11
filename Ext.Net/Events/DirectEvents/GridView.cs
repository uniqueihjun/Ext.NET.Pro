/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class GridViewDirectEvents : ComponentBaseDirectEvents
    {
        private ComponentDirectEvent beforeRefresh;

        /// <summary>
        /// Internal UI Event. Fired before the view is refreshed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GridView))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforerefresh", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Internal UI Event. Fired before the view is refreshed.")]
        public virtual ComponentDirectEvent BeforeRefresh
        {
            get
            {
                if (this.beforeRefresh == null)
                {
                    this.beforeRefresh = new ComponentDirectEvent();
                }

                return this.beforeRefresh;
            }
        }

        private ComponentDirectEvent beforeRowRemoved;

        /// <summary>
        /// Internal UI Event. Fired before a row is removed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GridView))]
        [ListenerArgument(1, "rowIndex")]
        [ListenerArgument(2, "record")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforerowremoved", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Internal UI Event. Fired before a row is removed.")]
        public virtual ComponentDirectEvent BeforeRowRemoved
        {
            get
            {
                if (this.beforeRowRemoved == null)
                {
                    this.beforeRowRemoved = new ComponentDirectEvent();
                }

                return this.beforeRowRemoved;
            }
        }

        private ComponentDirectEvent beforeRowsInserted;

        /// <summary>
        /// Internal UI Event. Fired before rows are inserted.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GridView))]
        [ListenerArgument(1, "firstRow")]
        [ListenerArgument(2, "lastRow")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforerowsinserted", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Internal UI Event. Fired before rows are inserted.")]
        public virtual ComponentDirectEvent BeforeRowsInserted
        {
            get
            {
                if (this.beforeRowsInserted == null)
                {
                    this.beforeRowsInserted = new ComponentDirectEvent();
                }

                return this.beforeRowsInserted;
            }
        }

        private ComponentDirectEvent refresh;

        /// <summary>
        /// Internal UI Event. Fired after the GridView's body has been refreshed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GridView))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("refresh", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Internal UI Event. Fired after the GridView's body has been refreshed.")]
        public virtual ComponentDirectEvent Refresh
        {
            get
            {
                if (this.refresh == null)
                {
                    this.refresh = new ComponentDirectEvent();
                }

                return this.refresh;
            }
        }

        private ComponentDirectEvent rowRemoved;

        /// <summary>
        /// Internal UI Event. Fired after a row is removed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GridView))]
        [ListenerArgument(1, "rowIndex")]
        [ListenerArgument(2, "record")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("rowremoved", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Internal UI Event. Fired after a row is removed.")]
        public virtual ComponentDirectEvent RowRemoved
        {
            get
            {
                if (this.rowRemoved == null)
                {
                    this.rowRemoved = new ComponentDirectEvent();
                }

                return this.rowRemoved;
            }
        }

        private ComponentDirectEvent rowsInserted;

        /// <summary>
        /// Internal UI Event. Fired after rows are inserted.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GridView))]
        [ListenerArgument(1, "firstRow")]
        [ListenerArgument(2, "lastRow")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("rowsinserted", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Internal UI Event. Fired after rows are inserted.")]
        public virtual ComponentDirectEvent RowsInserted
        {
            get
            {
                if (this.rowsInserted == null)
                {
                    this.rowsInserted = new ComponentDirectEvent();
                }

                return this.rowsInserted;
            }
        }

        private ComponentDirectEvent rowUpdated;

        /// <summary>
        /// Internal UI Event. Fired after a row has been updated.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GridView))]
        [ListenerArgument(1, "rowIndex")]
        [ListenerArgument(2, "record")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("rowupdated", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Internal UI Event. Fired after a row has been updated.")]
        public virtual ComponentDirectEvent RowUpdated
        {
            get
            {
                if (this.rowUpdated == null)
                {
                    this.rowUpdated = new ComponentDirectEvent();
                }

                return this.rowUpdated;
            }
        }
    }
}