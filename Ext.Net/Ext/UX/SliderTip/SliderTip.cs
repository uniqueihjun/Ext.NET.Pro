/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Simple plugin for using an Ext.Tip with a slider to show the slider value.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(SliderTip), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:SliderTip runat=\"server\" />")]
    [Description("Simple plugin for using an Ext.Tip with a slider to show the slider value")]
    public partial class SliderTip : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        public SliderTip()
        {
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
                return "Ext.slider.Tip";
            }
        }

        private JFunction getText;

        /// <summary>
        /// Used to create the text that appears in the Tip's body. By default this just returns the value of the Slider Thumb that the Tip is attached to. Override to customize.
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("3. SliderTip")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("Override this function to apply custom tip text")]
        public virtual JFunction GetText
        {
            get
            {
                if (this.getText == null)
                {
                    this.getText = new JFunction();
                    if (!this.DesignMode)
                    {
                        this.getText.Args = new string[]{"thumb"};
                    }
                }
                
                return this.getText;
            }
        }
    }
}
