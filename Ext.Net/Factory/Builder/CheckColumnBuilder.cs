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
    public partial class CheckColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ColumnBase.Builder<CheckColumn, CheckColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CheckColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckColumn.Config config) : base(new CheckColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CheckColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual CheckColumn.Builder Editable(bool editable)
            {
                this.ToComponent().Editable = editable;
                return this as CheckColumn.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual CheckColumn.Builder SingleSelect(bool singleSelect)
            {
                this.ToComponent().SingleSelect = singleSelect;
                return this as CheckColumn.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CheckColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CheckColumn.Builder CheckColumn()
        {
            return this.CheckColumn(new CheckColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckColumn.Builder CheckColumn(CheckColumn component)
        {
            return new CheckColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckColumn.Builder CheckColumn(CheckColumn.Config config)
        {
            return new CheckColumn.Builder(new CheckColumn(config));
        }
    }
}