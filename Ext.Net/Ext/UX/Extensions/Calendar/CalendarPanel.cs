/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// This is the default container for Ext calendar views. It supports day, week and month views as well as a built-in event edit form. The only requirement for displaying a calendar is passing in a valid calendarStore config containing records of type EventRecord. In order to make the calendar interactive (enable editing, drag/drop, etc.) you can handle any of the various events fired by the underlying views and exposed through the CalendarPanel.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:CalendarPanel runat=\"server\"></{0}:CalendarPanel>")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(CalendarPanel), "Build.ToolboxIcons.CalendarPanel.bmp")]
    [Description("This is the default container for Ext calendar views. It supports day, week and month views as well as a built-in event edit form. The only requirement for displaying a calendar is passing in a valid calendarStore config containing records of type EventRecord. In order to make the calendar interactive (enable editing, drag/drop, etc.) you can handle any of the various events fired by the underlying views and exposed through the CalendarPanel.")]
    public partial class CalendarPanel : CalendarPanelBase
    {
        internal const ConfigOptionsExtraction ConfigOptionsEngine = ConfigOptionsExtraction.List;

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
        [ViewStateMember]
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
        [ViewStateMember]
        [Description("Server-side Ajax Event Handlers")]
        public CalendarPanelDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new CalendarPanelDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}