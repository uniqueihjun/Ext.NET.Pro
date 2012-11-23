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
    public partial class ColumnTree
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TreePanel.Builder<ColumnTree, ColumnTree.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ColumnTree()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ColumnTree component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ColumnTree.Config config) : base(new ColumnTree(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ColumnTree component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// An array of column configuration objects
			// /// </summary>
            // public virtual TBuilder Columns(ColumnTreeColumnCollection columns)
            // {
            //    this.ToComponent().Columns = columns;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// True to hide the grid's header (defaults to false).
			/// </summary>
            public virtual ColumnTree.Builder HideHeaders(bool hideHeaders)
            {
                this.ToComponent().HideHeaders = hideHeaders;
                return this as ColumnTree.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ColumnTree.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ColumnTree(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ColumnTree.Builder ColumnTree()
        {
            return this.ColumnTree(new ColumnTree());
        }

        /// <summary>
        /// 
        /// </summary>
        public ColumnTree.Builder ColumnTree(ColumnTree component)
        {
            return new ColumnTree.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ColumnTree.Builder ColumnTree(ColumnTree.Config config)
        {
            return new ColumnTree.Builder(new ColumnTree(config));
        }
    }
}