/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class BorderLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ContainerLayout.Builder<BorderLayout, BorderLayout.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new BorderLayout()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BorderLayout component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BorderLayout.Config config) : base(new BorderLayout(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(BorderLayout component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Represent options of north region
			// /// </summary>
            // public virtual TBuilder North(BorderLayoutRegion north)
            // {
            //    this.ToComponent().North = north;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Represent options of south region
			// /// </summary>
            // public virtual TBuilder South(BorderLayoutRegion south)
            // {
            //    this.ToComponent().South = south;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Represent options of west region
			// /// </summary>
            // public virtual TBuilder West(BorderLayoutRegion west)
            // {
            //    this.ToComponent().West = west;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Represent options of east region
			// /// </summary>
            // public virtual TBuilder East(BorderLayoutRegion east)
            // {
            //    this.ToComponent().East = east;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Represent options of center region
			// /// </summary>
            // public virtual TBuilder Center(BorderLayoutRegion center)
            // {
            //    this.ToComponent().Center = center;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public BorderLayout.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.BorderLayout(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public BorderLayout.Builder BorderLayout()
        {
            return this.BorderLayout(new BorderLayout());
        }

        /// <summary>
        /// 
        /// </summary>
        public BorderLayout.Builder BorderLayout(BorderLayout component)
        {
            return new BorderLayout.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public BorderLayout.Builder BorderLayout(BorderLayout.Config config)
        {
            return new BorderLayout.Builder(new BorderLayout(config));
        }
    }
}