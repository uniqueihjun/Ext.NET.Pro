/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Wraps a Slider so it can be used as a form field.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:SliderField runat=\"server\" />")]
    [SupportsEventValidation]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(SliderField), "Build.ToolboxIcons.Slider.bmp")]
    [Description("Basic Label field.")]
    public partial class SliderField : Field
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public SliderField() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.form.SliderField";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "sliderfield";
            }
        }

        private Slider slider;

        /// <summary>
        /// Slider object config
        /// </summary>
        [Meta]
        [ConfigOption("slider", typeof(LazyControlJsonConverter))]
        [Category("5. SliderField")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Slider object config")]
        public Slider Slider
        {
            get
            {
                if(this.slider == null)
                {
                    this.slider = new Slider();
                }

                return this.slider;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void CreateChildControls()
        {
            this.Controls.Add(this.Slider);
            this.LazyItems.Add(this.Slider);
        }
    }
}