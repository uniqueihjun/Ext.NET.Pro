/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

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
        public string NodeID
        {
            get
            {
                return this.GetValue<string>("id");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public ParameterCollection ExtraParamsResponse
        {
            get
            {
                return ResourceManager.ExtraParamsResponse;
            }
        }
    }
}