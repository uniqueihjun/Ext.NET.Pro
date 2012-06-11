/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;

namespace Ext.Net
{
    /// <summary>
    /// The type of content that is to be loaded into a component, which can be one of 4 types
    /// </summary>
    public enum LoadMode
    {
        /// <summary>
        /// Loads raw html content, see Ext.AbstractComponent-html
        /// </summary>
        Html,
        /// <summary>
        /// Loads raw html content, see Ext.AbstractComponent-data
        /// </summary>
        Data,
        /// <summary>
        /// Loads child {Ext.AbstractComponent} instances. This option is only valid when used with a Container.
        /// </summary>
        Component,
        /// <summary>
        /// Loads a page inside generated iframe element. This option is only valid when used with a Container.
        /// </summary>
        Frame
    }
}
