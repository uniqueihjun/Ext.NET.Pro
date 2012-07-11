/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class CellSelectionModel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractSelectionModel.Builder<CellSelectionModel, CellSelectionModel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CellSelectionModel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CellSelectionModel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CellSelectionModel.Config config) : base(new CellSelectionModel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CellSelectionModel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Turns on/off keyboard navigation within the grid. Defaults to true.
			/// </summary>
            public virtual CellSelectionModel.Builder EnableKeyNav(bool enableKeyNav)
            {
                this.ToComponent().EnableKeyNav = enableKeyNav;
                return this as CellSelectionModel.Builder;
            }
             
 			/// <summary>
			/// Set this configuration to true to prevent wrapping around of selection as a user navigates to the first or last column. Defaults to false.
			/// </summary>
            public virtual CellSelectionModel.Builder PreventWrap(bool preventWrap)
            {
                this.ToComponent().PreventWrap = preventWrap;
                return this as CellSelectionModel.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CellSelectionModel.Builder</returns>
            public virtual CellSelectionModel.Builder Listeners(Action<CellSelectionModelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as CellSelectionModel.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CellSelectionModel.Builder</returns>
            public virtual CellSelectionModel.Builder DirectEvents(Action<CellSelectionModelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as CellSelectionModel.Builder;
            }
			 
 			/// <summary>
			/// Selected cell
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CellSelectionModel.Builder</returns>
            public virtual CellSelectionModel.Builder SelectedCell(Action<SelectedCell> action)
            {
                action(this.ToComponent().SelectedCell);
                return this as CellSelectionModel.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual CellSelectionModel.Builder Clear()
            {
                this.ToComponent().Clear();
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public CellSelectionModel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CellSelectionModel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CellSelectionModel.Builder CellSelectionModel()
        {
            return this.CellSelectionModel(new CellSelectionModel());
        }

        /// <summary>
        /// 
        /// </summary>
        public CellSelectionModel.Builder CellSelectionModel(CellSelectionModel component)
        {
            return new CellSelectionModel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CellSelectionModel.Builder CellSelectionModel(CellSelectionModel.Config config)
        {
            return new CellSelectionModel.Builder(new CellSelectionModel(config));
        }
    }
}