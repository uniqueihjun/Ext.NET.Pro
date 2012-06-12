/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web;
using Ext.Net.Utilities;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public class RemoteRenameEventArgs : RemoteActionEventArgs
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public RemoteRenameEventArgs(string serviceParams, ParameterCollection extraParams) : base(serviceParams, extraParams)
        {
        }

        private string newText;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string NewText
        {
            get
            {
                if (this.newText != null)
                {
                    return this.newText;
                }
                string s = this.GetValue<string>("newText");
                return s.IsEmpty() ? s : HttpUtility.HtmlDecode(s);
            }
            set
            {
                this.newText = value;
                ResourceManager.ExtraParamsResponse["ra_newText"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string OldText
        {
            get
            {
                string s = this.GetValue<string>("oldText");
                return s.IsEmpty() ? s : HttpUtility.HtmlDecode(s);
            }
        }
    }
}