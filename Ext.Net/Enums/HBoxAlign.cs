/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net
{
    /// <summary>
    /// Controls how the child items of the container are aligned
    /// </summary>
    public enum HBoxAlign
    {
        /// <summary>
        /// child items are aligned vertically at the left side of the container
        /// </summary>
        Top,

        /// <summary>
        /// child items are aligned vertically at the mid-height of the container
        /// </summary>
        Middle,
        
        /// <summary>
        /// child items are stretched vertically to fill the height of the container
        /// </summary>
        Stretch,

        /// <summary>
        /// child items are stretched vertically to the size of the largest item.
        /// </summary>
        StretchMax
    }
}