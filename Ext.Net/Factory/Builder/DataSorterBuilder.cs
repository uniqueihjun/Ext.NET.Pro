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
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<DataSorter, DataSorter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DataSorter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataSorter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataSorter.Config config) : base(new DataSorter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DataSorter component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The direction to sort by. Defaults to ASC
			/// </summary>
            public virtual DataSorter.Builder Direction(SortDirection direction)
            {
                this.ToComponent().Direction = direction;
                return this as DataSorter.Builder;
            }
             
 			/// <summary>
			/// The property to sort by. Required unless sorterFn is provided
			/// </summary>
            public virtual DataSorter.Builder Property(string property)
            {
                this.ToComponent().Property = property;
                return this as DataSorter.Builder;
            }
             
 			/// <summary>
			/// Optional root property. This is mostly useful when sorting a Store, in which case we set the root to 'data' to make the filter pull the property out of the data object of each item
			/// </summary>
            public virtual DataSorter.Builder Root(string root)
            {
                this.ToComponent().Root = root;
                return this as DataSorter.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DataSorter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DataSorter(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DataSorter.Builder DataSorter()
        {
            return this.DataSorter(new DataSorter());
        }

        /// <summary>
        /// 
        /// </summary>
        public DataSorter.Builder DataSorter(DataSorter component)
        {
            return new DataSorter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DataSorter.Builder DataSorter(DataSorter.Config config)
        {
            return new DataSorter.Builder(new DataSorter(config));
        }
    }
}