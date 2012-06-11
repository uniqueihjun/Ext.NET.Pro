/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Web;

namespace Ext.Net.MVC
{
    /// <summary>
    /// 
    /// </summary>
    public class MvcResourcePlaceHolderBuilder : IHtmlString
    {
        /// <summary>
        /// 
        /// </summary>
        public MvcResourcePlaceHolderBuilder()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"></param>
        public MvcResourcePlaceHolderBuilder(ResourceMode mode)
        {
            this.mode = mode;
        }
        
        private ResourceMode mode = ResourceMode.Script;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public MvcResourcePlaceHolderBuilder Mode(ResourceMode mode)
        {
            this.mode = mode;
            return this;
        }
        
        #region Члены IHtmlString

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToHtmlString()
        {
            if (HttpContext.Current == null)
            {
                return "";
            }

            switch (this.mode)
            {
                case ResourceMode.Style:
                    HttpContext.Current.Items["Ext.Net.InitStyle"] = new ResourcePlaceHolder(ResourceMode.Style);
                    return Transformer.NET.Net.CreateToken(typeof(Transformer.NET.AnchorTag), new Dictionary<string, string>{                        
                        {"id", "ext.net.initstyle"}
                    });
                case ResourceMode.Script:
                    HttpContext.Current.Items["Ext.Net.InitScript"] = new ResourcePlaceHolder(ResourceMode.Script);
                    return Transformer.NET.Net.CreateToken(typeof(Transformer.NET.AnchorTag), new Dictionary<string, string>{
                        {"id", "ext.net.initscript"}
                    });
                case ResourceMode.ScriptFiles:
                    HttpContext.Current.Items["Ext.Net.InitScriptFiles"] = new ResourcePlaceHolder(ResourceMode.ScriptFiles);
                    return Transformer.NET.Net.CreateToken(typeof(Transformer.NET.AnchorTag), new Dictionary<string, string>{
                        {"id", "ext.net.initscriptfiles"}
                    });
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion
    }
}
