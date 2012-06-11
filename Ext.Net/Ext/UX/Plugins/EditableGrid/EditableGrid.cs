/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
    

    /// <summary>
    /// Plugin to show editors for all cells in a GridPanel
    /// Do NOT use this plugin for large datasets!
    /// </summary>
    ///<new date="2009-12-03" owner="vladsch" key="EditableGrid">
    /// Added new <see cref="EditableGrid" /> plugin />.
    /// </new>
    public partial class EditableGrid : Plugin
    {
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

                baseList.Add(new ClientScriptItem(typeof(EditableGrid), "Ext.Net.Build.Ext.Net.ux.plugins.editablegrid.editablegrid.js", "/ux/plugins/editablegrid/editablegrid.js"));

                return baseList;
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
                return "Ext.ux.grid.EditableGrid";
            }
        }
    }
}