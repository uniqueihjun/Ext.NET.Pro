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
    public partial class FitLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ContainerLayout.Builder<FitLayout, FitLayout.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FitLayout()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FitLayout component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FitLayout.Config config) : base(new FitLayout(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FitLayout component)
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
        public FitLayout.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FitLayout(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FitLayout.Builder FitLayout()
        {
            return this.FitLayout(new FitLayout());
        }

        /// <summary>
        /// 
        /// </summary>
        public FitLayout.Builder FitLayout(FitLayout component)
        {
            return new FitLayout.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FitLayout.Builder FitLayout(FitLayout.Config config)
        {
            return new FitLayout.Builder(new FitLayout(config));
        }
    }
}