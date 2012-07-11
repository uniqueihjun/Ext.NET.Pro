/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net
{
    /// <summary>
    /// Size for the editor to automatically adopt the size of the underlying field, "Width" to adopt the width only, or "Height" to adopt the height only (defaults to Disable)
    /// </summary>
    public enum EditorAutoSize
    {
        /// <summary>
        /// Disable auto size
        /// </summary>
        Disable,
        /// <summary>
        /// Fits the editor to automatically adopt the size of the underlying field
        /// </summary>
        Fit,
        /// <summary>
        /// "Width" to adopt the width only
        /// </summary>
        Width,
        /// <summary>
        /// "Height" to adopt the height only
        /// </summary>
        Height
    }
}