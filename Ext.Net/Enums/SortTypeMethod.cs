/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net
{
    /// <summary>
    /// Sort types
    /// </summary>
    public enum SortTypeMethod
    {
        /// <summary>
        /// Default sort that does nothing
        /// </summary>
        None,

        /// <summary>
        /// Date sorting
        /// </summary>
        AsDate,

        /// <summary>
        /// Float sorting
        /// </summary>
        AsFloat,

        /// <summary>
        /// Integer sorting
        /// </summary>
        AsInt,

        /// <summary>
        /// Strips all HTML tags to sort on text only
        /// </summary>
        AsText,

        /// <summary>
        /// Case insensitive string
        /// </summary>
        AsUCString,

        /// <summary>
        /// Strips all HTML tags to sort on text only - Case insensitive
        /// </summary>
        AsUCText
    }
}