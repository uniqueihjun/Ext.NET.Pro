/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class DataViewDragSelector
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<DataViewDragSelector, DataViewDragSelector.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DataViewDragSelector()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewDragSelector component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewDragSelector.Config config) : base(new DataViewDragSelector(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DataViewDragSelector component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewDragSelector.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DataViewDragSelector(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DataViewDragSelector.Builder DataViewDragSelector()
        {
            return this.DataViewDragSelector(new DataViewDragSelector());
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewDragSelector.Builder DataViewDragSelector(DataViewDragSelector component)
        {
            return new DataViewDragSelector.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewDragSelector.Builder DataViewDragSelector(DataViewDragSelector.Config config)
        {
            return new DataViewDragSelector.Builder(new DataViewDragSelector(config));
        }
    }
}