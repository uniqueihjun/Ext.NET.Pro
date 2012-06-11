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
    public partial class GridViewTemplates
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<GridViewTemplates, GridViewTemplates.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GridViewTemplates()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridViewTemplates component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridViewTemplates.Config config) : base(new GridViewTemplates(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GridViewTemplates component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder Header(XTemplate header)
            // {
            //    this.ToComponent().Header = header;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GridViewTemplates.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GridViewTemplates(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GridViewTemplates.Builder GridViewTemplates()
        {
            return this.GridViewTemplates(new GridViewTemplates());
        }

        /// <summary>
        /// 
        /// </summary>
        public GridViewTemplates.Builder GridViewTemplates(GridViewTemplates component)
        {
            return new GridViewTemplates.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GridViewTemplates.Builder GridViewTemplates(GridViewTemplates.Config config)
        {
            return new GridViewTemplates.Builder(new GridViewTemplates(config));
        }
    }
}