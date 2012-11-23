/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class ToolbarFill
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolbarItem.Builder<ToolbarFill, ToolbarFill.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ToolbarFill()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarFill component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarFill.Config config) : base(new ToolbarFill(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ToolbarFill component)
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
        public ToolbarFill.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ToolbarFill(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToolbarFill()
        {
            return this.ToolbarFill(new ToolbarFill());
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToolbarFill(ToolbarFill component)
        {
            return new ToolbarFill.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToolbarFill(ToolbarFill.Config config)
        {
            return new ToolbarFill.Builder(new ToolbarFill(config));
        }
    }
}