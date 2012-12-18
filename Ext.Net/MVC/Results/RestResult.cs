/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web.Mvc;

namespace Ext.Net.MVC
{
    /// <summary>
    /// 
    /// </summary>
    public class RestResult : ActionResult
    {
        private bool success;
        private string msg;
        private object data;

        /// <summary>
        /// 
        /// </summary>
        public bool Success
        {
            get { return success; }
            set { success = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Message
        {
            get { return msg; }
            set { msg = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public object Data
        {
            get { return data; }
            set { data = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void ExecuteResult(ControllerContext context)
        {
            Response response = new Response(true);
            response.Success = this.Success;
            response.Message = this.Message;
            response.Data = JSON.Serialize(this.Data);

            response.Return();
        }
    }
}
