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
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(CellSelectionModelListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(CellSelectionModelDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Selected cell
			// /// </summary>
            // public virtual TBuilder SelectedCell(SelectedCell selectedCell)
            // {
            //    this.ToComponent().SelectedCell = selectedCell;
            //    return this as TBuilder;
            // }
            

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
            
 			/// <summary>
			/// Clears all selections.
			/// </summary>
            public virtual CellSelectionModel.Builder ClearSelections()
            {
                this.ToComponent().ClearSelections();
                return this;
            }
            
 			/// <summary>
			/// Clears all selections.
			/// </summary>
            public virtual CellSelectionModel.Builder ClearSelections(bool notify)
            {
                this.ToComponent().ClearSelections(notify);
                return this;
            }
            
 			/// <summary>
			/// Selects a range of rows. All rows in between startRow and endRow are also selected.
			/// </summary>
            public virtual CellSelectionModel.Builder Select(int rowIndex, int collIndex)
            {
                this.ToComponent().Select(rowIndex, collIndex);
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