/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class StoreNotFoundException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public StoreNotFoundException() : base("A store is required. Please define a store for this control") { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public StoreNotFoundException(string message) 
            : base(message) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public StoreNotFoundException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
