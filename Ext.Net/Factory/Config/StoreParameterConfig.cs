/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class StoreParameter
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public StoreParameter(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit StoreParameter.Config Conversion to StoreParameter
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StoreParameter(StoreParameter.Config config)
        {
            return new StoreParameter(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Parameter.Config 
        { 
			/*  Implicit StoreParameter.Config Conversion to StoreParameter.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator StoreParameter.Builder(StoreParameter.Config config)
			{
				return new StoreParameter.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private ApplyMode applyMode = ApplyMode.Always;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(ApplyMode.Always)]
			public virtual ApplyMode ApplyMode 
			{ 
				get
				{
					return this.applyMode;
				}
				set
				{
					this.applyMode = value;
				}
			}

			private StoreAction? action = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual StoreAction? Action 
			{ 
				get
				{
					return this.action;
				}
				set
				{
					this.action = value;
				}
			}

        }
    }
}