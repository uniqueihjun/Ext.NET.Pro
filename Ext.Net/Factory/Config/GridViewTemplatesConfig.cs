/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class GridViewTemplates
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GridViewTemplates(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GridViewTemplates.Config Conversion to GridViewTemplates
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GridViewTemplates(GridViewTemplates.Config config)
        {
            return new GridViewTemplates(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit GridViewTemplates.Config Conversion to GridViewTemplates.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GridViewTemplates.Builder(GridViewTemplates.Config config)
			{
				return new GridViewTemplates.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private XTemplate header = null;

			/// <summary>
			/// 
			/// </summary>
			public XTemplate Header
			{
				get
				{
					if (this.header == null)
					{
						this.header = new XTemplate();
					}
			
					return this.header;
				}
			}
			
        }
    }
}