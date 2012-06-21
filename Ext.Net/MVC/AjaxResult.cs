/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web;
using System.Web.Mvc;

namespace Ext.Net.MVC
{
    /// <summary>
    /// 
    /// </summary>
    public class AjaxResult : ActionResult
    {
        /// <summary>
        /// 
        /// </summary>
        public AjaxResult() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="script"></param>
        public AjaxResult(string script)
        {
            this.Script = script;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        public AjaxResult(object result)
        {
            this.Result = result;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Script 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        public object Result 
        { 
            get; 
            set; 
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ErrorMessage 
        { 
            get; 
            set; 
        }
		
        /// <summary>
        /// 
        /// </summary>
        public bool IsUpload 
        { 
            get; 
            set; 
        }

        private ParameterCollection extraParamsResponse;
        /// <summary>
        /// 
        /// </summary>
        public ParameterCollection ExtraParamsResponse
        {
            get
            {
                if (this.extraParamsResponse == null)
                {
                    this.extraParamsResponse = new ParameterCollection();
                }

                return this.extraParamsResponse;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void ExecuteResult(ControllerContext context)
        {
            DirectResponse response = new DirectResponse();

            response.Result = this.Result;
			response.IsUpload = this.IsUpload;

            if (!string.IsNullOrEmpty(this.ErrorMessage))
            {
                response.Success = false;
                response.ErrorMessage = this.ErrorMessage;
            }
            else
            {                
                if (!string.IsNullOrEmpty(this.Script))
                {
                    response.Script = this.Script;
                }

                if (this.ExtraParamsResponse.Count > 0)
                {
                    response.ExtraParamsResponse = this.ExtraParamsResponse.ToJson();
                }
            }
            
            response.Return();
        }
    }

}
