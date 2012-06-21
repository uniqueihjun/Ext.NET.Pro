/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// This feature is used to place a summary row at the bottom of the grid. If using a grouping, see Ext.grid.feature.GroupingSummary. There are 2 aspects to calculating the summaries, calculation and rendering.
    /// 
    /// Calculation
    /// The summary value needs to be calculated for each column in the grid. This is controlled by the summaryType option specified on the column. There are several built in summary types, which can be specified as a string on the column configuration. These call underlying methods on the store:
    /// 
    /// count
    /// sum
    /// min
    /// max
    /// average
    /// Alternatively, the summaryType can be a function definition. If this is the case, the function is called with an array of records to calculate the summary value.
    /// 
    /// Rendering
    /// Similar to a column, the summary also supports a summaryRenderer function. This summaryRenderer is called before displaying a value. The function is optional, if not specified the default calculated value is shown. The summaryRenderer is called with:
    /// 
    /// value {Object} - The calculated value.
    /// summaryData {Object} - Contains all raw summary values for the row.
    /// field {String} - The name of the field we are calculating
    /// </summary>
    [Meta]
    public partial class Summary : AbstractSummary
    {
        /// <summary>
        /// 
        /// </summary>
        public Summary()
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
                return "Ext.grid.feature.Summary";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [ConfigOption("ftype")]
        [DefaultValue("")]
        [Description("")]
        protected override string FType
        {
            get
            {
                return "summary";
            }
        }
    }
}
