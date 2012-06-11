/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Text;
using System.Web.UI;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Defined {CRUD action}:{HTTP method} pairs to associate HTTP methods with the corresponding actions for RESTful proxies.
    /// </summary>
    public partial class RestActions : StateManagedItem, ICustomConfigSerialization
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue(HttpMethod.POST)]
        [NotifyParentProperty(true)]
        [Description("")]
        public HttpMethod Create
        {
            get
            {
                object obj = this.ViewState["Create"];
                return obj != null ? (HttpMethod)obj : HttpMethod.POST;
            }
            set
            {
                this.ViewState["Create"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue(HttpMethod.GET)]
        [NotifyParentProperty(true)]
        [Description("")]
        public HttpMethod Read
        {
            get
            {
                object obj = this.ViewState["Read"];
                return obj != null ? (HttpMethod)obj : HttpMethod.GET;
            }
            set
            {
                this.ViewState["Read"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue(HttpMethod.PUT)]
        [NotifyParentProperty(true)]
        [Description("")]
        public HttpMethod Update
        {
            get
            {
                object obj = this.ViewState["Update"];
                return obj != null ? (HttpMethod)obj : HttpMethod.PUT;
            }
            set
            {
                this.ViewState["Update"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue(HttpMethod.DELETE)]
        [NotifyParentProperty(true)]
        [Description("")]
        public HttpMethod Destroy
        {
            get
            {
                object obj = this.ViewState["Destroy"];
                return obj != null ? (HttpMethod)obj : HttpMethod.DELETE;
            }
            set
            {
                this.ViewState["Destroy"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool IsDefault
        {
            get
            {
                return this.Create == HttpMethod.POST &&
                       this.Read == HttpMethod.GET &&
                       this.Update == HttpMethod.PUT &&
                       this.Destroy == HttpMethod.DELETE;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ToScript(Control owner)
        {
            return "Ext.apply(Ext.data.Api.restActions, {0});".FormatWith(new ClientConfig().Serialize(this, true));
        }
    }
}