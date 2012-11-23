/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class AfterStoreChangedEventArgs : EventArgs
    {
        private readonly StoreAction action;
        private bool success;
        private Exception exception;
        private bool exceptionHandled;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterStoreChangedEventArgs(string action, bool success, Exception exception, List<object> responseRecords)
        {
            this.action = Store.Action(action);
            this.exception = exception;
            this.success = success;
            this.responseRecords = responseRecords;
        }

        List<object> responseRecords;
        /// <summary>
        /// 
        /// </summary>
        public List<object> ResponseRecords
        {
            get
            {
                return this.responseRecords;
            }
        }

        /// <summary>
	    /// 
	    /// </summary>
        public StoreAction Action
	    {
	        get
	        {
	            return action;
	        }
	    }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Success
        {
            get { return success; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Exception Exception
        {
            get { return exception; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool ExceptionHandled
        {
            get { return exceptionHandled; }
            set { exceptionHandled = value; }
        }
    }
}