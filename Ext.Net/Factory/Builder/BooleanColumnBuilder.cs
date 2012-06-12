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
    public partial class BooleanColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Column.Builder<BooleanColumn, BooleanColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new BooleanColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BooleanColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BooleanColumn.Config config) : base(new BooleanColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(BooleanColumn component)
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
        public BooleanColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.BooleanColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public BooleanColumn.Builder BooleanColumn()
        {
            return this.BooleanColumn(new BooleanColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public BooleanColumn.Builder BooleanColumn(BooleanColumn component)
        {
            return new BooleanColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public BooleanColumn.Builder BooleanColumn(BooleanColumn.Config config)
        {
            return new BooleanColumn.Builder(new BooleanColumn(config));
        }
    }
}