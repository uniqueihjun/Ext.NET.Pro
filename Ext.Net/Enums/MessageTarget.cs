/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
	public enum MessageTarget
	{
        /// <summary>
        /// Display a quick tip containing the message when the user hovers over the field.
        /// </summary>
		Qtip,

        /// <summary>
        /// Display the message in a default browser title attribute popup.
        /// </summary>
		Title,

        /// <summary>
        /// Add a block div beneath the field containing the error message.
        /// </summary>
		Under,

        /// <summary>
        /// Add an error icon to the right of the field, displaying the message in a popup on hover.
        /// </summary>
        Side,

        /// <summary>
        /// Don't display any error message. This might be useful if you are implementing custom error display.
        /// </summary>
        None
	}
}