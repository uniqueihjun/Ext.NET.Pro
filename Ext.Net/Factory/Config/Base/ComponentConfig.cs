/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web.UI.WebControls;
using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class Component
    {
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Observable.Config
        {
            /// <summary>
            /// 
            /// </summary>
            public override Unit Height { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public override Unit Width { get; set; }
        }
    }
}