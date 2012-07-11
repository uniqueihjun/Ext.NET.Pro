/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

using Newtonsoft.Json.Linq;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public class RemoteActionEventArgs : EventArgs
    {
        private readonly ParameterCollection extraParams;
        private JObject serviceParams;
        private bool accept;
        private string refusalMessage;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public RemoteActionEventArgs(string serviceParams, ParameterCollection extraParams)
        {
            this.serviceParams = JObject.Parse(serviceParams);
            this.extraParams = extraParams;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Accept
        {
            get
            {
                return this.accept;
            }
            set
            {
                this.accept = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string RefusalMessage
        {
            get
            {
                return this.refusalMessage;
            }
            set
            {
                this.refusalMessage = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ParameterCollection ExtraParams
        {
            get
            {
                return this.extraParams;
            }
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
		[Description("")]
        public virtual string NodeID
        {
            get
            {
                return this.GetValue<string>("id");
            }
        }

        private object attributes;

        /// <summary>
        /// 
        /// </summary>
        public object Attributes
        {
            get
            {
                return this.attributes;
            }
            set
            {
                this.attributes = value;

                var p = ResourceManager.ExtraParamsResponse.GetParameter("ra_applyObject");
                if (p == null)
                {
                    p = new Parameter("ra_applyObject", "{}", ParameterMode.Raw);
                    ResourceManager.ExtraParamsResponse.Add(p);
                }            

                if (value == null)
                {
                    ResourceManager.ExtraParamsResponse.Remove(p);
                    return;
                }
                
                ResourceManager.ExtraParamsResponse["ra_applyObject"] = value is string ? value.ToString() : JSON.Serialize(value, JSON.ScriptConvertersInternal);
            }
        }
    }
}