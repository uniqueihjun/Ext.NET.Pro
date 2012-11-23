/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BorderLayoutActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BorderLayoutActionList(IDesigner designer) : base(designer.Component)
        {
            this.designer = designer;
        }

        private readonly IDesigner designer;

        private BorderLayoutDesigner Designer
        {
            get
            {
                return designer as BorderLayoutDesigner;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool SchemeMode
        {
            get
            {
                return (bool)this.GetPropertyByName("SchemeMode").GetValue(this.Control);
            }
            set
            {
                this.GetPropertyByName("SchemeMode").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddPropertyItem(new DesignerActionPropertyItem("SchemeMode", "Show layout as scheme", "500"));

            return base.GetSortedActionItems();
        }
    }
}