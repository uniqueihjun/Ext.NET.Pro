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
    public partial class RowWrap
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridFeature.Builder<RowWrap, RowWrap.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RowWrap()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowWrap component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowWrap.Config config) : base(new RowWrap(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RowWrap component)
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
        public RowWrap.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RowWrap(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RowWrap.Builder RowWrap()
        {
            return this.RowWrap(new RowWrap());
        }

        /// <summary>
        /// 
        /// </summary>
        public RowWrap.Builder RowWrap(RowWrap component)
        {
            return new RowWrap.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RowWrap.Builder RowWrap(RowWrap.Config config)
        {
            return new RowWrap.Builder(new RowWrap(config));
        }
    }
}