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
    public partial class RowBody
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RowBody(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RowBody.Config Conversion to RowBody
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RowBody(RowBody.Config config)
        {
            return new RowBody(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridFeature.Config 
        { 
			/*  Implicit RowBody.Config Conversion to RowBody.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RowBody.Builder(RowBody.Config config)
			{
				return new RowBody.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string rowBodyHiddenCls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RowBodyHiddenCls 
			{ 
				get
				{
					return this.rowBodyHiddenCls;
				}
				set
				{
					this.rowBodyHiddenCls = value;
				}
			}

			private string rowBodyTrCls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RowBodyTrCls 
			{ 
				get
				{
					return this.rowBodyTrCls;
				}
				set
				{
					this.rowBodyTrCls = value;
				}
			}

			private string rowBodyTdCls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RowBodyTdCls 
			{ 
				get
				{
					return this.rowBodyTdCls;
				}
				set
				{
					this.rowBodyTdCls = value;
				}
			}

			private string rowBodyDivCls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RowBodyDivCls 
			{ 
				get
				{
					return this.rowBodyDivCls;
				}
				set
				{
					this.rowBodyDivCls = value;
				}
			}

        }
    }
}