/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Text;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class StoreResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        public StoreResponseData() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isTree"></param>
        public StoreResponseData(bool isTree) 
        {
            this.isTree = isTree;
        }

        private bool success = true;
        private string msg;
        private string data;
        private int count = -1;
        private bool isTree;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool Success
        {
            get { return success; }
            set { success = value; }
        }

        /// <summary>
        /// 
        /// </summary>        
        [Description("")]
        public string Message
        {
            get { return msg; }
            set { msg = value; }
        }

		/// <summary>
		/// 
		/// </summary>
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
        public int Total
        {
            get { return count; }
            set { count = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual void Return()
        {
            CompressionUtils.GZipAndSend(this);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            if (this.Data.IsEmpty() && this.Success && this.Message.IsEmpty())
            {
                return "";
            }
            
            StringBuilder sb = new StringBuilder();
            var comma = false;
            sb.Append("{");

            if (!this.Success)
            {
                sb.Append("success:false");
                comma = true;
            }

            if (!string.IsNullOrEmpty(this.Message))
            {
                if(comma){
                    sb.Append(",");
                }
                sb.AppendFormat("message:{0}", JSON.Serialize(this.Message));
                comma = true;
            }

            if (this.Data.IsNotEmpty() && this.Success)
            {
                if (comma)
                {
                    sb.Append(",");
                }

                if (this.Total >= 0)
                {
                    sb.AppendFormat("{2}:{0}, total: {1}", this.Data, this.Total, this.isTree ? "children" : "data");
                }
                else
                {
                    sb.AppendFormat("{1}:{0}", this.Data, this.isTree ? "children" : "data");
                }
            }

            sb.Append("}");

            return sb.ToString();
        }
    }
}
