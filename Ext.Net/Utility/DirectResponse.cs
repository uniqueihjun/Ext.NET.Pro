/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class DirectResponse : ExtObject
    {
        private bool success = true;
        private bool isUpload;
        private string error;
        private string script;
        private string viewState;
        private string viewStateEncrypted;
        private string eventValidation;
        private string serviceResponse;
        private string userResponse;
        private readonly bool internalUsing;
        private object result;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DirectResponse() { }

        internal DirectResponse(bool internalUsing)
        {
            this.internalUsing = internalUsing;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DirectResponse(string script)
        {
            this.Script = script;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="script"></param>
        /// <returns></returns>
        public static DirectResponse Create(string script)
        {
            return new DirectResponse(script);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            if (this.Script.IsNotEmpty() && !this.Script.StartsWith("<string>"))
            {
                this.Script = "<string>" + this.Script;
            }

            string serialize = new ClientConfig().Serialize(this);

            if (!this.internalUsing && (this.IsUpload || this.NativeUpload))
            {
                serialize = "<textarea>{0}</textarea>".FormatWith(serialize);
            }

            if (!this.internalUsing && HttpContext.Current != null && HttpContext.Current.CurrentHandler is Page)
            {
                HttpContext.Current.Items["Ext.Net.Direct.Response.Manual"] = true;

                return "<Ext.Net.Direct.Response.Manual>".ConcatWith(serialize, "</Ext.Net.Direct.Response.Manual>");
            }

            return serialize;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual void Return()
        {
            if (!this.IsUpload && !this.NativeUpload)
            {
                CompressionUtils.GZipAndSend(this);
            }
            else
            {
                HttpContext.Current.Response.ContentType = "text/html";
                HttpContext.Current.Response.Write(this.ToString());
            }
        }

        public virtual string JsonResponse()
        {
            return this.ToString();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected bool NativeUpload
        {
            get
            {
                return HttpContext.Current != null && RequestManager.HasInputFieldMarker(HttpContext.Current.Request);
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(true)]
		[Description("")]
        public bool Success
        {
            get 
            { 
                return this.success; 
            }
            set 
            { 
                this.success = value; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(true)]
        public bool IsUpload
        {
            get 
            { 
                return this.isUpload; 
            }
            set 
            { 
                this.isUpload = value; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(null)]
		[Description("")]
        public string ErrorMessage
        {
            get 
            { 
                return this.error; 
            }
            set 
            { 
                this.error = value; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(null)]
		[Description("")]
        public string Script
        {
            get 
            { 
                return this.script; 
            }
            set 
            { 
                this.script = value; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(null)]
		[Description("")]
        public string ViewState
        {
            get 
            { 
                return this.viewState; 
            }
            set 
            { 
                this.viewState = value; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(null)]
		[Description("")]
        public string ViewStateEncrypted
        {
            get 
            { 
                return this.viewStateEncrypted; 
            }
            set 
            { 
                this.viewStateEncrypted = value; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(null)]
		[Description("")]
        public string EventValidation
        {
            get 
            { 
                return this.eventValidation; 
            }
            set 
            { 
                this.eventValidation = value; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.Raw)]
        [DefaultValue(null)]
		[Description("")]
        public string ServiceResponse
        {
            get 
            { 
                return this.serviceResponse; 
            }
            set 
            { 
                this.serviceResponse = value; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.Raw)]
        [DefaultValue(null)]
		[Description("")]
        public string ExtraParamsResponse
        {
            get 
            { 
                return this.userResponse; 
            }
            set 
            { 
                this.userResponse = value; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        [Description("")]
        public object Result
        {
            get 
            { 
                return this.result; 
            }
            set 
            { 
                this.result = value; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("result", JsonMode.Raw)]
        [DefaultValue(null)]
		[Description("")]
        protected object ResultProxy
        {
            get
            {
                return this.Result != null ? JSON.Serialize(this.Result) : null;
            }
        }
    }
}