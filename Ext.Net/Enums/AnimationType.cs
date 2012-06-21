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
    public enum AnimationType
    {
        /// <summary>
        /// Default
        /// </summary>
        Run,
        /// <summary>
        /// Animates transition of background, text, or border colors.
        /// </summary>
        Color,
        /// <summary>
        /// Animates the motion of an element to/from specific points using optional bezier way points during transit.
        /// </summary>
        Motion,
        /// <summary>
        /// Animate horizontal or vertical scrolling of an overflowing page element.
        /// </summary>
        Scroll
    }
}