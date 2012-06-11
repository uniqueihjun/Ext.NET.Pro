/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    /// A simple element that adds a greedy (100% width) horizontal space between items in a toolbar.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A simple element that adds a greedy (100% width) horizontal space between items in a toolbar.")]
    public partial class ToolbarFill : ToolbarItem
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
                return "Ext.Toolbar.Fill";
            }
        }
    }
}