/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("")]
    public partial class DatePickerOptions : DatePicker
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DatePickerOptions() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "";
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
                return "";
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Description("")]
        public override bool AutoPostBack
        {
            get { return base.AutoPostBack; }
            set { base.AutoPostBack = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Description("")]
        public override bool CausesValidation
        {
            get { return base.CausesValidation; }
            set { base.CausesValidation = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Description("")]
        public override string ValidationGroup
        {
            get { return base.ValidationGroup; }
            set { base.ValidationGroup = value; }
        }

		/// <summary>
		/// 
		/// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public override DateTime SelectedDate
        {
            get { return base.SelectedDate; }
            set { base.SelectedDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ConfigOption(JsonMode.Ignore)]
        public override string ApplyTo
        {
            get { return base.ApplyTo; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ConfigOption(JsonMode.Ignore)]
        protected override string ConfigIDProxy
        {
            get { return base.ConfigIDProxy; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ConfigOption(JsonMode.Ignore)]
        public override string ID
        {
            get { return base.ID; }
            set { base.ID = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ConfigOption(JsonMode.Ignore)]
        public override string RenderTo
        {
            get { return base.RenderTo; }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Ignore)]
        protected internal override string RenderToProxy
        {
            get
            {
                return "";
            }
        }

		/// <summary>
		/// 
		/// </summary>		
        [Description("")]
        protected override void Render(HtmlTextWriter writer) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void OnPreRender(EventArgs e) { }
    }
}
