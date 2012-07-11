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
    public partial class Preview
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<Preview, Preview.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Preview()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Preview component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Preview.Config config) : base(new Preview(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Preview component)
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
        public Preview.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Preview(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Preview.Builder Preview()
        {
            return this.Preview(new Preview());
        }

        /// <summary>
        /// 
        /// </summary>
        public Preview.Builder Preview(Preview component)
        {
            return new Preview.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Preview.Builder Preview(Preview.Config config)
        {
            return new Preview.Builder(new Preview(config));
        }
    }
}