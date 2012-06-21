/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    [Meta]
    public partial class RadialAxis : AbstractAxis
    {
        /// <summary>
        /// 
        /// </summary>
        public RadialAxis()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]        
        public virtual string Type
        {
            get
            {
                return "Radial";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        public virtual string Position
        {
            get
            {
                return "radial";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(0)]
        [Description("")]
        public virtual int Steps
        {
            get
            {
                return this.State.Get<int>("Steps", 0);
            }
            set
            {
                this.State.Set("Steps", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(0)]
        [Description("")]
        public virtual int Maximum
        {
            get
            {
                return this.State.Get<int>("Maximum", 0);
            }
            set
            {
                this.State.Set("Maximum", value);
            }
        }
    }
}
