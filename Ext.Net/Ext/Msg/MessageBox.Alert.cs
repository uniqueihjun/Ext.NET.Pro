/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).
        /// </summary>
        /// <param name="title">The title bar text</param>
        /// <param name="msg">The message box body text</param>
        [Description("Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).")]
        public MessageBox Alert(string title, object msg)
        {
            return this.Alert(title, msg.ToString());
        }

        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).
        /// </summary>
        /// <param name="title">The title bar text</param>
        /// <param name="msg">The message box body text</param>
        [Description("Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).")]
        public MessageBox Alert(string title, string msg)
        {
            return this.Alert(title, msg, "", "");
        }

        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).
        /// </summary>
        /// <param name="title">The title bar text</param>
        /// <param name="msg">The message box body text</param>
        [Description("Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).")]
        public MessageBox Alert(string title, string format, params object[] args)
        {
            return this.Alert(title, string.Format(format, args));
        }

        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).
        /// </summary>
        /// <param name="title">The title bar text</param>
        /// <param name="msg">The message box body text</param>
        /// <param name="fn">(optional) The callback function invoked after the message box is closed</param>
        [Description("Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).")]
        public MessageBox Alert(string title, string msg, JFunction fn)
        {
            return this.Alert(title, msg, fn, "");
        }

        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).
        /// </summary>
        /// <param name="title">The title bar text</param>
        /// <param name="msg">The message box body text</param>
        /// <param name="handler">(optional) The callback function invoked after the message box is closed</param>
        [Description("Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).")]
        public MessageBox Alert(string title, string msg, string handler)
        {
            return this.Alert(title, msg, handler, "");
        }

        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).
        /// </summary>
        /// <param name="title">The title bar text</param>
        /// <param name="msg">The message box body text</param>
        /// <param name="handler">(optional) The callback function invoked after the message box is closed</param>
        /// <param name="scope">(optional) The scope of the callback function</param>
        [Description("Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).")]
        public MessageBox Alert(string title, string msg, string handler, string scope)
        {
            return this.Alert(title, msg, handler.IsNotEmpty() ? new JFunction(handler, "buttonId", "text") : null as JFunction, scope);
        }

        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).
        /// </summary>
        /// <param name="title">The title bar text</param>
        /// <param name="msg">The message box body text</param>
        /// <param name="fn">(optional) The callback function invoked after the message box is closed</param>
        /// <param name="scope">(optional) The scope of the callback function</param>
        [Description("Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).")]
        public MessageBox Alert(string title, string msg, JFunction fn, string scope)
        {
            MessageBoxConfig config = new MessageBoxConfig();
            config.Title = title;
            config.Message = msg;
            config.Buttons = Button.OK;
            config.Fn = fn;
            config.Scope = scope;

            return this.Configure(config);
        }

        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).
        /// </summary>
        /// <param name="title">The title bar text</param>
        /// <param name="msg">The message box body text</param>
        /// <param name="buttonsConfig">A MessageBoxButtonsConfig object for configuring the Text value and JavaScript Handler for each MessageBox Button.</param>
        [Description("Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).")]
        public MessageBox Alert(string title, string msg, MessageBoxButtonsConfig buttonsConfig)
        {
            MessageBoxConfig config = new MessageBoxConfig();
            config.Title = title;
            config.Message = msg;
            config.Buttons = Button.OK;
            config.MessageBoxButtonsConfig = buttonsConfig;

            return this.Configure(config);
        }

        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).
        /// </summary>
        /// <param name="title">The title bar text</param>
        /// <param name="msg">The message box body text</param>
        /// <param name="buttonsConfig">A MessageBoxButtonsConfig object for configuring the Text value and JavaScript Handler for each MessageBox Button.</param>
        /// <param name="scope">(optional) The scope of the callback function</param>
        [Description("Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). If a callback function is passed it will be called after the user clicks the button, and the id of the button that was clicked will be passed as the only parameter to the callback (could also be the top-right close button).")]
        public MessageBox Alert(string title, string msg, MessageBoxButtonsConfig buttonsConfig, string scope)
        {
            MessageBoxConfig config = new MessageBoxConfig();
            config.Title = title;
            config.Message = msg;
            config.Buttons = Button.OK;
            config.MessageBoxButtonsConfig = buttonsConfig;
            config.Scope = scope;

            return this.Configure(config);
        }
    }
}