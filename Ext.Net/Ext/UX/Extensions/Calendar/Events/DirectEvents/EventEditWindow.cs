/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    public partial class EventEditWindowDirectEvents : WindowDirectEvents
    {
        /// <summary>
        /// 
        /// </summary>
        public override ConfigOptionsExtraction ConfigOptionsExtraction
        {
            get
            {
                return CalendarPanel.ConfigOptionsEngine;
            }
        }
        
        private ComponentDirectEvent eventAdd;

        /// <summary>
        /// Fires after a new event is added
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The new record that was added")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("eventadd", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after a new event is added")]
        public virtual ComponentDirectEvent EventAdd
        {
            get
            {
                if (this.eventAdd == null)
                {
                    this.eventAdd = new ComponentDirectEvent();
                }

                return this.eventAdd;
            }
        }

        private ComponentDirectEvent eventCancel;

        /// <summary>
        /// Fires after an event add/edit operation is canceled by the user and no store update took place
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The new record that was canceled")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("eventcancel", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after an event add/edit operation is canceled by the user and no store update took place")]
        public virtual ComponentDirectEvent EventCancel
        {
            get
            {
                if (this.eventCancel == null)
                {
                    this.eventCancel = new ComponentDirectEvent();
                }

                return this.eventCancel;
            }
        }

        private ComponentDirectEvent eventDelete;

        /// <summary>
        /// Fires after an event is deleted
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The new record that was deleted")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("eventdelete", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after an event is deleted")]
        public virtual ComponentDirectEvent EventDelete
        {
            get
            {
                if (this.eventDelete == null)
                {
                    this.eventDelete = new ComponentDirectEvent();
                }

                return this.eventDelete;
            }
        }

        private ComponentDirectEvent eventUpdate;

        /// <summary>
        /// Fires after an existing event is updated
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The new record that was updated")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("eventupdate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after an existing event is updated")]
        public virtual ComponentDirectEvent EventUpdate
        {
            get
            {
                if (this.eventUpdate == null)
                {
                    this.eventUpdate = new ComponentDirectEvent();
                }

                return this.eventUpdate;
            }
        }

        private ComponentDirectEvent editDetails;

        /// <summary>
        /// Fires when the user selects the option in this window to continue editing in the detailed edit form (by default, an instance of Ext.calendar.EventEditForm. Handling code should hide this window and transfer the current event record to the appropriate instance of the detailed form by showing it and calling loadRecord.
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The record that is currently being edited")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("editdetails", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the user selects the option in this window to continue editing in the detailed edit form (by default, an instance of Ext.calendar.EventEditForm. Handling code should hide this window and transfer the current event record to the appropriate instance of the detailed form by showing it and calling loadRecord.")]
        public virtual ComponentDirectEvent EditDetails
        {
            get
            {
                if (this.editDetails == null)
                {
                    this.editDetails = new ComponentDirectEvent();
                }

                return this.editDetails;
            }
        }
    }
}