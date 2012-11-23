/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    [Description("")]
    public interface IControlBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        T Cast<T>() where T : class, IControlBuilder;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Description("")]
    public interface IXControlBuilder<T> : IControlBuilder<T>
        where T : BaseControl
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