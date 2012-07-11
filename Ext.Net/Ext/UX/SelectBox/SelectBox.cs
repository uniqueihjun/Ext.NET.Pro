/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Makes a ComboBox more closely mimic an HTML SELECT.  Supports clicking and dragging
    /// through the list, with item selection occurring when the mouse button is released.
    /// When used will automatically set editable to false and call unselectable
    /// on inner elements.  Re-enabling editable after calling this will NOT work.
    /// </summary>
    public partial class SelectBox : ComboBox
    {
        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.ux.SelectBox";
            }
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
                return "selectbox";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                baseList.Add(new ClientScriptItem(typeof(SelectBox), "Ext.Net.Build.Ext.Net.ux.selectbox.selectbox.js", "/ux/selectbox/selectbox.js"));

                return baseList;
            }
        }
    }
}