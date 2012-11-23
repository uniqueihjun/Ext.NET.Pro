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
    public partial class HeaderRow
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<HeaderRow, HeaderRow.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HeaderRow()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HeaderRow component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HeaderRow.Config config) : base(new HeaderRow(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HeaderRow component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder Columns(HeaderColumnCollection columns)
            // {
            //    this.ToComponent().Columns = columns;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HeaderRow.Builder Cls(string cls)
            {
                this.ToComponent().Cls = cls;
                return this as HeaderRow.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public HeaderRow.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HeaderRow(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public HeaderRow.Builder HeaderRow()
        {
            return this.HeaderRow(new HeaderRow());
        }

        /// <summary>
        /// 
        /// </summary>
        public HeaderRow.Builder HeaderRow(HeaderRow component)
        {
            return new HeaderRow.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HeaderRow.Builder HeaderRow(HeaderRow.Config config)
        {
            return new HeaderRow.Builder(new HeaderRow(config));
        }
    }
}