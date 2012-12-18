/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class Paging<T>
    {
        private List<T> data;
        private int totalRecords;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Paging() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Paging(IEnumerable<T> data, int totalRecords)
        {
            this.data = new List<T>(data);
            this.totalRecords = totalRecords;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        [Newtonsoft.Json.JsonProperty("data")]
        public List<T> Data
        {
            get { return data; }
            set { data = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        [Newtonsoft.Json.JsonProperty("total")]
        public int TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        public string Serialize()
        {
            return JSON.Serialize(this);
        }

        public virtual object SerializationObject()
        {
            return new { data = this.Data, total = this.TotalRecords };
        }
    }
}