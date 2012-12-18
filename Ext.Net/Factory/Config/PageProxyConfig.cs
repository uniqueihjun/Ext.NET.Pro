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
    public partial class PageProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public PageProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit PageProxy.Config Conversion to PageProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PageProxy(PageProxy.Config config)
        {
            return new PageProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ServerProxy.Config 
        { 
			/*  Implicit PageProxy.Config Conversion to PageProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator PageProxy.Builder(PageProxy.Config config)
			{
				return new PageProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int total = 0;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(0)]
			public virtual int Total 
			{ 
				get
				{
					return this.total;
				}
				set
				{
					this.total = value;
				}
			}

			private string directFn = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string DirectFn 
			{ 
				get
				{
					return this.directFn;
				}
				set
				{
					this.directFn = value;
				}
			}
        
			private BaseDirectEvent requestConfig = null;

			/// <summary>
			/// 
			/// </summary>
			public BaseDirectEvent RequestConfig
			{
				get
				{
					if (this.requestConfig == null)
					{
						this.requestConfig = new BaseDirectEvent();
					}
			
					return this.requestConfig;
				}
			}
			
        }
    }
}