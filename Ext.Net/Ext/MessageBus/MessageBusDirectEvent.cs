/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MessageBusDirectEvent : ComponentDirectEvent
    {
        /// <summary>
        /// 
        /// </summary>
        public MessageBusDirectEvent()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string Bus
        {
            get
            {
                return this.State.Get<string>("Bus", "");
            }
            set
            {
                this.State.Set("Bus", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue("**")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string Name
        {
            get
            {
                return this.State.Get<string>("Name", "**");
            }
            set
            {
                this.State.Set("Name", value);
            }
        }
    }
}