/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Web.UI;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// See
    /// http://www.openajax.org/member/wiki/OpenAjax_Hub_2.0_Specification
    /// http://www.openajax.org/member/wiki/OpenAjax_Hub_2.0_Specification_Topic_Names
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:MessageBus runat=\"server\"></{0}:MessageBus>")]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [Designer(typeof(EmptyDesigner))]
    [Description("")]
    public partial class MessageBus : LazyObservable, IVirtual
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public MessageBus() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.net.MessageBus";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool DefaultBus
        {
            get
            {
                return this.State.Get<bool>("DefaultBus", false);
            }
            set
            {
                this.State.Set("DefaultBus", value);
            }
        }

        public static MessageBus Default
        {
            get
            {
                var bus = new MessageBus { ID = "Ext.net.Bus", IsProxy = true, Namespace = "" };

                if (X.ResourceManager == null)
                {
                    bus.GenerateMethodsCalling = true;
                }

                bus.AllowCallbackScriptMonitoring = true;

                return bus;
            }
        }

        /*  Public Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fn"></param>
        public virtual void Subscribe(string name, JFunction fn)
        {
            this.Call("subscribe", name, new JRawValue(fn.ToScript()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fn"></param>
        /// <param name="options"></param>
        public virtual void Subscribe(string name, JFunction fn, HandlerConfig options)
        {
            this.Call("subscribe", name, new JRawValue(fn.ToScript()), new JRawValue(options.Serialize()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="data"></param>
        public virtual void Publish(string name, object data)
        {
            this.Call("publish", name, data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public virtual void Publish(string name)
        {
            this.Call("publish", name);
        }
    }
}