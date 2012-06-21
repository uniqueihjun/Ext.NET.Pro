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
    public partial class DataFilter
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<DataFilter, DataFilter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DataFilter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataFilter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataFilter.Config config) : base(new DataFilter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DataFilter component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to allow any match - no regex start/end line anchors will be added. Defaults to false
			/// </summary>
            public virtual DataFilter.Builder AnyMatch(bool anyMatch)
            {
                this.ToComponent().AnyMatch = anyMatch;
                return this as DataFilter.Builder;
            }
             
 			/// <summary>
			/// True to make the regex case sensitive (adds 'i' switch to regex). Defaults to false.
			/// </summary>
            public virtual DataFilter.Builder CaseSensitive(bool caseSensitive)
            {
                this.ToComponent().CaseSensitive = caseSensitive;
                return this as DataFilter.Builder;
            }
             
 			/// <summary>
			/// True to force exact match (^ and $ characters added to the regex). Defaults to false. Ignored if anyMatch is true.
			/// </summary>
            public virtual DataFilter.Builder ExactMatch(bool exactMatch)
            {
                this.ToComponent().ExactMatch = exactMatch;
                return this as DataFilter.Builder;
            }
             
 			/// <summary>
			/// The property to filter on. Required unless a filter is passed
			/// </summary>
            public virtual DataFilter.Builder Property(string property)
            {
                this.ToComponent().Property = property;
                return this as DataFilter.Builder;
            }
             
 			/// <summary>
			/// Optional root property. This is mostly useful when filtering a Store, in which case we set the root to 'data' to make the filter pull the property out of the data object of each item
			/// </summary>
            public virtual DataFilter.Builder Root(string root)
            {
                this.ToComponent().Root = root;
                return this as DataFilter.Builder;
            }
             
 			/// <summary>
			/// Filter value
			/// </summary>
            public virtual DataFilter.Builder Value(string value)
            {
                this.ToComponent().Value = value;
                return this as DataFilter.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DataFilter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DataFilter(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DataFilter.Builder DataFilter()
        {
            return this.DataFilter(new DataFilter());
        }

        /// <summary>
        /// 
        /// </summary>
        public DataFilter.Builder DataFilter(DataFilter component)
        {
            return new DataFilter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DataFilter.Builder DataFilter(DataFilter.Config config)
        {
            return new DataFilter.Builder(new DataFilter(config));
        }
    }
}