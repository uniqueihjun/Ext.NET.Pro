/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public enum JsonMode
    {
        /// <summary>
        /// 
        /// </summary>
        Array,

        /// <summary>
        /// 
        /// </summary>
        AlwaysArray,

        /// <summary>
        /// 
        /// </summary>
        ArrayToObject,

        /// <summary>
        /// 
        /// </summary>
        Custom,

        /// <summary>
        /// 
        /// </summary>
        Ignore,

        /// <summary>
        /// 
        /// </summary>
        Object,

        /// <summary>
        /// 
        /// </summary>
        ObjectAllowEmpty,

        /// <summary>
        /// 
        /// </summary>
        Raw,

        /// <summary>
        /// 
        /// </summary>
        ToLower,

        /// <summary>
        /// 
        /// </summary>
        ToCamelLower,

        /// <summary>
        /// 
        /// </summary>
        UnrollCollection,

        /// <summary>
        /// 
        /// </summary>
        UnrollObject,

        /// <summary>
        /// 
        /// </summary>
        Value,

        /// <summary>
        /// 
        /// </summary>
        ToString,

        /// <summary>
        /// 
        /// </summary>
        ToClientID,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        Serialize
    }
}