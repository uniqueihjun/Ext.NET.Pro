/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Gauge Axis is the axis to be used with a Gauge series. The Gauge axis displays numeric data from an interval defined by the minimum, maximum and step configuration properties. The placement of the numeric data can be changed by altering the margin option that is set to 10 by default.
    /// </summary>
    [Meta]
    public partial class GaugeAxis : AbstractAxis
    {
        /// <summary>
        /// 
        /// </summary>
        public GaugeAxis()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        public virtual string Type
        {
            get
            {
                return "Gauge";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        public virtual string Position
        {
            get
            {
                return "gauge";
            }
        }

        /// <summary>
        /// The offset positioning of the tick marks and labels in pixels. Defaults to: 10
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(10)]
        [Description("The offset positioning of the tick marks and labels in pixels. Defaults to: 10")]
        public virtual int Margin
        {
            get
            {
                return this.State.Get<int>("Margin", 10);
            }
            set
            {
                this.State.Set("Margin", value);
            }
        }

        /// <summary>
        /// The maximum value of the interval to be displayed in the axis (REQUIRED).
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(null)]
        [Description("The maximum value of the interval to be displayed in the axis (REQUIRED).")]
        public virtual int? Maximum
        {
            get
            {
                return this.State.Get<int?>("Maximum", null);
            }
            set
            {
                this.State.Set("Maximum", value);
            }
        }

        /// <summary>
        /// The minimum value of the interval to be displayed in the axis (REQUIRED).
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(null)]
        [Description("The minimum value of the interval to be displayed in the axis (REQUIRED).")]
        public virtual int? Minimum
        {
            get
            {
                return this.State.Get<int?>("Minimum", null);
            }
            set
            {
                this.State.Set("Minimum", value);
            }
        }

        /// <summary>
        /// The number of steps and tick marks to add to the interval. (REQUIRED).
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(null)]
        [Description("The number of steps and tick marks to add to the interval. (REQUIRED).")]
        public virtual int? Steps
        {
            get
            {
                return this.State.Get<int?>("Minimum", null);
            }
            set
            {
                this.State.Set("Minimum", value);
            }
        }

        /// <summary>
        /// The title for the Axis.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(null)]
        [Description("The title for the Axis.")]
        public virtual string Title
        {
            get
            {
                return this.State.Get<string>("Title", null);
            }
            set
            {
                this.State.Set("Title", value);
            }
        }

        /// <summary>
        /// Updates the title of this axis.
        /// </summary>
        /// <param name="title"></param>
        public virtual void SetTitle(string title)
        {
            var chart = this.Owner as Chart;
            if (chart == null)
            {
                throw new Exception("Axis has no a chart reference");
            }

            var index = chart.Axes.IndexOf(this);
            chart.AddScript("{0}.axes[{1}].setTitle({2});", chart.ClientID, index, JSON.Serialize(title));
        }
    }
}
