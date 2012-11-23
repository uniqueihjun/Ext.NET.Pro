/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class DataFilter
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DataFilter(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DataFilter.Config Conversion to DataFilter
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataFilter(DataFilter.Config config)
        {
            return new DataFilter(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit DataFilter.Config Conversion to DataFilter.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DataFilter.Builder(DataFilter.Config config)
			{
				return new DataFilter.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool anyMatch = false;

			/// <summary>
			/// True to allow any match - no regex start/end line anchors will be added. Defaults to false
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AnyMatch 
			{ 
				get
				{
					return this.anyMatch;
				}
				set
				{
					this.anyMatch = value;
				}
			}

			private bool caseSensitive = false;

			/// <summary>
			/// True to make the regex case sensitive (adds 'i' switch to regex). Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool CaseSensitive 
			{ 
				get
				{
					return this.caseSensitive;
				}
				set
				{
					this.caseSensitive = value;
				}
			}

			private bool exactMatch = false;

			/// <summary>
			/// True to force exact match (^ and $ characters added to the regex). Defaults to false. Ignored if anyMatch is true.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ExactMatch 
			{ 
				get
				{
					return this.exactMatch;
				}
				set
				{
					this.exactMatch = value;
				}
			}

			private string property = "";

			/// <summary>
			/// The property to filter on. Required unless a filter is passed
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
			/// Optional root property. This is mostly useful when filtering a Store, in which case we set the root to 'data' to make the filter pull the property out of the data object of each item
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

			private string value = null;

			/// <summary>
			/// Filter value
			/// </summary>
			[DefaultValue(null)]
			public virtual string Value 
			{ 
				get
				{
					return this.value;
				}
				set
				{
					this.value = value;
				}
			}

        }
    }
}