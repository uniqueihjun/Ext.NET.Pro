/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    public interface IStore
    {
        /// <summary>
        /// 
        /// </summary>
        string StoreID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        StoreCollection Store { get; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Store GetStore();
    }
}