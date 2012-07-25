/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Mapping of action name to HTTP request method.
    /// </summary>
    [Meta]
    public partial class CRUDMethods : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        public CRUDMethods()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(HttpMethod.Default)]
        [NotifyParentProperty(true)]
        [Description("")]        
        public HttpMethod Create
        {
            get
            {
                return this.State.Get<HttpMethod>("Create", HttpMethod.Default);
            }
            set
            {
                this.State.Set("Create", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(HttpMethod.Default)]
        [NotifyParentProperty(true)]
        [Description("")]
        public HttpMethod Read
        {
            get
            {
                return this.State.Get<HttpMethod>("Read", HttpMethod.Default);
            }
            set
            {
                this.State.Set("Read", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(HttpMethod.Default)]
        [NotifyParentProperty(true)]
        [Description("")]
        public HttpMethod Update
        {
            get
            {
                return this.State.Get<HttpMethod>("Update", HttpMethod.Default);
            }
            set
            {
                this.State.Set("Update", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(HttpMethod.Default)]
        [NotifyParentProperty(true)]
        [Description("")]
        public HttpMethod Destroy
        {
            get
            {
                return this.State.Get<HttpMethod>("Destroy", HttpMethod.Default);
            }
            set
            {
                this.State.Set("Destroy", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override bool IsDefault
        {
            get
            {
                return this.Create == HttpMethod.Default &&
                       this.Read == HttpMethod.Default &&
                       this.Update == HttpMethod.Default &&
                       this.Destroy == HttpMethod.Default;
            }
        }
    }
}
