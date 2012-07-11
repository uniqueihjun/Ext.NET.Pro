/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Creates a Bar Chart. A Bar Chart is a useful visualization technique to display quantitative information for different categories that can show some progression (or regression) in the dataset. As with all other series, the Bar Series must be appended in the series Chart array configuration. 
    /// </summary>
    [Meta]
    public partial class BarSeries : CartesianSeries
    {
        /// <summary>
        /// 
        /// </summary>
        public BarSeries()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        protected virtual string Type
        {
            get
            {
                return "bar";
            }
        }

        /// <summary>
        /// Whether to set the visualization as column chart or horizontal bar chart.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [Description("Whether to set the visualization as column chart or horizontal bar chart.")]
        public virtual bool Column
        {
            get
            {
                return this.State.Get<bool>("Column", false);
            }
            set
            {
                this.State.Set("Column", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool Stacked
        {
            get
            {
                return this.State.Get<bool>("Stacked", false);
            }
            set
            {
                this.State.Set("Stacked", value);
            }
        }

        /// <summary>
        /// The gutter space between groups of bars, as a percentage of the bar width. Defaults to: 38.2
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(38.2d)]
        [Description("The gutter space between groups of bars, as a percentage of the bar width. Defaults to: 38.2")]
        public virtual double GroupGutter
        {
            get
            {
                return this.State.Get<double>("GroupGutter", 38.2d);
            }
            set
            {
                this.State.Set("GroupGutter", value);
            }
        }

        /// <summary>
        /// The gutter space between single bars, as a percentage of the bar width. Defaults to: 38.2
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(38.2d)]
        [Description("The gutter space between single bars, as a percentage of the bar width. Defaults to: 38.2")]
        public virtual double Gutter
        {
            get
            {
                return this.State.Get<double>("Gutter", 38.2d);
            }
            set
            {
                this.State.Set("Gutter", value);
            }
        }

        /// <summary>
        /// Padding between the left/right axes and the bars. Defaults to: 0
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(0)]
        [Description("Padding between the left/right axes and the bars. Defaults to: 0")]
        public virtual int XPadding
        {
            get
            {
                return this.State.Get<int>("XPadding", 0);
            }
            set
            {
                this.State.Set("XPadding", value);
            }
        }

        /// <summary>
        /// Padding between the top/bottom axes and the bars. Defaults to: 10
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(10)]
        [Description("Padding between the top/bottom axes and the bars. Defaults to: 10")]
        public virtual int YPadding
        {
            get
            {
                return this.State.Get<int>("YPadding", 10);
            }
            set
            {
                this.State.Set("YPadding", value);
            }
        }

        private SpriteAttributes style;

        /// <summary>
        /// An object containing styles for overriding series styles from Theming.
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Object)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public SpriteAttributes Style
        {
            get
            {
                return this.style;
            }
            set
            {
                this.style = value;
            }
        }
    }
}
