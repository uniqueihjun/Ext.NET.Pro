/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class HtmlEditorActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public HtmlEditorActionList(IComponent component) : base(component) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool EnableAlignments
        {
            get
            {
                return ((HtmlEditor)this.Control).EnableAlignments;
            }
            set
            {
                this.GetPropertyByName("EnableAlignments").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool EnableColors
        {
            get
            {
                return ((HtmlEditor)this.Control).EnableColors;
            }
            set
            {
                this.GetPropertyByName("EnableColors").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool EnableFont
        {
            get
            {
                return ((HtmlEditor)this.Control).EnableFont;
            }
            set
            {
                this.GetPropertyByName("EnableFont").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool EnableFontSize
        {
            get
            {
                return ((HtmlEditor)this.Control).EnableFontSize;
            }
            set
            {
                this.GetPropertyByName("EnableFontSize").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool EnableFormat
        {
            get
            {
                return ((HtmlEditor)this.Control).EnableFormat;
            }
            set
            {
                this.GetPropertyByName("EnableFormat").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool EnableLinks
        {
            get
            {
                return ((HtmlEditor)this.Control).EnableLinks;
            }
            set
            {
                this.GetPropertyByName("EnableLinks").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool EnableLists
        {
            get
            {
                return ((HtmlEditor)this.Control).EnableLists;
            }
            set
            {
                this.GetPropertyByName("EnableLists").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool EnableSourceEdit
        {
            get
            {
                return ((HtmlEditor)this.Control).EnableSourceEdit;
            }
            set
            {
                this.GetPropertyByName("EnableSourceEdit").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Unit Height
        {
            get
            {
                return ((HtmlEditor)this.Control).Height;
            }
            set
            {
                this.GetPropertyByName("Height").SetValue(this.Control, value);
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
                return ((HtmlEditor)this.Control).Width;
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
            this.AddPropertyItem(new DesignerActionPropertyItem("EnableFont", "Enable Fonts", "500", "Enable font selection. Not available in Safari."));
            this.AddPropertyItem(new DesignerActionPropertyItem("EnableFormat", "Enable Formatting", "500", "Enable the bold, italic and underline buttons."));
            this.AddPropertyItem(new DesignerActionPropertyItem("EnableFontSize", "Enable FontSize", "500", "Enable the increase/decrease font size buttons."));
            this.AddPropertyItem(new DesignerActionPropertyItem("EnableColors", "Enable Colors", "500", "Enable the fore/highlight color buttons."));
            this.AddPropertyItem(new DesignerActionPropertyItem("EnableAlignments", "Enable Alignments", "500", "Enable the left, center, right alignment buttons."));
            this.AddPropertyItem(new DesignerActionPropertyItem("EnableLinks", "Enable Hyperlinks", "500", "Enable the create link button."));
            this.AddPropertyItem(new DesignerActionPropertyItem("EnableLists", "Enable Lists", "500", "Enable the bullet and numbered list buttons."));
            this.AddPropertyItem(new DesignerActionPropertyItem("EnableSourceEdit", "Enable Source Editing", "500", "Enable the switch to source edit button."));

            this.AddPropertyItem(new DesignerActionPropertyItem("Width", "Width", "500", "Change the Width of the control"));
            this.AddPropertyItem(new DesignerActionPropertyItem("Height", "Height", "500", "Change the Height of the control"));

            return base.GetSortedActionItems();
        }
    }
}