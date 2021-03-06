/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web;

namespace Ext.Net
{
    /// <summary>
    /// JavaScript helper functions.
    /// </summary>
    [Description("JavaScript helper functions.")]
    public partial class Js : ScriptClass
    {
        /*  Helpers
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        [Description("")]
        public virtual void Alert(string msg)
        {
            this.Call("alert", msg);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="handler"></param>
        [Description("")]
        public virtual void Confirm(string msg, string handler)
        {
            string tpl = @"(function(){{var result=confirm(""{0}"");{1}}})();";
            
            ResourceManager.GetInstance(HttpContext.Current).AddScript(tpl, msg, handler);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public override string ToScript()
        {
            return "";
        }
    }
}