/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class LabelActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public LabelActionList(IComponent component) : base(component) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Text
        {
            get
            {
                return ((Label)this.Control).Text;
            }
            set
            {
                this.GetPropertyByName("Text").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Html
        {
            get
            {
                return ((Label)this.Control).Html;
            }
            set
            {
                this.GetPropertyByName("Html").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Cls
        {
            get
            {
                return ((Label)this.Control).Cls;
            }
            set
            {
                this.GetPropertyByName("Cls").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string StyleSpec
        {
            get
            {
                return ((Label)this.Control).StyleSpec;
            }
            set
            {
                this.GetPropertyByName("StyleSpec").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddPropertyItem(new DesignerActionPropertyItem("Text", "Text", "500", "Set the text of the Label."));
            this.AddPropertyItem(new DesignerActionPropertyItem("Html", "Html", "500", "Set the text of the Label."));
            //this.AddPropertyItem(new DesignerActionPropertyItem("Cls", "Class", "500", "Set the class of the Label."));
            //this.AddPropertyItem(new DesignerActionPropertyItem("StyleSpec", "Style", "500", "Set the style of the Label."));

            return base.GetSortedActionItems();
        }
    }
}
