/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web;

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
        public static BaseControl Get(string id)
        {
            return ControlUtils.FindControl<BaseControl>(ResourceManager.GetInstance(HttpContext.Current), id);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static T Get<T>(string id) where T : BaseControl
        {
            return ControlUtils.FindControl<T>(ResourceManager.GetInstance(HttpContext.Current), id);
        }
    }
}