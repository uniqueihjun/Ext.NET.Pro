/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net
{
    /// <summary>
    /// The data type for conversion to displayable value
    /// </summary>
    public enum ModelFieldType
    {
        /// <summary>
        /// (Default, implies no conversion)
        /// </summary>
        Auto,
        
        /// <summary>
        /// To string conversion
        /// </summary>
        String,

        /// <summary>
        /// To int conversion
        /// </summary>
        Int,

        /// <summary>
        /// To float conversion
        /// </summary>
        Float,

        /// <summary>
        /// To boolean conversion
        /// </summary>
        Boolean,

        /// <summary>
        /// To date conversion
        /// </summary>
        Date
    }
}