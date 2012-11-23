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
    public partial class MonthPicker
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<MonthPicker, MonthPicker.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MonthPicker()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MonthPicker component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MonthPicker.Config config) : base(new MonthPicker(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MonthPicker component)
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
        public MonthPicker.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MonthPicker(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public MonthPicker.Builder MonthPicker()
        {
            return this.MonthPicker(new MonthPicker());
        }

        /// <summary>
        /// 
        /// </summary>
        public MonthPicker.Builder MonthPicker(MonthPicker component)
        {
            return new MonthPicker.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MonthPicker.Builder MonthPicker(MonthPicker.Config config)
        {
            return new MonthPicker.Builder(new MonthPicker(config));
        }
    }
}