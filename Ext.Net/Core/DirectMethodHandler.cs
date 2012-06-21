/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class DirectMethodHandler : IHttpHandler
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool IsReusable
        {
            get { return true; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected static bool IsDebugging
        {
            get
            {
                bool result = false;

                if (HttpContext.Current != null)
                {
                    result = HttpContext.Current.IsDebuggingEnabled;
                }

                return result;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void ProcessRequest(HttpContext context)
        {
            DirectResponse responseObject = new DirectResponse(true);

            try
            {
                HandlerMethods handler = HandlerMethods.GetHandlerMethods(context, context.Request.FilePath);
                string methodName = HandlerMethods.GetMethodName(context);

                if (handler == null)
                {
                    throw new Exception("The Method '{0}' has not been defined.".FormatWith(context.Request.FilePath));
                }

                if (methodName.IsEmpty())
                {
                    throw new Exception("No methodName has been set in the configuration.");
                }

                DirectMethod directMethod = handler.GetStaticMethod(methodName);

                if (directMethod == null)
                {
                    throw new Exception("The static DirectMethod '{0}' has not been defined.".FormatWith(methodName));
                }

                responseObject.Result = directMethod.Invoke();
            }
            catch (Exception e)
            {
                if (HandlerMethods.RethrowException(context))
                {
                    throw e;
                }

                responseObject.Success = false;
                responseObject.ErrorMessage = IsDebugging ? e.ToString() : e.Message; 
            }

            context.Response.Cache.SetNoServerCaching();
            context.Response.Cache.SetMaxAge(TimeSpan.Zero);
            context.Response.Write(responseObject.ToString());
            context.Response.End();
        }
    }
}