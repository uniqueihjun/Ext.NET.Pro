/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Ext.Net
{
    public partial class Tool : ComponentBase
    {
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        [Description("")]
        public virtual string DirectClickAction
        {
            get
            {
                return this.DirectEvents.Click.Action;
            }
            set
            {
                this.DirectEvents.Click.Action = value;
            }
        }
    }
}