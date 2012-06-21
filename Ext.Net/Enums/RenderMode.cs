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
    /// 
    /// </summary>
    public enum RenderMode
    {
        /// <summary>
        /// Automatic mode detection
        /// </summary>
        Auto,

        /// <summary>
        /// Render the control to the end of the element
        /// </summary>
        RenderTo,
        
        /// <summary>
        /// Add the control to items collection of the element
        /// </summary>
        AddTo,

        /// <summary>
        /// Insert the control to items collection of the element
        /// </summary>
        InsertTo,

        /// <summary>
        /// Replace the element by this control
        /// </summary>
        Replace
    }
}