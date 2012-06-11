/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Creates a Column Chart. Much of the methods are inherited from Bar. A Column Chart is a useful visualization technique to display quantitative information for different categories that can show some progression (or regression) in the data set. As with all other series, the Column Series must be appended in the series Chart array configuration.
    /// </summary>
    [Meta]
    public partial class ColumnSeries : BarSeries
    {
        /// <summary>
        /// 
        /// </summary>
        public ColumnSeries()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        protected override string Type
        {
            get
            {
                return "column";
            }
        }

        /// <summary>
        /// Padding between the left/right axes and the bars. Defaults to: 10
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(10)]
        [Description("Padding between the left/right axes and the bars. Defaults to: 10")]
        public override int XPadding
        {
            get
            {
                return this.State.Get<int>("XPadding", 10);
            }
            set
            {
                this.State.Set("XPadding", value);
            }
        }

        /// <summary>
        /// Padding between the top/bottom axes and the bars. Defaults to: 0
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(0)]
        [Description("Padding between the top/bottom axes and the bars. Defaults to: 0")]
        public override int YPadding
        {
            get
            {
                return this.State.Get<int>("YPadding", 0);
            }
            set
            {
                this.State.Set("YPadding", value);
            }
        }
    }
}
