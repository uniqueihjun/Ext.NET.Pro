/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// This is an calendar store that enables the events to have different colors based on CalendarId.
    /// </summary>
    public partial class GroupStore : Store
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
        public override bool IsDefault
        {
            get
            {
                return this.Groups.Count == 0 && this.Proxy.Count == 0;
            }
        }

        protected override void OnInit(System.EventArgs e)
        {
            base.OnInit(e);
            this.EnsureReader();
        }

        protected override string GetAjaxDataJson()
        {
            if (this.Proxy.Count == 0 && this.Groups.Count > 0)
            {
                return JSON.Serialize(this.Groups);
            }

            return base.GetAjaxDataJson();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

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
                this.Reader.Add(new JsonReader { IDProperty = "CalendarId" });
            }
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
                if (this.Proxy.Count == 0 && this.Groups.Count > 0)
                {
                    string template = "new Ext.data.PagingMemoryProxy({0}, false)";
                    return string.Format(template, JSON.Serialize(this.Groups));
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
            this.Reader[0].Fields.Add(new RecordField { Name = "CalendarId", Type = RecordFieldType.Int });
            this.Reader[0].Fields.Add(new RecordField { Name = "Title", Type = RecordFieldType.String });
            //this.Reader[0].Fields.Add(new RecordField { Name = "Color", Type = RecordFieldType.String });
            this.StandardFields = false;
        }

        private GroupCollection groups;

        /// <summary>
        /// 
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]        
        [Description("")]        
        public virtual GroupCollection Groups
        {
            get
            {
                if (this.groups == null)
                {
                    this.groups = new GroupCollection();
                }

                return this.groups;
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