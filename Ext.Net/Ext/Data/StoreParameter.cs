/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class StoreParameter : Parameter
    {
        /// <summary>
        /// 
        /// </summary>
        public StoreParameter()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public StoreParameter(string name, string value) : base(name, value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="mode"></param>
        public StoreParameter(string name, string value, ParameterMode mode) : base(name, value, mode)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="encode"></param>
        public StoreParameter(string name, string value, bool encode) : base(name, value, encode)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="mode"></param>
        /// <param name="encode"></param>
        public StoreParameter(string name, string value, ParameterMode mode, bool encode) : base(name, value, mode, encode)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue(ApplyMode.Always)]
        [Description("")]
        public virtual ApplyMode ApplyMode
        {
            get
            {
                return this.State.Get<ApplyMode>("ApplyMode", ApplyMode.Always);
            }
            set
            {
                this.State.Set("ApplyMode", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue(null)]
        [Description("")]
        public virtual StoreAction? Action
        {
            get
            {
                return this.State.Get<StoreAction?>("Action", null);
            }
            set
            {
                this.State.Set("Action", value);
            }
        }
    }
}
