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
    public enum HtmlEvent
    {
        /// <summary>
        /// Loading of an image is interrupted
        /// </summary>
        Abort,
        
        /// <summary>
        /// An element loses focus
        /// </summary>
        Blur,

        /// <summary>
        /// The user changes the content of a field
        /// </summary>
        Change,

        /// <summary>
        /// Mouse clicks an object
        /// </summary>
        Click,

        /// <summary>
        /// Mouse double-clicks an object
        /// </summary>
        DoubleClick,

        /// <summary>
        /// An error occurs when loading a document or an image
        /// </summary>
        Error,

        /// <summary>
        /// An element gets focus
        /// </summary>
        Focus,

        /// <summary>
        /// A keyboard key is pressed
        /// </summary>
        KeyDown,

        /// <summary>
        /// A keyboard key is pressed or held down
        /// </summary>
        KeyPress,

        /// <summary>
        /// A keyboard key is released
        /// </summary>
        KeyUp,

        /// <summary>
        /// A page or an image is finished loading
        /// </summary>
        Load,

        /// <summary>
        /// A mouse button is pressed
        /// </summary>
        MouseDown,

        /// <summary>
        /// The mouse is moved
        /// </summary>
        MouseMove,

        /// <summary>
        /// The mouse is moved off an element
        /// </summary>
        MouseOut,

        /// <summary>
        /// The mouse is moved over an element
        /// </summary>
        MouseOver,

        /// <summary>
        /// A mouse button is released
        /// </summary>
        MouseUp,

        /// <summary>
        /// The reset button is clicked
        /// </summary>
        Reset,

        /// <summary>
        /// A window or frame is resized
        /// </summary>
        Resize,

        /// <summary>
        /// Text is selected
        /// </summary>
        Select,

        /// <summary>
        /// The submit button is clicked
        /// </summary>
        Submit,

        /// <summary>
        /// The user exits the page
        /// </summary>
        Unload
    }
}