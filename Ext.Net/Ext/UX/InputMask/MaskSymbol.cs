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
    public partial class MaskSymbol : BaseItem
    {
        public MaskSymbol()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [Description("")]
        public virtual string Name
        {
            get
            {
                return this.State.Get<string>("Name", "");
            }
            set
            {
                this.State.Set("Name", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [Description("")]
        public virtual string Regex
        {
            get
            {
                return this.State.Get<string>("Regex", "");
            }
            set
            {
                this.State.Set("Regex", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(null)]
        [Description("")]
        public virtual char? Placeholder
        {
            get
            {
                return this.State.Get<char?>("Placeholder", null);
            }
            set
            {
                this.State.Set("Placeholder", value);
            }
        }
    }
}