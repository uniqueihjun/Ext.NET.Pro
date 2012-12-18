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
    public partial class AppInit
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public AppInit(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit AppInit.Config Conversion to AppInit
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppInit(AppInit.Config config)
        {
            return new AppInit(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit AppInit.Config Conversion to AppInit.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator AppInit.Builder(AppInit.Config config)
			{
				return new AppInit.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool autoInit = true;

			/// <summary>
			/// False to deactivate auto start of init script
			/// </summary>
			[DefaultValue(true)]
			public virtual bool AutoInit 
			{ 
				get
				{
					return this.autoInit;
				}
				set
				{
					this.autoInit = value;
				}
			}

			private string initFnName = "initFn";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("initFn")]
			public virtual string InitFnName 
			{ 
				get
				{
					return this.initFnName;
				}
				set
				{
					this.initFnName = value;
				}
			}

        }
    }
}