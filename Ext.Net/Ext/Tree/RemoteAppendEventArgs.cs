/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public class RemoteAppendEventArgs : RemoteActionEventArgs
    {
        private readonly bool insert;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public RemoteAppendEventArgs(bool insert, string serviceParams, ParameterCollection extraParams)
            : base(serviceParams, extraParams)
        {
            this.insert = insert;
        }

        private string id;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool IsInsert
        {
            get
            {
                return this.insert;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public new string NodeID
        {
            get
            {
                if (this.id != null)
                {
                    return this.id;
                }
                return this.GetValue<string>("id");
            }
            set
            {
                this.id = value;
                ResourceManager.ExtraParamsResponse["ra_id"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ParentNodeID
        {
            get
            {
                return this.GetValue<string>("parentId");
            }
        }

        private string text;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Text
        {
            get
            {
                if (this.text != null)
                {
                    return this.text;
                }
                string s = this.GetValue<string>("text");
                return s.IsEmpty() ? s : HttpUtility.HtmlDecode(s);
            }
            set
            {
                this.text = value;
                ResourceManager.ExtraParamsResponse["ra_text"] = value;
            }
        }
    }
}