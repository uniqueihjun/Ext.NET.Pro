/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    public partial class MessageBox
    {
        /// <summary>
        /// Displays a message box with an infinitely auto-updating progress bar. This can be used to block user interaction while waiting for a long-running process to complete that does not have defined intervals. You are responsible for closing the message box when the process is complete.
        /// </summary>
        /// <param name="msg">The message box body text</param>
        [Description("Displays a message box with an infinitely auto-updating progress bar. This can be used to block user interaction while waiting for a long-running process to complete that does not have defined intervals. You are responsible for closing the message box when the process is complete.")]
        public MessageBox Wait(object msg)
        {
            return this.Wait(msg.ToString());
        }

        /// <summary>
        /// Displays a message box with an infinitely auto-updating progress bar. This can be used to block user interaction while waiting for a long-running process to complete that does not have defined intervals. You are responsible for closing the message box when the process is complete.
        /// </summary>
        /// <param name="msg">The message box body text</param>
        [Description("Displays a message box with an infinitely auto-updating progress bar. This can be used to block user interaction while waiting for a long-running process to complete that does not have defined intervals. You are responsible for closing the message box when the process is complete.")]
        public MessageBox Wait(string msg)
        {
            return this.Wait(msg, "");
        }

        /// <summary>
        /// Displays a message box with an infinitely auto-updating progress bar. This can be used to block user interaction while waiting for a long-running process to complete that does not have defined intervals. You are responsible for closing the message box when the process is complete.
        /// </summary>
        /// <param name="msg">The message box body text</param>
        /// <param name="title">(optional) The title bar text</param>
        [Description("Displays a message box with an infinitely auto-updating progress bar. This can be used to block user interaction while waiting for a long-running process to complete that does not have defined intervals. You are responsible for closing the message box when the process is complete.")]
        public MessageBox Wait(string msg, string title)
        {
            return this.Wait(msg, title, null as WaitConfig);
        }

        /// <summary>
        /// Displays a message box with an infinitely auto-updating progress bar. This can be used to block user interaction while waiting for a long-running process to complete that does not have defined intervals. You are responsible for closing the message box when the process is complete.
        /// </summary>
        /// <param name="msg">The message box body text</param>
        /// <param name="title">(optional) The title bar text</param>
        /// <param name="config">(optional) A Ext.ProgressBar.waitConfig object</param>
        [Description("Displays a message box with an infinitely auto-updating progress bar. This can be used to block user interaction while waiting for a long-running process to complete that does not have defined intervals. You are responsible for closing the message box when the process is complete.")]
        public MessageBox Wait(string msg, string title, WaitConfig config)
        {
            MessageBoxConfig config2 = new MessageBoxConfig();
            config2.Title = title;
            config2.Message = msg;
            config2.Closable = false;
            config2.Wait = true;
            config2.Modal = true;
            config2.WaitConfig = config;

            return this.Configure(config2);
        }
    }
}