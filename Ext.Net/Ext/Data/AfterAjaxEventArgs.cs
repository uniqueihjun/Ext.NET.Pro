/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class AfterDirectEventArgs : EventArgs
    {
        private Response ajaxResponse;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterDirectEventArgs() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterDirectEventArgs(Response ajaxResponse)
        {
            this.ajaxResponse = ajaxResponse;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Response Response
        {
            get
            {
                if (ajaxResponse == null)
                {
                    ajaxResponse = new Response(true);
                }

                return ajaxResponse;
            }
        }
    }
}