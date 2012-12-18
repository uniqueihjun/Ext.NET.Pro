/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Ext.Net
{
    public partial class Checkbox
    {
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        [Description("")]
        public virtual string DirectCheckAction
        {
            get
            {
                return this.DirectEvents.Change.Action;
            }
            set
            {
                this.DirectEvents.Change.Action = value;
            }
        }
    }
}