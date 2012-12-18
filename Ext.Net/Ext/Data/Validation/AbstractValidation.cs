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
    /// Abstract validation type
    /// </summary>
    [Meta]
    public abstract partial class AbstractValidation : BaseItem
    {
        /// <summary>
        /// Alias
        /// </summary>
        [ConfigOption]
        [DefaultValue(null)]
        protected abstract string Type
        {
            get;
        }

        /// <summary>
        /// The name of the field to validate
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(null)]
        [Description("The name of the field to validate")]
        public virtual string Field
        {
            get
            {
                return this.State.Get<string>("Field", null);
            }
            set
            {
                this.State.Set("Field", value);
            }
        }

        /// <summary>
        /// The error message used when a validation fails
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(null)]
        [Description("The error message used when a validation fails")]
        public virtual string Message
        {
            get
            {
                return this.State.Get<string>("Message", null);
            }
            set
            {
                this.State.Set("Message", value);
            }
        }
    }
}
