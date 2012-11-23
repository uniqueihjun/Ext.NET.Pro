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
    public partial class DateColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Column.Builder<DateColumn, DateColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DateColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateColumn.Config config) : base(new DateColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DateColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A formatting string as used by Date.format to format a Date for this Column.
			/// </summary>
            public virtual DateColumn.Builder Format(string format)
            {
                this.ToComponent().Format = format;
                return this as DateColumn.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DateColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DateColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DateColumn.Builder DateColumn()
        {
            return this.DateColumn(new DateColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public DateColumn.Builder DateColumn(DateColumn component)
        {
            return new DateColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DateColumn.Builder DateColumn(DateColumn.Config config)
        {
            return new DateColumn.Builder(new DateColumn(config));
        }
    }
}