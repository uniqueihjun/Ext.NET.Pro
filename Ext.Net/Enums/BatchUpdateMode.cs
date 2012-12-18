/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net
{
    /// <summary>
    /// Updating behavior based on batch synchronization
    /// </summary>
    public enum BatchUpdateMode
    {
        /// <summary>
        /// 'Complete' waits until the entire batch has been completed before updating the Store's data.
        /// 'Complete' is a good choice for local storage proxies
        /// </summary>
        Complete,
        /// <summary>
        /// 'Operation' (the default) will update the Store's internal representation of the data after each operation of the batch has completed, 
        /// 'Operation' is better for remote proxies, where there is a comparatively high latency 
        /// </summary>
        Operation
    }
}
