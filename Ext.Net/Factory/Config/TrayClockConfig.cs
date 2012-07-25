/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TrayClock
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TrayClock(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TrayClock.Config Conversion to TrayClock
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrayClock(TrayClock.Config config)
        {
            return new TrayClock(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ToolbarTextItem.Config 
        { 
			/*  Implicit TrayClock.Config Conversion to TrayClock.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TrayClock.Builder(TrayClock.Config config)
			{
				return new TrayClock.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string timeFormat = "t";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("t")]
			public virtual string TimeFormat 
			{ 
				get
				{
					return this.timeFormat;
				}
				set
				{
					this.timeFormat = value;
				}
			}

			private string template = "{time}";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("{time}")]
			public virtual string Template 
			{ 
				get
				{
					return this.template;
				}
				set
				{
					this.template = value;
				}
			}

			private int refreshInterval = 10000;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(10000)]
			public virtual int RefreshInterval 
			{ 
				get
				{
					return this.refreshInterval;
				}
				set
				{
					this.refreshInterval = value;
				}
			}

        }
    }
}