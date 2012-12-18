/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.IO;
using System.Text;
using System.Web;
using System;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class InitScriptFilter : BaseFilter
    {
        private readonly Stream response;
        private readonly StringBuilder html;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public InitScriptFilter(Stream stream)
        {
            this.response = stream;
            this.html = new StringBuilder();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void Write(byte[] buffer, int offset, int count)
        {
            this.html.Append(HttpContext.Current.Response.ContentEncoding.GetString(buffer, offset, count));
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void Flush()
        {
            if (this.html.Length == 0)
            {
                this.response.Flush();
                return;  
            }

            this.Transform();       
            
            byte[] data = Encoding.UTF8.GetBytes(this.html.ToString());
            this.response.Write(data, 0, data.Length);
            this.response.Flush();
        }
        
        /// <summary>
        /// 
        /// </summary>
        protected virtual void Transform()
        {
            string h = ExtNetTransformer.Transform(this.html.ToString());
            this.html.Remove(0, this.html.Length);
            this.html.Append(h);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanRead
        {
            get { return true; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanSeek
        {
            get { return true; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanWrite
        {
            get { return true; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void Close()
        {
            this.response.Close();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override long Length
        {
            get { return 0; }
        }

        private long position;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override long Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override long Seek(long offset, SeekOrigin origin)
        {
            return this.response.Seek(offset, origin);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void SetLength(long length)
        {
            this.response.SetLength(length);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override int Read(byte[] buffer, int offset, int count)
        {
            return this.response.Read(buffer, offset, count);
        }
    }
}