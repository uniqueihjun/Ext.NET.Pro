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
    public partial class LengthValidationAttribute : AbstractValidationAttribute
    {
        private int maxValue = int.MaxValue;
        private int minValue = int.MinValue;

        /// <summary>
        /// Maximum value length allowed.
        /// </summary>
        [DefaultValue(int.MaxValue)]
        public virtual int Max
        {
            get
            {
                return this.maxValue;
            }
            set
            {
                this.maxValue = value;
            }
        }

        /// <summary>
        /// Minimum value length allowed.
        /// </summary>
        [DefaultValue(int.MinValue)]
        public virtual int Min
        {
            get
            {
                return this.minValue;
            }
            set
            {
                this.minValue = value;
            }
        }

        protected override AbstractValidation CreateValidation()
        {
            return new LengthValidation { Max = this.Max, Min = this.Min };
        }
    }
}