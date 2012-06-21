/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class BaseControl
    {
        /// <summary>
        /// 
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string ToolTip
        {
            get { return base.ToolTip; }
            set { base.ToolTip = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string AccessKey
        {
            get { return base.AccessKey; }
            set { base.AccessKey = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BorderColor
        {
            get { return base.BorderColor; }
            set { base.BorderColor = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override System.Web.UI.WebControls.BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override System.Web.UI.WebControls.Unit BorderWidth
        {
            get { return base.BorderWidth; }
            set { base.BorderWidth = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string CssClass
        {
            get { return base.CssClass; }
            set { base.CssClass = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override System.Web.UI.WebControls.FontInfo Font
        {
            get { return base.Font; }
        }

        /// <summary>
        /// 
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override Unit Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Height = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override Unit Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Width = value;
            }
        }
    }
}