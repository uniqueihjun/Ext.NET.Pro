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
    public partial class AfterStoreChangedEventArgs : EventArgs
    {
        private bool success;
        private Exception exception;
        private ConfirmationList confirmationList;
        private bool exceptionHandled;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterStoreChangedEventArgs(bool success, Exception exception, ConfirmationList confirmationList)
        {
            this.exception = exception;
            this.confirmationList = confirmationList;
            this.success = success;
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

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfirmationList ConfirmationList
        {
            get
            {
                return confirmationList;
            }
            internal set
            {
                confirmationList = value;
            }
        }
    }
}