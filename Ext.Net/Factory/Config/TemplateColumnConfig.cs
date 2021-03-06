/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TemplateColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TemplateColumn.Config Conversion to TemplateColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplateColumn(TemplateColumn.Config config)
        {
            return new TemplateColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : CellCommandColumn.Config 
        { 
			/*  Implicit TemplateColumn.Config Conversion to TemplateColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TemplateColumn.Builder(TemplateColumn.Config config)
			{
				return new TemplateColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private XTemplate template = null;

			/// <summary>
			/// An XTemplate, or an XTemplate definition string to use to process a Model's data to produce a column's rendered value.
			/// </summary>
			public XTemplate Template
			{
				get
				{
					if (this.template == null)
					{
						this.template = new XTemplate();
					}
			
					return this.template;
				}
			}
			
			private string templateString = "";

			/// <summary>
			/// An XTemplate, or an XTemplate definition string to use to process a Model's data to produce a column's rendered value.
			/// </summary>
			[DefaultValue("")]
			public virtual string TemplateString 
			{ 
				get
				{
					return this.templateString;
				}
				set
				{
					this.templateString = value;
				}
			}

        }
    }
}