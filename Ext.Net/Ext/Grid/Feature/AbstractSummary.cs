/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// A small abstract class that contains the shared behaviour for any summary calculations to be used in the grid.
    /// </summary>
    [Meta]
    public abstract partial class AbstractSummary : GridFeature
    {
        /// <summary>
        /// True to show the summary row. Defaults to true.
        /// </summary>
        [Meta]
        [DirectEventUpdate(Script = "{0}.toggleSummaryRow({1});")]
        [ConfigOption]
        [DefaultValue(true)]
        [Description("true to add css for column separation lines. Default is false.")]
        public virtual bool ShowSummaryRow
        {
            get
            {
                return this.State.Get<bool>("ShowSummaryRow", true);
            }
            set
            {
                this.State.Set("ShowSummaryRow", value);
            }
        }
    }
}
