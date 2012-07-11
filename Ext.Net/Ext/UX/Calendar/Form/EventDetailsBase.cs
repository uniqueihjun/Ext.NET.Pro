/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System.ComponentModel;
using System.Web.UI;
using Ext.Net.Utilities;
using System;
using System.Globalization;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public abstract partial class EventDetailsBase : FormPanelBase
    {
        /// <summary>
        /// 
        /// </summary>
        protected internal CalendarPanelBase CalendarPanel
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

            if (this.CalendarStoreID.IsEmpty() && this.CalendarPanel != null)
            {
                this.CalendarStoreID = this.CalendarPanel.CalendarStoreID;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DirectEventUpdate(MethodName = "SetTitle")]
        [ConfigOption]
        [Category("7. EventDetails")]
        [DefaultValue("Event Form")]
        [Localizable(true)]
        [NotifyParentProperty(true)]
        [Description("")]
        public override string Title
        {
            get
            {
                return (string)this.ViewState["Title"] ?? "Event Form";
            }
            set
            {
                this.ViewState["Title"] = value;
            }
        }

        /// <summary>
        /// The title during event adding
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. EventDetails")]
        [DefaultValue("Add Event")]
        [NotifyParentProperty(true)]
        [Description("The title during event adding")]
        public virtual string TitleTextAdd
        {
            get
            {
                return (string)this.ViewState["TitleTextAdd"] ?? "Add Event";
            }
            set
            {
                this.ViewState["TitleTextAdd"] = value;
            }
        }

        /// <summary>
        /// The title during event editing
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. EventDetails")]
        [DefaultValue("Edit Event")]
        [NotifyParentProperty(true)]
        [Description("The title during event editing")]
        public virtual string TitleTextEdit
        {
            get
            {
                return (string)this.ViewState["TitleTextEdit"] ?? "Edit Event";
            }
            set
            {
                this.ViewState["TitleTextEdit"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.ToLower)]
        [Category("7. EventDetails")]
        [DefaultValue(Alignment.Center)]
        [NotifyParentProperty(true)]
        public override Alignment ButtonAlign
        {
            get
            {
                object obj = this.ViewState["ButtonAlign"];
                return (obj == null) ? Alignment.Center : (Alignment)obj;
            }
            set
            {
                this.ViewState["ButtonAlign"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. EventDetails")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        public override bool AutoHeight
        {
            get
            {
                object obj = this.ViewState["AutoHeight"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["AutoHeight"] = value;
            }
        }

        /// <summary>
        /// The calendar store ID to use.
        /// </summary>
        [Meta]
        [ConfigOption("calendarStore", JsonMode.ToClientID)]
        [Category("7. EventDetails")]
        [DefaultValue("")]
        [IDReferenceProperty(typeof(Store))]
        [Description("The calendar store ID to use.")]
        public virtual string CalendarStoreID
        {
            get
            {
                return (string)this.ViewState["CalendarStoreID"] ?? "";
            }
            set
            {
                this.ViewState["CalendarStoreID"] = value;
            }
        }
    }
}