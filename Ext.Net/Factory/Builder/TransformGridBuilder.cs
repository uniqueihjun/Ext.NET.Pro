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
    public partial class TransformGrid
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridPanel.Builder<TransformGrid, TransformGrid.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TransformGrid()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TransformGrid component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TransformGrid.Config config) : base(new TransformGrid(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TransformGrid component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The table element from which this grid will be created.
			/// </summary>
            public virtual TransformGrid.Builder Table(string table)
            {
                this.ToComponent().Table = table;
                return this as TransformGrid.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TransformGrid.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TransformGrid(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TransformGrid.Builder TransformGrid()
        {
            return this.TransformGrid(new TransformGrid());
        }

        /// <summary>
        /// 
        /// </summary>
        public TransformGrid.Builder TransformGrid(TransformGrid component)
        {
            return new TransformGrid.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TransformGrid.Builder TransformGrid(TransformGrid.Config config)
        {
            return new TransformGrid.Builder(new TransformGrid(config));
        }
    }
}