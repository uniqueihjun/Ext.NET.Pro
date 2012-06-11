/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class SortInfo
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SortInfo(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SortInfo.Config Conversion to SortInfo
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SortInfo(SortInfo.Config config)
        {
            return new SortInfo(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit SortInfo.Config Conversion to SortInfo.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SortInfo.Builder(SortInfo.Config config)
			{
				return new SortInfo.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string field = "";

			/// <summary>
			/// Internal UI Event. Fired before the view is refreshed.
			/// </summary>
			[DefaultValue("")]
			public virtual string Field 
			{ 
				get
				{
					return this.field;
				}
				set
				{
					this.field = value;
				}
			}

			private SortDirection direction = SortDirection.Default;

			/// <summary>
			/// The direction to sort (\"asc\" or \"desc\")
			/// </summary>
			[DefaultValue(SortDirection.Default)]
			public virtual SortDirection Direction 
			{ 
				get
				{
					return this.direction;
				}
				set
				{
					this.direction = value;
				}
			}

        }
    }
}