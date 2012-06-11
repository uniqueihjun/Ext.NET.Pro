/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class NumberFieldActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public NumberFieldActionList(IComponent component) : base(component) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool AllowDecimals
        {
            get
            {
                return ((NumberField)this.Control).AllowDecimals;
            }
            set
            {
                this.GetPropertyByName("AllowDecimals").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool AllowNegative
        {
            get
            {
                return ((NumberField)this.Control).AllowNegative;
            }
            set
            {
                this.GetPropertyByName("AllowNegative").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool AllowBlank
        {
            get
            {
                return ((NumberField)this.Control).AllowBlank;
            }
            set
            {
                this.GetPropertyByName("AllowBlank").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string EmptyText
        {
            get
            {
                return ((NumberField)this.Control).EmptyText;
            }
            set
            {
                this.GetPropertyByName("EmptyText").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Double MaxValue
        {
            get
            {
                return ((NumberField)this.Control).MaxValue;
            }
            set
            {
                this.GetPropertyByName("MaxValue").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Double MinValue
        {
            get
            {
                return ((NumberField)this.Control).MinValue;
            }
            set
            {
                this.GetPropertyByName("MinValue").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Unit Width
        {
            get
            {
                return ((NumberField)this.Control).Width;
            }
            set
            {
                this.GetPropertyByName("Width").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddPropertyItem(new DesignerActionPropertyItem("AllowDecimals", "AllowDecimals", "500", "Allow demcimals in the TextBox"));
            this.AddPropertyItem(new DesignerActionPropertyItem("AllowNegative", "AllowNegative", "500", "Allow negative numbers in the TextBox"));
            this.AddPropertyItem(new DesignerActionPropertyItem("AllowBlank", "AllowBlank", "500", "Ensure the length of the text is > 0"));
            this.AddPropertyItem(new DesignerActionPropertyItem("EmptyText", "Empty Text", "500", "Change the Text of the control"));
            this.AddPropertyItem(new DesignerActionPropertyItem("MaxValue", "MaxValue", "500", "Change the Maximum Value of the control"));
            this.AddPropertyItem(new DesignerActionPropertyItem("MinValue", "MinValue", "500", "Change the Minimum Value of the control"));
            this.AddPropertyItem(new DesignerActionPropertyItem("Width", "Width", "500", "Change the Width of the control"));

            return base.GetSortedActionItems();
        }
    }
}