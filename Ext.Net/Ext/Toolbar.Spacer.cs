/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A simple element that adds extra horizontal space between items in a toolbar.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A simple element that adds extra horizontal space between items in a toolbar.")]
    public partial class ToolbarSpacer : ToolbarItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarSpacer() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarSpacer(Unit width)
        {
            this.Width = width;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarSpacer(int width)
        {
            this.Width = Unit.Pixel(width);
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "nettbspacer";
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
                return "Ext.net.ToolbarSpacer";
            }
        }
    }
}