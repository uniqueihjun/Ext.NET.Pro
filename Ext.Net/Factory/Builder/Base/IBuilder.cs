/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public interface IControlBuilder<T> 
        where T : Control
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        T ToComponent();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        [Description("")]
        void Render(Control control);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Description("")]
    public interface IXControlBuilder<T> : IControlBuilder<T>
        where T : XControl
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        void Render();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        string ToScript();
    }
}