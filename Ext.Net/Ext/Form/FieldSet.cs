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
    /// Standard content Container used for grouping form fields.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:FieldSet runat=\"server\"><Items></Items></{0}:FieldSet>")]
    [DefaultEvent("Width")]
    [ToolboxBitmap(typeof(FieldSet), "Build.ToolboxIcons.FieldSet.bmp")]
    [Designer(typeof(FieldSetDesigner))]
    [Description("Standard content Container used for grouping form fields.")]
    public partial class FieldSet : Panel
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public FieldSet() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "fieldset";
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
                return "Ext.form.FieldSet";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override bool IsCollapsible
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// True to render a checkbox into the fieldset frame just in front of the legend (defaults to false). The fieldset will be expanded or collapsed when the checkbox is toggled.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. FieldSet")]
        [DefaultValue(false)]
        [Description("True to render a checkbox into the fieldset frame just in front of the legend (defaults to false). The fieldset will be expanded or collapsed when the checkbox is toggled.")]
        public override bool AnimCollapse
        {
            get
            {
                object obj = this.ViewState["AnimCollapse"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["AnimCollapse"] = value;
            }
        }

        /// <summary>
        /// True to render a checkbox into the fieldset frame just in front of the legend (defaults to false). The fieldset will be expanded or collapsed when the checkbox is toggled.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. FieldSet")]
        [DefaultValue("")]
        [Description("True to render a checkbox into the fieldset frame just in front of the legend (defaults to false). The fieldset will be expanded or collapsed when the checkbox is toggled.")]
        public virtual string CheckboxName
        {
            get
            {
                return (string)this.ViewState["CheckboxName"] ?? "";
            }
            set
            {
                this.ViewState["CheckboxName"] = value;
            }
        }


        /// <summary>
        /// True to render a checkbox into the fieldset frame just in front of the legend (defaults to false). The fieldset will be expanded or collapsed when the checkbox is toggled.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. FieldSet")]
        [DefaultValue(false)]
        [Description("True to render a checkbox into the fieldset frame just in front of the legend (defaults to false). The fieldset will be expanded or collapsed when the checkbox is toggled.")]
        public virtual bool CheckboxToggle
        {
            get
            {
                object obj = this.ViewState["CheckboxToggle"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["CheckboxToggle"] = value;
            }
        }

        /// <summary>
        /// A css class to apply to the x-form-items of fields. This property cascades to child containers.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. FieldSet")]
        [DefaultValue("")]
        [Description("A css class to apply to the x-form-items of fields. This property cascades to child containers.")]
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

        /// <summary>
        /// The width of labels. This property cascades to child containers.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. FieldSet")]
        [DefaultValue(75)]
        [Description("The width of labels. This property cascades to child containers.")]
        public override int LabelWidth
        {
            get
            {
                object obj = this.ViewState["LabelWidth"];
                return (obj == null) ? 75 : (int)obj;
            }
            set
            {
                this.ViewState["LabelWidth"] = value;
            }
        }

        /// <summary>
        /// The Ext.Container.layout to use inside the fieldset (defaults to 'FormLayout').
        /// </summary>
        [Meta]
        [Category("5. Container")]
        [DefaultValue("form")]
        [TypeConverter(typeof(LayoutConverter))]
        [Description("The Ext.Container.layout to use inside the fieldset (defaults to 'form').")]
        public override string Layout
        {
            get
            {
                return (string)this.ViewState["Layout"] ?? "form";
            }
            set
            {
                this.ViewState["Layout"] = value;
            }
        }
    }
}