/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ComponentManager
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static Component Get(string id)
        {
            return ControlUtils.FindControl<Component>(ResourceManager.GetInstance(HttpContext.Current), id);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static T Get<T>(string id) where T : Component
        {
            return ControlUtils.FindControl<T>(ResourceManager.GetInstance(HttpContext.Current), id) as T;
        }
    }
}