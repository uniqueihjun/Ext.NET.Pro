/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Provides tips for Ext.chart.series.Series.
    /// </summary>
    [Meta]
    public partial class ChartTip : ToolTip
    {
        /// <summary>
        /// 
        /// </summary>
        public ChartTip()
        {
        }

        private JFunction renderer;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("")]
        public virtual JFunction Renderer
        {
            get
            {
                if (this.renderer == null)
                {
                    this.renderer = new JFunction();
                    if (!this.DesignMode)
                    {
                        this.renderer.Args = new string[] { "storeItem", "item" };
                    }
                }

                return this.renderer;
            }
        }

        /// <summary>
        /// If true, then the tooltip will be automatically constrained to stay within the browser viewport. Defaults to: false
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. Tip")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("If true, then the tooltip will be automatically constrained to stay within the browser viewport. Defaults to: false")]
        public override bool ConstrainPosition
        {
            get
            {
                return this.State.Get<bool>("ConstrainPosition", false);
            }
            set
            {
                this.State.Set("ConstrainPosition", value);
            }
        }
    }
}
