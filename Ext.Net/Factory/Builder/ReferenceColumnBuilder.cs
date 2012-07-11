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
    public partial class ReferenceColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ColumnBase.Builder<ReferenceColumn, ReferenceColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ReferenceColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ReferenceColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ReferenceColumn.Config config) : base(new ReferenceColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ReferenceColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual ReferenceColumn.Builder Reference(string reference)
            {
                this.ToComponent().Reference = reference;
                return this as ReferenceColumn.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ReferenceColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ReferenceColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ReferenceColumn.Builder ReferenceColumn()
        {
            return this.ReferenceColumn(new ReferenceColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public ReferenceColumn.Builder ReferenceColumn(ReferenceColumn component)
        {
            return new ReferenceColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ReferenceColumn.Builder ReferenceColumn(ReferenceColumn.Config config)
        {
            return new ReferenceColumn.Builder(new ReferenceColumn(config));
        }
    }
}