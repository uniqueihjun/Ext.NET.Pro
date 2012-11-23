/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Reflection;
using System.Threading;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ViewStateProxy : StateManagedItem
    {
        private readonly XControl control;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ViewStateProxy(XControl control, StateBag viewState)
        {
            this.control = control;
            this.ViewState = viewState;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual bool Suspend()
        {
            bool oldValue = control.AllowCallbackScriptMonitoring;
            this.control.AllowCallbackScriptMonitoring = false;
            Monitor.Enter(this.control);

            return oldValue;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual void Resume(bool oldValue)
        {
            this.control.AllowCallbackScriptMonitoring = oldValue;
            Monitor.Exit(this.control);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual void Resume()
        {
            this.Resume(true);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public object this[string key]
        {
            get
            {
                return this.ViewState[key];
            }
            set
            {
                this.ViewState[key] = value;

                if ((control.GenerateMethodsCalling) || (RequestManager.IsAjaxRequest && (control.AllowCallbackScriptMonitoring && (!control.IsDynamic || control.IsProxy))))
                {
                    PropertyInfo pi = control.GetType().GetProperty(key);

                    if (pi == null)
                    {
                        return;
                    }

                    object[] attrs = pi.GetCustomAttributes(typeof(DirectEventUpdateAttribute), true);

                    if (attrs.Length > 0)
                    {
                        this.control.CallbackValues[key] = value;

                        if (value is Icon)
                        {
                            if (this.ResourceManager != null)
                            {
                                this.ResourceManager.RegisterIcon((Icon)value);
                            }
                            else
                            {
                                this.control.AddScript("Ext.net.ResourceMgr.registerIcon({0});", JSON.Serialize(value));
                            }
                        }

                        ((DirectEventUpdateAttribute)attrs[0]).RegisterScript(this.control, pi); 
                    }
                    else
                    {
                        ConfigOptionAttribute attr = ClientConfig.GetClientConfigAttribute(pi);
                        if (attr != null)
                        {
                            this.control.CallbackValues[key] = value;
                            this.control.AddScript(string.Format(DirectEventUpdateAttribute.AutoGenerateFormat, this.control.ClientID, JSON.Serialize(value), pi.Name.ToLowerCamelCase()));
                        }
                    }
                }
            }
        }
    }
}