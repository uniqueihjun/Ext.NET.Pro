/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// This is the default container for calendar views. It supports day, week, multi-week and month views as well as a built-in event edit form. The only requirement for displaying a calendar is passing in a valid store config containing records of type EventRecord.
    /// </summary>
    [Meta] 
    [ToolboxData("<{0}:CalendarPanel runat=\"server\"></{0}:CalendarPanel>")]
    [Designer(typeof(EmptyDesigner))]
    [Description("This is the default container for calendar views. It supports day, week, multi-week and month views as well as a built-in event edit form. The only requirement for displaying a calendar is passing in a valid store config containing records of type EventRecord.")]
    public partial class CalendarPanel : CalendarPanelBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public CalendarPanel() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.calendar.CalendarPanel";
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
                return "calendarpanel";
            }
        }

        private CalendarPanelListeners listeners;

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
        public CalendarPanelListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new CalendarPanelListeners();
                }

                return this.listeners;
            }
        }

        private CalendarPanelDirectEvents directEvents;

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
        public CalendarPanelDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new CalendarPanelDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}