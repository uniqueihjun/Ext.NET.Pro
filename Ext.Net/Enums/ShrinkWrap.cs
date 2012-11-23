/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
    /// In CSS terms, shrink-wrap width is analogous to an inline-block element as opposed to a block-level element. Some container layouts always shrink-wrap their children, effectively ignoring this property (e.g., Ext.layout.container.HBox, Ext.layout.container.VBox, Ext.layout.component.Dock).
	/// </summary>
	[Description("In CSS terms, shrink-wrap width is analogous to an inline-block element as opposed to a block-level element. Some container layouts always shrink-wrap their children, effectively ignoring this property (e.g., Ext.layout.container.HBox, Ext.layout.container.VBox, Ext.layout.component.Dock).")]
	public enum ShrinkWrap
	{
        /// <summary>
        /// Neither width nor height depend on content. This is equivalent to false.
        /// </summary>
        Neither = 0,

        /// <summary>
        /// Width depends on content (shrink wraps), but height does not.
        /// </summary>
        Width = 1,

        /// <summary>
        /// Height depends on content (shrink wraps), but width does not. The default.
        /// </summary>
        Height = 2,

        /// <summary>
        /// Both width and height depend on content (shrink wrap). This is equivalent to true.
        /// </summary>
        Both = 3
	}
}