/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    /// <summary>
    /// 
    /// </summary>
    public partial class TemplateColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CellCommandColumn.Builder<TemplateColumn, TemplateColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TemplateColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TemplateColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TemplateColumn.Config config) : base(new TemplateColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TemplateColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// An XTemplate, or an XTemplate definition string to use to process a Model's data to produce a column's rendered value.
			/// </summary>
            public virtual TemplateColumn.Builder TemplateString(string templateString)
            {
                this.ToComponent().TemplateString = templateString;
                return this as TemplateColumn.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TemplateColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TemplateColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TemplateColumn.Builder TemplateColumn()
        {
            return this.TemplateColumn(new TemplateColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public TemplateColumn.Builder TemplateColumn(TemplateColumn component)
        {
            return new TemplateColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TemplateColumn.Builder TemplateColumn(TemplateColumn.Config config)
        {
            return new TemplateColumn.Builder(new TemplateColumn(config));
        }
    }
}