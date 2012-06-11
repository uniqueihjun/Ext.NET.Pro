/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

using Ext.Net.Utilities;
using Newtonsoft.Json.Linq;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class StoreReadDataEventArgs : EventArgs
    {
        private readonly JToken parameters;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreReadDataEventArgs() { }

        internal StoreReadDataEventArgs(JToken parameters)
        {
            this.parameters = parameters;
        }

        private int total = -1;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int Total
        {
           get
           {
               return total;
           }
            set
            {
                total = value;
            }
        }

        private ParameterCollection p;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ParameterCollection Parameters
        {
            get
            {
                if (p != null)
                {
                    return p;
                }

                if (this.parameters == null)
                {
                    return new ParameterCollection();
                }

                p = ResourceManager.JTokenToParams(this.parameters);

                return p;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Page
        {
            get
            {
                if (this.Parameters["page"].IsNotEmpty())
                {
                    return int.Parse(this.Parameters["page"]);
                }

                return -1;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int Start
        {
            get
            {
                if (this.Parameters["start"].IsNotEmpty())
                {
                    return int.Parse(this.Parameters["start"]);
                }

                return -1;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int Limit
        {
            get
            {
                if (this.Parameters["limit"].IsNotEmpty())
                {
                    return int.Parse(this.Parameters["limit"]);
                }

                return -1;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DataSorter[] Sort
        {
            get
            {
                if (this.Parameters["sort"].IsNotEmpty())
                {
                    return JSON.Deserialize<DataSorter[]>(this.Parameters["sort"], new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver());
                }

                return new DataSorter[0];
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DataFilter[] Filter
        {
            get
            {
                if (this.Parameters["filter"].IsNotEmpty())
                {
                    return JSON.Deserialize<DataFilter[]>(this.Parameters["filter"], new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver());
                }

                return new DataFilter[0];
            }
        }
    }
}
