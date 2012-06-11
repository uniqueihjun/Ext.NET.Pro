/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
    /// The shadow display mode.
	/// </summary>
    public enum ShadowMode
    {
        /// <summary>
        /// No Shadow
        /// </summary>
        None,

        /// <summary>
        /// Shadow displays on both sides and bottom only
        /// </summary>
        Sides,

        /// <summary>
        /// Shadow displays equally on all four sides
        /// </summary>
        Frame,

        /// <summary>
        /// Traditional bottom-right drop shadow
        /// </summary>
        Drop
    }
}