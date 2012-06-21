/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class ResponseManager
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public static ResourceManager ResourceManager
        {
            get
            {
                return ResourceManager.GetInstance(HttpContext.Current);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        [Description("")]
        public static void Redirect(string url)
        {
            ResponseManager.Redirect(url, null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="msg"></param>
        [Description("")]
        public static void Redirect(string url, string msg)
        {
            ResponseManager.Redirect(url, msg, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="msg"></param>
        /// <param name="msgCls"></param>
        [Description("")]
        public static void Redirect(string url, string msg, string msgCls)
        {
            ResourceManager rm = ResponseManager.ResourceManager;

            if (rm == null)
            {
                throw new InvalidOperationException("The ResourceManager could not be found during the Ext.Redirect.");
            }

            if (url.IsEmpty())
            {
                throw new ArgumentNullException("url", "The redirection url is empty");
            }
            
            if (msg.IsNotEmpty())
            {
                X.Mask.Show(new MaskConfig
                {
                    Msg = msg,
                    MsgCls = msgCls
                });
            }

            rm.AddScript("window.location=\"".ConcatWith(TokenUtils.IsRawToken(url) ? url : rm.ResolveClientUrl(url), "\";"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Description("")]
        public static Control Get(string id)
        {
            return ControlUtils.FindControl<Control>(ResponseManager.ResourceManager, id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        [Description("")]
        public static T Get<T>(string id) where T : Control
        {
            return ControlUtils.FindControl<T>(ResponseManager.ResourceManager, id) as T;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Description("")]
        public static BaseControl GetCmp(string id)
        {
            return ComponentManager.Get(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        [Description("")]
        public static T GetCmp<T>(string id) where T : ComponentBase
        {
            return ComponentManager.Get<T>(id);
        }
    }
}