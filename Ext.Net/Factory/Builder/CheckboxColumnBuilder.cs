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
    public partial class CheckboxColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Checkbox.Builder<CheckboxColumn, CheckboxColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CheckboxColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckboxColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckboxColumn.Config config) : base(new CheckboxColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CheckboxColumn component)
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
        public CheckboxColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CheckboxColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CheckboxColumn.Builder CheckboxColumn()
        {
            return this.CheckboxColumn(new CheckboxColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxColumn.Builder CheckboxColumn(CheckboxColumn component)
        {
            return new CheckboxColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxColumn.Builder CheckboxColumn(CheckboxColumn.Config config)
        {
            return new CheckboxColumn.Builder(new CheckboxColumn(config));
        }
    }
}