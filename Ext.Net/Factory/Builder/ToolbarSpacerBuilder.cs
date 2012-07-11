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
    public partial class ToolbarSpacer
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolbarItem.Builder<ToolbarSpacer, ToolbarSpacer.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ToolbarSpacer()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarSpacer component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarSpacer.Config config) : base(new ToolbarSpacer(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ToolbarSpacer component)
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
        public ToolbarSpacer.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ToolbarSpacer(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ToolbarSpacer.Builder ToolbarSpacer()
        {
            return this.ToolbarSpacer(new ToolbarSpacer());
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarSpacer.Builder ToolbarSpacer(ToolbarSpacer component)
        {
            return new ToolbarSpacer.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarSpacer.Builder ToolbarSpacer(ToolbarSpacer.Config config)
        {
            return new ToolbarSpacer.Builder(new ToolbarSpacer(config));
        }
    }
}