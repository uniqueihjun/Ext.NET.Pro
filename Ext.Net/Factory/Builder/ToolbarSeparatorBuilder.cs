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
    public partial class ToolbarSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolbarItem.Builder<ToolbarSeparator, ToolbarSeparator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ToolbarSeparator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarSeparator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarSeparator.Config config) : base(new ToolbarSeparator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ToolbarSeparator component)
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
        public ToolbarSeparator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ToolbarSeparator(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ToolbarSeparator.Builder ToolbarSeparator()
        {
            return this.ToolbarSeparator(new ToolbarSeparator());
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarSeparator.Builder ToolbarSeparator(ToolbarSeparator component)
        {
            return new ToolbarSeparator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarSeparator.Builder ToolbarSeparator(ToolbarSeparator.Config config)
        {
            return new ToolbarSeparator.Builder(new ToolbarSeparator(config));
        }
    }
}