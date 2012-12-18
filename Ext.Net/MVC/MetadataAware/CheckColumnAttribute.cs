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
using System.Web.Mvc;
using System.ComponentModel;

namespace Ext.Net.MVC
{
    public partial class CheckColumnAttribute : ColumnBaseAttribute
    {
        private  bool stopSelection = true;

        //// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public virtual bool Editable
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public virtual bool SingleSelect
        {
            get;
            set;
        }

        /// <summary>
        /// Prevent grid selection upon mousedown.
        /// </summary>
        [DefaultValue(true)]
        public virtual bool StopSelection
        {
            get
            {
                return this.stopSelection;
            }
            set
            {
                this.stopSelection = value;
            }
        }
        
        protected override ColumnBase CreateColumn()
        {
            return new CheckColumn();
        }
    }
}