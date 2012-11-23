/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
        /// child items are aligned vertically at the top side of the container
        /// </summary>
        Top,

        /// <summary>
        /// child items are aligned vertically in the middle of the container
        /// </summary>
        Middle,
        
        /// <summary>
        /// child items are stretched vertically to fill the height of the container
        /// </summary>
        Stretch,

        /// <summary>
        /// child items are stretched vertically to the height of the largest item.
        /// </summary>
        StretchMax
    }
}