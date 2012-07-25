/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ext.Net.Utilities;
using System.Web;

namespace Ext.Net
{
    public partial class StoreRequestParameters
    {
        Dictionary<string, object> extraParams;

        public StoreRequestParameters(Dictionary<string, object> extraParams)
        {
            this.extraParams = extraParams;
        }

        public StoreRequestParameters(string extraParams)
        {
            this.extraParams = JSON.Deserialize<Dictionary<string, object>>(extraParams);
        }

        public StoreRequestParameters(HttpContext context)
        {            
            this.extraParams = new Dictionary<string,object>();
            this.extraParams["page"] = context.Request["page"];
            this.extraParams["start"] = context.Request["start"];
            this.extraParams["limit"] = context.Request["limit"];
            this.extraParams["sort"] = context.Request["sort"];
            this.extraParams["filter"] = context.Request["filter"];
        }

        /// <summary>
        /// 
        /// </summary>
        public int Page
        {
            get
            {                
                if (this.extraParams.ContainsKey("page") && this.extraParams["page"] != null)
                {
                    return Convert.ToInt32(this.extraParams["page"]);
                }

                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Start
        {
            get
            {
                if (this.extraParams.ContainsKey("start") && this.extraParams["start"] != null)
                {
                    return Convert.ToInt32(this.extraParams["start"]);
                }

                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Limit
        {
            get
            {
                if (this.extraParams.ContainsKey("limit") && this.extraParams["limit"] != null)
                {
                    return Convert.ToInt32(this.extraParams["limit"]);
                }

                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DataSorter[] Sort
        {
            get
            {
                if (this.extraParams.ContainsKey("sort") && this.extraParams["sort"] != null)
                {
                    return JSON.Deserialize<DataSorter[]>(this.extraParams["sort"].ToString(), new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver());
                }

                return new DataSorter[0];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DataFilter[] Filter
        {
            get
            {
                if (this.extraParams.ContainsKey("filter") && this.extraParams["filter"] != null)
                {
                    return JSON.Deserialize<DataFilter[]>(this.extraParams["filter"].ToString(), new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver());
                }

                return new DataFilter[0];
            }
        }
    }
}