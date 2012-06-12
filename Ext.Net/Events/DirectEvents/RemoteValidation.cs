/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using System.Web;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RemoteValidationDirectEvent : ObservableDirectEvent
    {
        /// <summary>
        /// Number of milliseconds to wait before the validation request is sent to server
        /// </summary>
        [ConfigOption]
        [NotifyParentProperty(true)]
        [DefaultValue(500)]
        [Description("Number of milliseconds to wait before the validation request is sent to server")]
        public int ValidationBuffer
        {
            get
            {
                object obj = this.ViewState["ValidationBuffer"];
                return obj == null ? 500 : (int)obj;
            }
            set
            {
                this.ViewState["ValidationBuffer"] = value;
            }
        }

        /// <summary>
        /// False to disable loading indicator
        /// </summary>
        [ConfigOption]
        [NotifyParentProperty(true)]
        [DefaultValue(true)]
        [Description("False to disable loading indicator")]
        public bool ShowBusy
        {
            get
            {
                object obj = this.ViewState["ShowBusy"];
                return obj == null ? true : (bool)obj;
            }
            set
            {
                this.ViewState["ShowBusy"] = value;
            }
        }

        /// <summary>
        /// Loading indicator tooltip
        /// </summary>
        [ConfigOption]
        [NotifyParentProperty(true)]
        [DefaultValue("Validating...")]
        [Description("Loading indicator tooltip")]
        public string BusyTip
        {
            get
            {
                object obj = this.ViewState["BusyTip"];
                return obj == null ? "Validating..." : (string)obj;
            }
            set
            {
                this.ViewState["BusyTip"] = value;
            }
        }

        /// <summary>
        /// The default Icon applied to the loading indicator.
        /// </summary>
        [DefaultValue(Icon.None)]
        [Description("The default Icon applied to loading indicator.")]
        public virtual Icon BusyIcon
        {
            get
            {
                object obj = this.ViewState["BusyIcon"];
                return (obj == null) ? Icon.None : (Icon)obj;
            }
            set
            {
                this.ViewState["BusyIcon"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("busyIconCls")]
        [DefaultValue("")]
        [Description("")]
        protected virtual string BusyIconClsProxy
        {
            get
            {
                if (this.BusyIcon != Icon.None)
                {
                    ResourceManager.GetInstance(HttpContext.Current).RegisterIcon(this.BusyIcon);
                    return ResourceManager.GetIconClassName(this.BusyIcon);
                }

                return (!this.BusyIconCls.Equals("loading-indicator")) ? this.BusyIconCls : "";
            }
        }

        /// <summary>
        /// The default iconCls applied to the loading indicator.
        /// </summary>
        [ConfigOption]
        [DefaultValue("loading-indicator")]
        [NotifyParentProperty(true)]
        [Description("The default iconCls applied to the loading indicator.")]
        public virtual string BusyIconCls
        {
            get
            {
                return (string)this.ViewState["BusyIconCls"] ?? "loading-indicator";
            }
            set
            {
                this.ViewState["BusyIconCls"] = value;
            }
        }

        /// <summary>
        /// Name of the event that triggers the validation
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [NotifyParentProperty(true)]
        [DefaultValue("keyup")]
        [Description("Name of the event that triggers the validation")]
        public string ValidationEvent
        {
            get
            {
                object obj = this.ViewState["ValidationEvent"];
                return obj == null ? "keyup" : (string)obj;
            }
            set
            {
                this.ViewState["ValidationEvent"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [DefaultValue(ValidationEventOwner.Element)]
        [NotifyParentProperty(true)]
        [Description("")]
        public ValidationEventOwner EventOwner
        {
            get
            {
                object obj = this.ViewState["EventOwner"];
                return obj != null ? (ValidationEventOwner)obj : ValidationEventOwner.Element;
            }
            set
            {
                this.ViewState["EventOwner"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [DefaultValue(InitValueValidation.Valid)]
        [NotifyParentProperty(true)]
        [Description("")]
        public InitValueValidation InitValueValidation
        {
            get
            {
                object obj = this.ViewState["InitValueValidation"];
                return obj != null ? (InitValueValidation)obj : InitValueValidation.Valid;
            }
            set
            {
                this.ViewState["InitValueValidation"] = value;
            }
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public delegate void RemoteValidationEventHandler(object sender, RemoteValidationEventArgs e);

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected event RemoteValidationEventHandler Handler;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public event RemoteValidationEventHandler Validation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.Handler = (RemoteValidationEventHandler)System.Delegate.Combine(this.Handler, value);
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.Handler = (RemoteValidationEventHandler)System.Delegate.Remove(this.Handler, value);
            }
        }

        internal virtual void OnValidation(RemoteValidationEventArgs e)
        {
            if (this.Handler != null)
            {
                this.Handler(this.Owner, e);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class RemoteValidationEventArgs : DirectEventArgs
    {
        private JObject serviceParams;

        public RemoteValidationEventArgs(string serviceParams, ParameterCollection extraParams) : base(extraParams)
        {
            this.serviceParams = JObject.Parse(serviceParams);
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected JObject ServiceParams
        {
            get
            {
                return this.serviceParams;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected T GetValue<T>(string name)
        {
            if (this.ServiceParams == null)
            {
                return default(T);
            }

            JProperty p = this.ServiceParams.Property(name);

            if (p == null || p.Value == null)
            {
                return default(T);
            }
            return p.Value.Value<T>();
        }
        
        /// <summary>
        /// 
        /// </summary>
        public override bool Success
        {
            get;set;
        }

        /// <summary>
        /// 
        /// </summary>
        public override string ErrorMessage
        {
            get;set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            get
            {
                return this.GetValue<string>("id");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return this.GetValue<string>("name");
            }
        }

        private object value;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public object Value
        {
            get
            {
                if (this.value != null)
                {
                    return this.value;
                }
             
                return this.GetValue<object>("value");
            }
            set
            {
                this.value = value;
            }
        }

        internal bool ValueIsChanged
        {
            get
            {
                return this.value != null;
            }
        }
    }
}