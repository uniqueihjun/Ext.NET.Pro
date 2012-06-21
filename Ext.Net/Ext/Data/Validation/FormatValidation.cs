/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing.Design;

namespace Ext.Net
{
    /// <summary>
    /// Returns true if the given value passes validation against the configured matcher regex
    /// </summary>
    [Meta]
    public partial class FormatValidation : AbstractValidation
    {
        /// <summary>
        /// 
        /// </summary>
        public FormatValidation()
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
                return "format";
            }
        }

        /// <summary>
        /// A JavaScript RegExp object to be tested against the value
        /// </summary>
        [Meta]
        [ConfigOption(typeof(RegexJsonConverter))]
        [DefaultValue("")]
        [Editor("System.Web.UI.Design.WebControls.RegexTypeEditor", typeof(UITypeEditor))]
        [Description("A JavaScript RegExp object to be tested against the value")]
        public virtual string Regex
        {
            get
            {
                return this.State.Get<string>("Regex", "");
            }
            set
            {
                this.State.Set("Regex", value);
            }
        }
    }
}
