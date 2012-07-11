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
    public partial class RadioColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Radio.Builder<RadioColumn, RadioColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RadioColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadioColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadioColumn.Config config) : base(new RadioColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RadioColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Items collection
			// /// </summary>
            // public virtual TBuilder Items(ItemsCollection<Component> items)
            // {
            //    this.ToComponent().Items = items;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RadioColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RadioColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RadioColumn.Builder RadioColumn()
        {
            return this.RadioColumn(new RadioColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public RadioColumn.Builder RadioColumn(RadioColumn component)
        {
            return new RadioColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RadioColumn.Builder RadioColumn(RadioColumn.Config config)
        {
            return new RadioColumn.Builder(new RadioColumn(config));
        }
    }
}