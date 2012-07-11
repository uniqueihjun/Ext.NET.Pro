/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Text;

using Ext.Net.Utilities;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class StoreResponseData
    {
        private string data;
        private int count;
        private ConfirmationList confirmation;

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
        public ConfirmationList Confirmation
        {
            get { return confirmation; }
            set { confirmation = value; }
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
            if (this.Data.IsEmpty() && (this.Confirmation == null || this.Confirmation.Count==0))
            {
                return null;
            }
            
            StringBuilder sb = new StringBuilder();
            sb.Append("{");

            if (this.Data.IsNotEmpty())
            {
                sb.AppendFormat("data:{0}, total: {1},", this.Data, this.Total);
            }
            
            string returnConfirmation = "";

            if (this.Confirmation != null && this.Confirmation.Count>0)
            {
                returnConfirmation = this.Confirmation.ToJson();
            }

            if (returnConfirmation.IsNotEmpty())
            {
                sb.AppendFormat("confirm:{0}", returnConfirmation);
            }
            else
            {
                sb.Remove(sb.Length - 1, 1);
            }

            sb.Append("}");

            return sb.ToString();
        }
    }
}
