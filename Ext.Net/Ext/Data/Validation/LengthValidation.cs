/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Returns true if the given value is between the configured min and max values
    /// </summary>
    [Meta]
    public partial class LengthValidation : AbstractValidation
    {
        /// <summary>
        /// 
        /// </summary>
        public LengthValidation()
        {
        }

        /// <summary>
        /// Alias
        /// </summary>
        [ConfigOption]
        [DefaultValue(null)]
        protected override string Type
        {
            get
            {
                return "length";
            }
        }

        /// <summary>
        /// Maximum value length allowed.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(int.MaxValue)]
        [Description("Maximum value length allowed.")]
        public virtual int Max
        {
            get
            {
                return this.State.Get<int>("Max", int.MaxValue);
            }
            set
            {
                this.State.Set("Max", value);
            }
        }

        /// <summary>
        /// Minimum value length allowed.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(int.MinValue)]
        [Description("Minimum value length allowed.")]
        public virtual int Min
        {
            get
            {
                return this.State.Get<int>("Min", int.MinValue);
            }
            set
            {
                this.State.Set("Min", value);
            }
        }
    }
}
