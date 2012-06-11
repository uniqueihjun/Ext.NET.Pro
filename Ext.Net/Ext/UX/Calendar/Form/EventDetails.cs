/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A custom form used for detailed editing of events.
    /// This is pretty much a standard form that is simply pre-configured for the options needed by the calendar components. It is also configured to automatically bind records of type Extensible.calendar.data.EventModel to and from the form.
    /// This form also provides custom events specific to the calendar so that other calendar components can be easily notified when an event has been edited via this component.
    /// </summary>
    [Meta]
    public partial class EventDetails : EventDetailsBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public EventDetails() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.calendar.form.EventDetails";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "eventeditform";
            }
        }

        private EventDetailsListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Client-side JavaScript Event Handlers")]
        public EventDetailsListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new EventDetailsListeners();
                }

                return this.listeners;
            }
        }

        private EventDetailsDirectEvents directEvents;

        /// <summary>
        /// Server-side Ajax Event Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [Description("Server-side Ajax Event Handlers")]
        public EventDetailsDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new EventDetailsDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}