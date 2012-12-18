/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    /// A simple class that adds a vertical separator bar between toolbar items (css class: 'x-toolbar-separator').
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A simple class that adds a vertical separator bar between toolbar items (css class: 'x-toolbar-separator').")]
    public partial class ToolbarSeparator : ToolbarItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarSeparator() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "tbseparator";
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
                return "Ext.toolbar.Separator";
            }
        }
    }
}