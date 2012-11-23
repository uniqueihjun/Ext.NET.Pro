/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.ComponentModel;

namespace Ext.Net
{
    [Meta]
    public partial class AppInit : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        public AppInit()
        {
        }

        /// <summary>
        /// False to deactivate auto start of init script
        /// </summary>
        [Meta]
        [DefaultValue(true)]
        [Description("False to deactivate auto start of init script")]
        public virtual bool AutoInit
        {
            get
            {
                return this.State.Get("AutoInit", true);
            }
            set
            {
                this.State.Set("AutoInit", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue("initFn")]
        [Description("")]
        public virtual string InitFnName
        {
            get
            {
                return this.State.Get("InitFnName", "initFn");
            }
            set
            {
                this.State.Set("InitFnName", value);
            }
        }
    }
}