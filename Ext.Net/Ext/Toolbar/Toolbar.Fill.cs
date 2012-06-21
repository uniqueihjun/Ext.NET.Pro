/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    /// A non-rendering placeholder item which instructs the Toolbar's Layout to begin using the right-justified button container.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A non-rendering placeholder item which instructs the Toolbar's Layout to begin using the right-justified button container.")]
    public partial class ToolbarFill : ComponentBase, IToolbarItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarFill() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "tbfill";
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
                return "Ext.toolbar.Fill";
            }
        }
    }
}