/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public abstract partial class ControllerBase : Observable
    {
        /// <summary>
        /// Array of models to require from AppName.model namespace.
        /// </summary>
        [Meta]
        [ConfigOption(typeof(StringArrayJsonConverter))]
        [TypeConverter(typeof(StringArrayConverter))]
        [Category("3. Controller")]
        [DefaultValue(null)]
        [Description("Array of models to require from AppName.model namespace.")]
        public virtual string[] Models
        {
            get
            {
                return this.State.Get<string[]>("Models", null);
            }
            set
            {
                this.State.Set("Models", value);
            }
        }

        /// <summary>
        /// Array of stores to require from AppName.store namespace.
        /// </summary>
        [Meta]
        [ConfigOption(typeof(StringArrayJsonConverter))]
        [TypeConverter(typeof(StringArrayConverter))]
        [Category("3. Controller")]
        [DefaultValue(null)]
        [Description("Array of stores to require from AppName.store namespacee.")]
        public virtual string[] Stores
        {
            get
            {
                return this.State.Get<string[]>("Stores", null);
            }
            set
            {
                this.State.Set("Stores", value);
            }
        }

        /// <summary>
        /// Array of stores to require from AppName.store namespace.
        /// </summary>
        [Meta]
        [ConfigOption(typeof(StringArrayJsonConverter))]
        [TypeConverter(typeof(StringArrayConverter))]
        [Category("3. Controller")]
        [DefaultValue(null)]
        [Description("Array of stores to require from AppName.store namespacee.")]
        public virtual string[] Views
        {
            get
            {
                return this.State.Get<string[]>("Stores", null);
            }
            set
            {
                this.State.Set("Stores", value);
            }
        }

        /// <summary>
        /// The controller name. Required
        /// </summary>
        [Meta]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Description("The controller name. Required")]
        public virtual string Name
        {
            get
            {
                return this.State.Get<string>("Name", null);
            }
            set
            {
                this.State.Set("Name", value);
            }
        }
    }
}
