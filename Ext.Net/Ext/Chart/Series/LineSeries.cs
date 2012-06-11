/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Web.UI;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Creates a Line Chart. A Line Chart is a useful visualization technique to display quantitative information for different categories or other real values (as opposed to the bar chart), that can show some progression (or regression) in the dataset. As with all other series, the Line Series must be appended in the series Chart array configuration.
    /// Note: In the series definition remember to explicitly set the axis to bind the values of the line series to. This can be done by using the axis configuration property.
    /// </summary>
    [Meta]
    public partial class LineSeries : CartesianSeries
    {
        /// <summary>
        /// 
        /// </summary>
        public LineSeries()
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
                return "line";
            }
        }

        /// <summary>
        /// If true, the area below the line will be filled in using the eefill and opacity config properties. Defaults to false.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [Description("If true, the area below the line will be filled in using the eefill and opacity config properties. Defaults to false.")]
        public virtual bool Fill
        {
            get
            {
                return this.State.Get<bool>("Fill", false);
            }
            set
            {
                this.State.Set("Fill", value);
            }
        }

        /// <summary>
        /// Whether markers should be displayed at the data points along the line. If true, then the markerConfig config item will determine the markers' styling. Defaults to: true
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(true)]
        [Description("Whether markers should be displayed at the data points along the line. If true, then the markerConfig config item will determine the markers' styling. Defaults to: true")]
        public virtual bool ShowMarkers
        {
            get
            {
                return this.State.Get<bool>("ShowMarkers", true);
            }
            set
            {
                this.State.Set("ShowMarkers", value);
            }
        }

        private SpriteAttributes markerConfig;

        /// <summary>
        /// The display style for the markers. Only used if showMarkers is true. The markerConfig is a configuration object containing the same set of properties defined in the Sprite class.
        /// </summary>
        [Meta]
        [ConfigOption("markerConfig", JsonMode.Object)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public SpriteAttributes MarkerConfig
        {
            get
            {
                return this.markerConfig;
            }
            set
            {
                this.markerConfig = value;
            }
        }

        /// <summary>
        /// The offset distance from the cursor position to the line series to trigger events (then used for highlighting series, etc). Defaults to: 20
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(20)]
        [Description("The offset distance from the cursor position to the line series to trigger events (then used for highlighting series, etc). Defaults to: 20")]
        public virtual int SelectionTolerance
        {
            get
            {
                return this.State.Get<int>("SelectionTolerance", 20);
            }
            set
            {
                this.State.Set("SelectionTolerance", value);
            }
        }

        /// <summary>
        /// If set to a non-zero number, the line will be smoothed/rounded around its points; otherwise straight line segments will be drawn.
        /// A numeric value is interpreted as a divisor of the horizontal distance between consecutive points in the line; larger numbers result in sharper curves while smaller numbers result in smoother curves.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(0)]
        [Description("If set to a non-zero number, the line will be smoothed/rounded around its points; otherwise straight line segments will be drawn.")]
        public virtual int Smooth
        {
            get
            {
                return this.State.Get<int>("Smooth", 0);
            }
            set
            {
                this.State.Set("Smooth", value);
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
