/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Collections.Generic;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public interface IResourceManager
    {
        /// <summary>
        /// Get an instance of the ResourceManager
        /// </summary>
        ResourceManager ResourceManager { get; }

        /// <summary>
        /// Get an instance of the Page
        /// </summary>
        Page Page { get; }
    }
}