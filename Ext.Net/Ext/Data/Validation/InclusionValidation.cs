/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// Validates that the given value is present in the configured list
    /// </summary>
    [Meta]
    public partial class InclusionValidation : AbstractValidation
    {
        /// <summary>
        /// 
        /// </summary>
        public InclusionValidation()
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
                return "inclusion";
            }
        }

        /// <summary>
        /// The list of options
        /// </summary>
        [TypeConverter(typeof(StringArrayConverter))]
        [ConfigOption(JsonMode.Array)]
        [DefaultValue(null)]
        [Description("The list of options")]
        public virtual string[] List
        {
            get
            {
                return this.State.Get<string[]>("List", null);
            }
            set
            {
                this.State.Set("List", value);
            }
        }

    }
}
