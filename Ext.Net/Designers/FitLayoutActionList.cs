/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    public partial class FitLayoutActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected readonly IDesigner designer;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public FitLayoutActionList(IDesigner designer)
            : base(designer.Component)
        {
            this.designer = designer;
        }

        private FitLayoutDesigner Designer
        {
            get
            {
                return designer as FitLayoutDesigner;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void AddPanel()
        {
            Designer.AddItem(typeof(Panel));
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void AddTabPanel()
        {
            Designer.AddItem(typeof(TabPanel));
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void Clear()
        {
            Designer.Clear();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddHeaderItem(new DesignerActionHeaderItem("Actions", "600"));

            DesignerActionMethodItem addPanel = new DesignerActionMethodItem(this, "AddPanel", "Add Panel", "600");
            DesignerActionMethodItem addTabPanel = new DesignerActionMethodItem(this, "AddTabPanel", "Add TabPanel", "600");
            
            //DesignerActionMethodItem clear = new DesignerActionMethodItem(this, "Clear", "Clear layout", "600", "Remove control from layout");

            if (((FitLayout)this.Control).Items.Count > 0)
            {
                //this.AddMethodItem(clear);
                this.RemoveMethodItem(addPanel);
                this.RemoveMethodItem(addTabPanel);
            }
            else
            {
                this.AddMethodItem(addPanel);
                this.AddMethodItem(addTabPanel);
                //this.RemoveMethodItem(clear);
            }

            return base.GetSortedActionItems();
        }
    }
}