/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// This is a layout specifically designed for creating forms.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:FormLayout runat=\"server\"><Anchors><{0}:Anchor><{0}:TextField runat=\"server\" FieldLabel=\"Field1\" /></{0}:Anchor></Anchors></{0}:FormLayout>")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(FormLayout), "Build.ToolboxIcons.Layout.bmp")]
    [Description("This is a layout specifically designed for creating forms.")]
    public partial class FormLayout : AnchorLayout
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public FormLayout() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("4. Layout")]
		[Description("")]
        public override string LayoutType
        {
            get
            {
                return "form";
            }
        }

        /// <summary>
        /// True to show/hide the field label when the field is hidden. Defaults to true. 
        /// </summary>
        [ConfigOption]
        [DefaultValue(true)]
        [Description("True to show/hide the field label when the field is hidden. Defaults to true.")]
        public virtual bool TrackLabels
        {
            get
            {
                object obj = this.ViewState["TrackLabels"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["TrackLabels"] = value;
            }
        }
        
        /// <summary>
        /// A CSS style specification string to add to each field element in this layout (defaults to '').
        /// </summary>
        [NotifyParentProperty(true)]
        [Description("A CSS style specification string to add to each field element in this layout (defaults to '').")]
        public virtual string ElementStyle
        {
            get
            {
                return (string)this.ViewState["ElementStyle"] ?? "";
            }
            set
            {
                this.ViewState["ElementStyle"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Object)]
        [Browsable(false)]
        [DefaultValue(null)]
        [Description("")]
        protected internal override LayoutConfig LayoutConfig
        {
            get
            {
                return new FormLayoutConfig(
                    this.TrackLabels,
                    this.ElementStyle, 
                    this.LabelSeparator, 
                    this.LabelStyle, 
                    this.RenderHidden,
                    this.ExtraCls);
            }
        }

        /// <summary>
        /// True to hide field labels by default (defaults to false).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. FormLayout")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True to hide field labels by default (defaults to false).")]
        public override bool HideLabels
        {
            get
            {
                object obj = this.ViewState["HideLabels"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["HideLabels"] = value;
            }
        }

        /// <summary>
        /// A CSS class to add to the div wrapper that contains each field label and field element (the default class is 'x-form-item' and itemCls will be added to that)
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. FormLayout")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("A CSS class to add to the div wrapper that contains each field label and field element (the default class is 'x-form-item' and itemCls will be added to that)")]
        public override string ItemCls
        {
            get
            {
                return (string)this.ViewState["ItemCls"] ?? "";
            }
            set
            {
                this.ViewState["ItemCls"] = value;
            }
        }
    }
}