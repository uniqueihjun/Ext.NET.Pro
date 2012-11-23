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
    public partial class AbsoluteLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AnchorLayout.Builder<AbsoluteLayout, AbsoluteLayout.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new AbsoluteLayout()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AbsoluteLayout component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AbsoluteLayout.Config config) : base(new AbsoluteLayout(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(AbsoluteLayout component)
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
        public AbsoluteLayout.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.AbsoluteLayout(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public AbsoluteLayout.Builder AbsoluteLayout()
        {
            return this.AbsoluteLayout(new AbsoluteLayout());
        }

        /// <summary>
        /// 
        /// </summary>
        public AbsoluteLayout.Builder AbsoluteLayout(AbsoluteLayout component)
        {
            return new AbsoluteLayout.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public AbsoluteLayout.Builder AbsoluteLayout(AbsoluteLayout.Config config)
        {
            return new AbsoluteLayout.Builder(new AbsoluteLayout(config));
        }
    }
}