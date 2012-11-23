/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Collections.Generic;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public interface IScriptable
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        string InstanceOf { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        string ToScript();

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        void Render();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="script"></param>
        [Description("")]
        void AddScript(string script);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="template"></param>
        /// <param name="args"></param>
        [Description("")]
        void AddScript(string template, params object[] args);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        [Description("")]
        void Call(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="args"></param>
        [Description("")]
        void Call(string name, params object[] args);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        [Description("")]
        void Set(string name, object value);
    }
}