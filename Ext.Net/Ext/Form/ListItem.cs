/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class ListItem : StateManagedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public ListItem() { }

        private XControl parent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        [Description("")]
        public ListItem(string text)
        {
            this.Text = text;
            this.Value = text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        [Description("")]
        public ListItem(string text, string value)
        {
            this.Value = value;
            this.Text = text;
        }
        
        internal ListItem(XControl parent)
        {
            this.parent = parent;
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public string Text
        {
            get
            {
                return (string)this.ViewState["Text"] ?? "";
            }
            set
            {
                string oldValue = this.Text;
                this.ViewState["Text"] = value;

                if (this.Value == null || (!this.Value.IsEmpty() && oldValue == this.Value))
                {
                    this.Value = value;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Description("")]
        public string Value
        {
            get
            {
                return (string)this.ViewState["Value"] ?? null;
            }
            set
            {
                this.ViewState["Value"] = value;
                this.SetValue(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        [Description("")]
        protected void SetValue(string value)
        {
            if (parent != null && parent.AllowCallbackScriptMonitoring && RequestManager.IsAjaxRequest)
            {
                parent.Call("setValue", value);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Description("")]
    public partial class ListItemCollection<T> : StateManagedCollection<T> where T : StateManagedItem { }
}
