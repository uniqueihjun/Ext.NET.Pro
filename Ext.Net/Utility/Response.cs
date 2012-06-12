/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class Response : ExtObject
    {
        private bool success;
        private string msg;
        private string data;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Response() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Response(bool success, string msg)
        {
            this.success = success;
            this.msg = msg;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Response(bool success)
        {
            this.success = success;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("success")]
        [Description("")]
        public bool Success
        {
            get { return success; }
            set { success = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("message")]
        [DefaultValue(null)]
		[Description("")]
        public string Message
        {
            get { return msg; }
            set { msg = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("data", JsonMode.Raw)]
        [DefaultValue(null)]
		[Description("")]
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Serialize()
        {
            return new ClientConfig().Serialize(this);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void Write()
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Write(this.Serialize());
            HttpContext.Current.Response.End();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual void Return()
        {
            CompressionUtils.GZipAndSend(this.Serialize());
        }
    }
}
