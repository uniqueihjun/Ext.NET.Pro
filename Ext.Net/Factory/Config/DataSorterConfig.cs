/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class DataSorter
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DataSorter(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DataSorter.Config Conversion to DataSorter
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataSorter(DataSorter.Config config)
        {
            return new DataSorter(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit DataSorter.Config Conversion to DataSorter.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DataSorter.Builder(DataSorter.Config config)
			{
				return new DataSorter.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private SortDirection direction = SortDirection.Default;

			/// <summary>
			/// The direction to sort by. Defaults to ASC
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

			private string property = "";

			/// <summary>
			/// The property to sort by. Required unless sorterFn is provided
			/// </summary>
			[DefaultValue("")]
			public virtual string Property 
			{ 
				get
				{
					return this.property;
				}
				set
				{
					this.property = value;
				}
			}

			private string root = "";

			/// <summary>
			/// Optional root property. This is mostly useful when sorting a Store, in which case we set the root to 'data' to make the filter pull the property out of the data object of each item
			/// </summary>
			[DefaultValue("")]
			public virtual string Root 
			{ 
				get
				{
					return this.root;
				}
				set
				{
					this.root = value;
				}
			}

        }
    }
}