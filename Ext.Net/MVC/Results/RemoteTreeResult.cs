/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Ext.Net.Utilities;

namespace Ext.Net.MVC
{
    public class RemoteTreeResult : ActionResult
    {
        private bool accept = true;

        public bool Accept
        {
            get
            {
                return this.accept;
            }
            set
            {
                this.accept = value;
            }
        }

        public string RefusalMessage
        {
            get;
            set;
        }

        public object Attributes
        {
            get;
            set;
        }

        public object Value
        {
            get;
            set;
        }

        public string NodeID
        {
            get;
            set;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            JObject result = new JObject();
            JObject response = new JObject();

            result["actionSuccess"] = this.Accept;
            
            if (this.RefusalMessage.IsNotEmpty())
            {
                result["message"] = this.RefusalMessage;
            }

            if (this.Attributes != null)
            {
                response["attributes"] = new JRaw(JSON.Serialize(this.Attributes));
            }

            if (this.Value != null)
            {
                if (this.Value is string) 
                {
                    response["value"] = this.Value.ToString();
                }
                else
                {
                    response["value"] = new JRaw(JSON.Serialize(this.Value));
                }
                
            }

            if (this.NodeID != null)
            {
                response["id"] = this.NodeID;
            }

            if (response.Count > 0)
            {
                result["response"] = response;
            }

            CompressionUtils.GZipAndSend(result.ToString(Newtonsoft.Json.Formatting.None));
        }
    }
}