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
    public partial class ColumnDirectEvents : AbstractComponentDirectEvents
    {
        public ColumnDirectEvents() { }

        public ColumnDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent columnMoved;

        /// <summary>
        /// Fires when a column is moved.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Column), "ColumnModel")]
        [ListenerArgument(1, "oldIndex", typeof(int), "Old index")]
        [ListenerArgument(2, "newIndex", typeof(int), "New index")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("columnmoved", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a column is moved.")]
        public virtual ComponentDirectEvent ColumnMoved 
        {
            get
            {
                if (this.columnMoved == null)
                {
                    this.columnMoved = new ComponentDirectEvent(this);
                }

                return this.columnMoved;
            }
        }

        private ComponentDirectEvent configChanged;

        /// <summary>
        /// Fires when the configuration is changed
        /// </summary>
        [ListenerArgument(0, "item", typeof(Column), "ColumnModel")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("configchanged", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the configuration is changed.")]
        public virtual ComponentDirectEvent ConfigChanged
        {
            get
            {
                if (this.configChanged == null)
                {
                    this.configChanged = new ComponentDirectEvent(this);
                }

                return this.configChanged;
            }
        }

        private ComponentDirectEvent headerChange;

        /// <summary>
        /// Fires when the text of a header changes.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Column), "ColumnModel")]
        [ListenerArgument(1, "columnIndex", typeof(int), "The column index")]
        [ListenerArgument(2, "newText", typeof(string), "The new header text")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("headerchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the text of a header changes.")]
        public virtual ComponentDirectEvent HeaderChange
        {
            get
            {
                if (this.headerChange == null)
                {
                    this.headerChange = new ComponentDirectEvent(this);
                }

                return this.headerChange;
            }
        }

        private ComponentDirectEvent hiddenChange;

        /// <summary>
        /// Fires when a column is hidden or "unhidden".
        /// </summary>
        [ListenerArgument(0, "item", typeof(Column), "ColumnModel")]
        [ListenerArgument(1, "columnIndex", typeof(int), "The column index")]
        [ListenerArgument(2, "hidden", typeof(bool), "true if hidden, false otherwise")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("hiddenchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a column is hidden or 'unhidden'.")]
        public virtual ComponentDirectEvent HiddenChange
        {
            get
            {
                if (this.hiddenChange == null)
                {
                    this.hiddenChange = new ComponentDirectEvent(this);
                }

                return this.hiddenChange;
            }
        }

        private ComponentDirectEvent widthChange;

        /// <summary>
        /// Fires when the width of a column is programmaticially changed using setColumnWidth. Note internal resizing suppresses the event from firing. 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Column), "ColumnModel")]
        [ListenerArgument(1, "columnIndex", typeof(int), "The column index")]
        [ListenerArgument(2, "newWidth", typeof(int), "The new width")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("widthchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the width of a column is programmaticially changed using setColumnWidth. Note internal resizing suppresses the event from firing. ")]
        public virtual ComponentDirectEvent WidthChange
        {
            get
            {
                if (this.widthChange == null)
                {
                    this.widthChange = new ComponentDirectEvent(this);
                }

                return this.widthChange;
            }
        }
    }
}