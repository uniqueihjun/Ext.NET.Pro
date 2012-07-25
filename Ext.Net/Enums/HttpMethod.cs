/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net
{
    /// <summary>
    /// List of HTTP methods (verbs), RFC 2616
    /// </summary>
    [ConfigOption(JsonMode.Value)]
    public enum HttpMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Default,

        /// <summary>
        /// 
        /// </summary>
        GET,

        /// <summary>
        /// 
        /// </summary>
        POST,

        /// <summary>
        /// 
        /// </summary>
        OPTIONS,

        /// <summary>
        /// 
        /// </summary>
        HEAD,

        /// <summary>
        /// 
        /// </summary>
        PUT,

        /// <summary>
        /// 
        /// </summary>
        DELETE,

        /// <summary>
        /// 
        /// </summary>
        TRACE,

        /// <summary>
        /// 
        /// </summary>
        CONNECT
    }
}