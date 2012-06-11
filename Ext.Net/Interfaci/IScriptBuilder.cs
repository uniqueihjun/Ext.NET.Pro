/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public interface IScriptBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="component"></param>
        void Create(IScriptable component);

        /// <summary>
        /// The IScriptable component to compile into JavaScript.
        /// </summary>
        IScriptable Component 
        { 
            get; 
        }

        /// <summary>
        /// Returns the JavaScript required to create this IScriptable component. 
        /// </summary>
        /// <returns>The JavaScript</returns>
        string Compile();
    }
}