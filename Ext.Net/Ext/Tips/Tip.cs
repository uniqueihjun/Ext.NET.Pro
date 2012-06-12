/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public abstract partial class Tip : PanelBase
    {
        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.Tip";
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Description("")]
        public override string RenderTo
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
        public override string ApplyTo
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// True to use height:'auto', false to use fixed height (defaults to false).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("4. BoxComponent")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to use height:'auto', false to use fixed height (defaults to true).")]
        public override bool AutoHeight
        {
            get
            {
                object obj = this.ViewState["AutoHeight"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["AutoHeight"] = value;
            }
        }

        /// <summary>
        /// True to render a close tool button into the tooltip header (defaults to false).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. Tip")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True to render a close tool button into the tooltip header (defaults to false).")]
        public override bool Closable
        {
            get
            {
                object obj = this.ViewState["Closable"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["Closable"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. Tip")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool ConstrainPosition
        {
            get
            {
                object obj = this.ViewState["ConstrainPosition"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["ConstrainPosition"] = value;
            }
        }

        /// <summary>
        /// Experimental. The default Ext.Element.alignTo anchor position value for this tip relative to its element of origin (defaults to 'tl-bl?').
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. Tip")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Experimental. The default Ext.Element.alignTo anchor position value for this tip relative to its element of origin (defaults to 'tl-bl?').")]
        public virtual string DefaultAlign
        {
            get
            {
                return (string)this.ViewState["DefaultAlign"] ?? "";
            }
            set
            {
                this.ViewState["DefaultAlign"] = value;
            }
        }

        /// <summary>
        /// The maximum width of the tip in pixels (defaults to 300). The maximum supported value is 500.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. Tip")]
        [DefaultValue(typeof(Unit), "300")]
        [NotifyParentProperty(true)]
        [Description("The maximum width of the tip in pixels (defaults to 300). The maximum supported value is 500.")]
        public override Unit MaxWidth
        {
            get
            {
                return this.UnitPixelTypeCheck(ViewState["MaxWidth"], Unit.Pixel(300), "MaxWidth");
            }
            set
            {
                this.ViewState["MaxWidth"] = value;
            }
        }

        /// <summary>
        /// The minimum width of the tip in pixels (defaults to 40).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. Tip")]
        [DefaultValue(typeof(Unit), "40")]
        [NotifyParentProperty(true)]
        [Description("The minimum width of the tip in pixels (defaults to 40).")]
        public override Unit MinWidth
        {
            get
            {
                return this.UnitPixelTypeCheck(ViewState["MinWidth"], Unit.Pixel(40), "MinWidth");
            }
            set
            {
                this.ViewState["MinWidth"] = value;
            }
        }


        /*  Public Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Shows this tip at the specified XY position.
        /// </summary>
        [Meta]
        [Description("Shows this tip at the specified XY position.")]
        public virtual void ShowAt(Unit x, Unit y)
        {
            this.Call("showAt", new int[] { Convert.ToInt32(x.Value), Convert.ToInt32(y.Value) });
        }

        /// <summary>
        /// Experimental. Shows this tip at a position relative to another element using a standard Ext.Element.alignTo anchor position value.
        /// </summary>
        [Meta]
        [Description("Experimental. Shows this tip at a position relative to another element using a standard Ext.Element.alignTo anchor position value.")]
        public virtual void ShowBy(string id)
        {
            this.Call("showBy", id);
        }

        /// <summary>
        /// Experimental. Shows this tip at a position relative to another element using a standard Ext.Element.alignTo anchor position value.
        /// </summary>
        [Meta]
        [Description("Experimental. Shows this tip at a position relative to another element using a standard Ext.Element.alignTo anchor position value.")]
        public virtual void ShowBy(string id, string position)
        {
            this.Call("showBy", id, position);
        }
    }
}