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
    public partial class EventStore : Store
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
        
        /// <summary>
        /// 
        /// </summary>
        //public override bool IsDefault
        //{
        //    get
        //    {
        //        return this.Events.Count == 0 && this.Proxy.Count == 0;
        //    }
        //}

        protected override void OnInit(System.EventArgs e)
        {
            base.OnInit(e);
            this.EnsureReader();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

            if (this.AutoLoad)
            {
                this.AutoLoad = false;
                this.CustomConfig.Add(new ConfigItem("deferLoad", "true", ParameterMode.Raw));
            }

            if (this.StandardFields)
            {
                this.AddStandardFields();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void EnsureReader()
        {
            if (this.Reader.Count == 0)
            {
                this.Reader.Add(new JsonReader { IDProperty = "EventId" });
            }
        }

        /// <summary>
        /// The default date format string which can be overriden for localization support. The format must be valid according to Date.parseDate (defaults to 'd').
        /// </summary>
        [Meta]
        [Category("3. EventStore")]
        [DefaultValue(null)]
        [Description("The default date format string which can be overriden for localization support. The format must be valid according to Date.parseDate (defaults to 'd').")]
        public virtual string DateFormat
        {
            get
            {
                return (string)this.ViewState["DateFormat"] ?? null;
            }
            set
            {
                this.ViewState["DateFormat"] = value;
            }
        }

        protected override string GetAjaxDataJson()
        {
            if (this.Proxy.Count == 0 && this.Events.Count > 0)
            {
                return JSON.Serialize(this.Events);
            }

            return base.GetAjaxDataJson();
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("proxy", JsonMode.Raw)]
        [DefaultValue("")]
        [Description("")]
        protected override string MemoryProxy
        {
            get
            {
                if (this.Proxy.Count == 0 && this.Events.Count > 0)
                {
                    string template = "new Ext.data.PagingMemoryProxy({0}, false)";
                    return string.Format(template, JSON.Serialize(this.Events));
                }

                return base.MemoryProxy;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddStandardFields()
        {
            this.EnsureReader();
            this.Reader[0].Fields.Add(new RecordField { Name = "EventId", Type = RecordFieldType.Int });
            this.Reader[0].Fields.Add(new RecordField { Name = "CalendarId", Type = RecordFieldType.Int });
            this.Reader[0].Fields.Add(new RecordField { Name = "Title", Type = RecordFieldType.String });
            this.Reader[0].Fields.Add(new RecordField { Name = "StartDate", Type = RecordFieldType.Date, DateFormat = this.DateFormat });
            this.Reader[0].Fields.Add(new RecordField { Name = "EndDate", Type = RecordFieldType.Date, DateFormat = this.DateFormat });
            this.Reader[0].Fields.Add(new RecordField { Name = "Location", Type = RecordFieldType.String });
            this.Reader[0].Fields.Add(new RecordField { Name = "Notes", Type = RecordFieldType.String });
            this.Reader[0].Fields.Add(new RecordField { Name = "Url", Type = RecordFieldType.String });
            this.Reader[0].Fields.Add(new RecordField { Name = "IsAllDay", Type = RecordFieldType.Boolean });
            this.Reader[0].Fields.Add(new RecordField { Name = "Reminder", Type = RecordFieldType.String });
            this.Reader[0].Fields.Add(new RecordField { Name = "IsNew", Type = RecordFieldType.Boolean });
            this.StandardFields = false;
        }

        private EventCollection events;

        /// <summary>
        /// 
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]        
        public virtual EventCollection Events
        {
            get
            {
                if (this.events == null)
                {
                    this.events = new EventCollection();
                }

                return this.events;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool standardFields = true;

        public virtual bool StandardFields
        {
            get
            {
                return this.standardFields;
            }
            set
            {
                this.standardFields = value;
            }
        }
    }    
}