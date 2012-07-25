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
    /// Defines behaviour of field remote validation for init value
    /// </summary>
    public enum InitValueValidation
    {
        /// <summary>
        /// Init value is valid always
        /// </summary>
        Valid,
        /// <summary>
        /// Init value is considered as invalid and requires remote validation
        /// </summary>
        Invalid,
        /// <summary>
        /// Remote validation is triggered automatically to validate init value
        /// </summary>
        Validate
    }
}
