/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public enum InputType
    {        
        /// <summary>
        /// Creates a single-line text input control.
        /// </summary>
        Text,

        /// <summary>
        /// Like "text", but the input text is rendered in such a way as to hide the characters (e.g., a series of asterisks). This control type is often used for sensitive input such as passwords. Note that the current value is the text entered by the user, not the text rendered by the user agent.
        /// Note. Application designers should note that this mechanism affords only light security protection. Although the password is masked by user agents from casual observers, it is transmitted to the server in clear text, and may be read by anyone with low-level access to the network.
        /// </summary>
        Password,

        /// <summary>
        /// Creates a checkbox.
        /// </summary>
        Checkbox,

        /// <summary>
        /// Creates a radio button.
        /// </summary>
        Radio,

        /// <summary>
        /// Creates a graphical submit button. The value of the src attribute specifies the URI of the image that will decorate the button. For accessibility reasons, authors should provide alternate text for the image via the alt attribute.
        /// </summary>
        Image,

        /// <summary>
        /// Creates a reset button.
        /// </summary>
        Reset,

        /// <summary>
        /// Creates a push button. User agents should use the value of the value attribute as the button's label.
        /// </summary>
        Button,

        /// <summary>
        /// Creates a hidden control.
        /// </summary>
        Hidden,

        /// <summary>
        /// Creates a file select control. User agents may use the value of the value attribute as the initial file name.
        /// </summary>
        File,

        // HTML 5 types

        /// <summary>
        /// 
        /// </summary>
        Color,

        /// <summary>
        /// 
        /// </summary>
        Date,

        /// <summary>
        /// 
        /// </summary>
        DateTime,

        /// <summary>
        /// 
        /// </summary>
        Email,

        /// <summary>
        /// 
        /// </summary>
        Number,

        /// <summary>
        /// 
        /// </summary>
        Range,

        /// <summary>
        /// 
        /// </summary>
        Search,

        /// <summary>
        /// 
        /// </summary>
        Tel,

        /// <summary>
        /// 
        /// </summary>
        Time,

        /// <summary>
        /// 
        /// </summary>
        Url,

        /// <summary>
        /// 
        /// </summary>
        Month,

        /// <summary>
        /// 
        /// </summary>
        Week
    }
}