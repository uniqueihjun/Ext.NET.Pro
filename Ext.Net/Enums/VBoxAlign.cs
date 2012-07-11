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
    /// Controls how the child items of the container are aligned.
    /// </summary>
    public enum VBoxAlign
    {
        /// <summary>
        /// child items are aligned horizontally at the left side of the container
        /// </summary>
        Left,
        /// <summary>
        /// child items are aligned horizontally at the mid-width of the container
        /// </summary>
        Center,
        /// <summary>
        /// child items are stretched horizontally to fill the width of the container
        /// </summary>
        Stretch,
        /// <summary>
        /// child items are stretched horizontally to the size of the largest item.
        /// </summary>
        StretchMax
    }
}