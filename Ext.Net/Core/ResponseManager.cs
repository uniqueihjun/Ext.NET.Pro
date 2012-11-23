/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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

            Ext.Net.ResourceManager.AddInstanceScript("window.location=\"".ConcatWith(TokenUtils.IsRawToken(url) ? url : ExtNetTransformer.ResolveUrl(url), "\";"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Description("")]
        public static Control Get(string id)
        {
            ResourceManager rm = ResponseManager.ResourceManager;
            
            return rm != null ? ControlUtils.FindControl<Control>(rm, id) : null;
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
            ResourceManager rm = ResponseManager.ResourceManager;

            return rm != null ? ControlUtils.FindControl<T>(ResponseManager.ResourceManager, id) as T : default(T);
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