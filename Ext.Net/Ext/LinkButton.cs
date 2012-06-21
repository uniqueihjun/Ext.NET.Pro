/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Simple LinkButton class
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:LinkButton runat=\"server\" Text=\"LinkButton\" />")]
    [ToolboxBitmap(typeof(LinkButton), "Build.ToolboxIcons.LinkButton.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [DefaultEvent("Click")]
    [DefaultProperty("Text")]
    [Description("Simple LinkButton class")]
    public partial class LinkButton : Button
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public LinkButton() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "netlinkbutton";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.net.LinkButton";
            }
        }
    }
}
