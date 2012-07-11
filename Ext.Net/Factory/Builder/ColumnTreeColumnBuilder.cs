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
    public partial class ColumnTreeColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<ColumnTreeColumn, ColumnTreeColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ColumnTreeColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ColumnTreeColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ColumnTreeColumn.Config config) : base(new ColumnTreeColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ColumnTreeColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual ColumnTreeColumn.Builder DataIndex(string dataIndex)
            {
                this.ToComponent().DataIndex = dataIndex;
                return this as ColumnTreeColumn.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ColumnTreeColumn.Builder Header(string header)
            {
                this.ToComponent().Header = header;
                return this as ColumnTreeColumn.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ColumnTreeColumn.Builder Cls(string cls)
            {
                this.ToComponent().Cls = cls;
                return this as ColumnTreeColumn.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ColumnTreeColumn.Builder Width(int width)
            {
                this.ToComponent().Width = width;
                return this as ColumnTreeColumn.Builder;
            }
             
 			/// <summary>
			/// (optional) A function used to generate HTML markup for a node.
			/// </summary>
            public virtual ColumnTreeColumn.Builder Renderer(Renderer renderer)
            {
                this.ToComponent().Renderer = renderer;
                return this as ColumnTreeColumn.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ColumnTreeColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ColumnTreeColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ColumnTreeColumn.Builder ColumnTreeColumn()
        {
            return this.ColumnTreeColumn(new ColumnTreeColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public ColumnTreeColumn.Builder ColumnTreeColumn(ColumnTreeColumn component)
        {
            return new ColumnTreeColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ColumnTreeColumn.Builder ColumnTreeColumn(ColumnTreeColumn.Config config)
        {
            return new ColumnTreeColumn.Builder(new ColumnTreeColumn(config));
        }
    }
}