/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// This layout adds the ability for x/y positioning using the standard x and y component config options.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:AbsoluteLayout id=\"AbsoluteLayout1\" runat=\"server\"><Anchors><{0}:Anchor><{0}:Panel runat=\"server\" Title=\"Panel 1\" X=\"50\" Y=\"50\" Width=\"200\" Height=\"100\"Frame=\"true\" BodyStyle=\"padding:15px;\"><Content>Positioned at x:50, y:50</Content></{0}:Panel></{0}:Anchor><{0}:Anchor><{0}:Panel runat=\"server\" Title=\"Panel 2\" X=\"125\" Y=\"125\" Width=\"200\"Height=\"100\" Frame=\"true\" BodyStyle=\"padding:15px;\"><Content>Positioned at x:125, y:125</Content></{0}:Panel></{0}:Anchor></Anchors></{0}:AbsoluteLayout>")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(AbsoluteLayout), "Build.ToolboxIcons.Layout.bmp")]
    [Description("This layout adds the ability for x/y positioning using the standard x and y component config options.")]
    public partial class AbsoluteLayout : AnchorLayout
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AbsoluteLayout() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("4. Layout")]
		[Description("")]
        public override string LayoutType
        {
            get
            {
                return "absolute";
            }
        }
    }
}