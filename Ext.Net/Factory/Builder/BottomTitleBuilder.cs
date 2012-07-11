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
    public partial class BottomTitle
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<BottomTitle, BottomTitle.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new BottomTitle()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BottomTitle component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BottomTitle.Config config) : base(new BottomTitle(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(BottomTitle component)
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
        public BottomTitle.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.BottomTitle(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public BottomTitle.Builder BottomTitle()
        {
            return this.BottomTitle(new BottomTitle());
        }

        /// <summary>
        /// 
        /// </summary>
        public BottomTitle.Builder BottomTitle(BottomTitle component)
        {
            return new BottomTitle.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public BottomTitle.Builder BottomTitle(BottomTitle.Config config)
        {
            return new BottomTitle.Builder(new BottomTitle(config));
        }
    }
}