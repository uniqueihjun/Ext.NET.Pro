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
    /// 
    /// </summary>
    [Meta]
    public partial class ScaleAttribute : TranslateAttribute
    {
        public ScaleAttribute()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("cx")]
        [DefaultValue(null)]
        [Description("")]
        public virtual double? CX
        {
            get
            {
                return this.State.Get<double?>("CX", null);
            }
            set
            {
                this.State.Set("CX", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("cy")]
        [DefaultValue(null)]
        [Description("")]
        public virtual double? CY
        {
            get
            {
                return this.State.Get<double?>("CY", null);
            }
            set
            {
                this.State.Set("CY", value);
            }
        }
    }
}
