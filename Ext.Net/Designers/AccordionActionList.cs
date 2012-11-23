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
    public partial class AccordionActionList : ExtControlActionList
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
        public AccordionActionList(IDesigner designer)
            : base(designer.Component)
        {
            this.designer = designer;
        }

        private AccordionDesigner Designer
        {
            get
            {
                return designer as AccordionDesigner;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void AddPanel()
        {
            Designer.AddPanel();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void RemovePanel()
        {
            Designer.RemovePanel();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddHeaderItem(new DesignerActionHeaderItem("Actions", "600"));

            DesignerActionMethodItem add = new DesignerActionMethodItem(this, "AddPanel", "Add Panel", "600");
            DesignerActionMethodItem remove = new DesignerActionMethodItem(this, "RemovePanel", "Remove panel", "600", "Remove active panel");
            AccordionLayout layout = (AccordionLayout)this.Control;
            this.AddMethodItem(add);

            if (layout.ExpandedPanelIndex > -1)
            {
                this.AddMethodItem(remove);
            }
            else
            {
                this.RemoveMethodItem(remove);
            }

            return base.GetSortedActionItems();
        }
    }
}