/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class MessageBox
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
		[Description("")]
        public Notification Notify(NotificationConfig config)
        {
            return new Notification().Configure(config);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        [Description("")]
        public Notification Notify(string title, object msg)
        {
            return this.Notify(title, msg.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
		[Description("")]
        public Notification Notify(string title, string msg)
        {
            return new Notification().Configure(new NotificationConfig
            {
                Title = title,
                Html = msg
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="format"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        [Description("")]
        public Notification Notify(string title, string format, params object[] args)
        {
            return this.Notify(title, string.Format(format, args));
        }
    }
}