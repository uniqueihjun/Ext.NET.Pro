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
    public partial class Column
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CellCommandColumn.Builder<Column, Column.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Column()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Column component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Column.Config config) : base(new Column(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Column component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Column.Builder</returns>
            public virtual Column.Builder Listeners(Action<CellCommandColumnListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Column.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Column.Builder</returns>
            public virtual Column.Builder DirectEvents(Action<CellCommandColumnDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Column.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Column.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Column(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Column.Builder Column()
        {
            return this.Column(new Column());
        }

        /// <summary>
        /// 
        /// </summary>
        public Column.Builder Column(Column component)
        {
            return new Column.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Column.Builder Column(Column.Config config)
        {
            return new Column.Builder(new Column(config));
        }
    }
}