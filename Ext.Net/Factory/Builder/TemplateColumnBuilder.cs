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
    public partial class TemplateColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Column.Builder<TemplateColumn, TemplateColumn.Builder>
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