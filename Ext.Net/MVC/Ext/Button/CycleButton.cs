/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.ComponentModel;
using System.Web.Mvc;

namespace Ext.Net
{
    public partial class CycleButton
    {
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        [Description("")]
        public virtual string DirectChangeAction
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