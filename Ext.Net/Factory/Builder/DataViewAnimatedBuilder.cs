/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class DataViewAnimated
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<DataViewAnimated, DataViewAnimated.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DataViewAnimated()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewAnimated component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewAnimated.Config config) : base(new DataViewAnimated(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DataViewAnimated component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual DataViewAnimated.Builder Duration(int duration)
            {
                this.ToComponent().Duration = duration;
                return this as DataViewAnimated.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DataViewAnimated.Builder IDProperty(string iDProperty)
            {
                this.ToComponent().IDProperty = iDProperty;
                return this as DataViewAnimated.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewAnimated.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DataViewAnimated(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DataViewAnimated.Builder DataViewAnimated()
        {
            return this.DataViewAnimated(new DataViewAnimated());
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewAnimated.Builder DataViewAnimated(DataViewAnimated component)
        {
            return new DataViewAnimated.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewAnimated.Builder DataViewAnimated(DataViewAnimated.Config config)
        {
            return new DataViewAnimated.Builder(new DataViewAnimated(config));
        }
    }
}