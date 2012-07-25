/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class RowSelectionModel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractSelectionModel.Builder<RowSelectionModel, RowSelectionModel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RowSelectionModel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowSelectionModel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowSelectionModel.Config config) : base(new RowSelectionModel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RowSelectionModel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Turns on/off keyboard navigation within the grid. Defaults to true.
			/// </summary>
            public virtual RowSelectionModel.Builder EnableKeyNav(bool enableKeyNav)
            {
                this.ToComponent().EnableKeyNav = enableKeyNav;
                return this as RowSelectionModel.Builder;
            }
             
 			/// <summary>
			/// True to ignore selections that are made when using the right mouse button if there are records that are already selected. If no records are selected, selection will continue as normal. Defaults to: true
			/// </summary>
            public virtual RowSelectionModel.Builder IgnoreRightMouseSelection(bool ignoreRightMouseSelection)
            {
                this.ToComponent().IgnoreRightMouseSelection = ignoreRightMouseSelection;
                return this as RowSelectionModel.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of RowSelectionModel.Builder</returns>
            public virtual RowSelectionModel.Builder Listeners(Action<RowSelectionModelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as RowSelectionModel.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of RowSelectionModel.Builder</returns>
            public virtual RowSelectionModel.Builder DirectEvents(Action<RowSelectionModelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as RowSelectionModel.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of RowSelectionModel.Builder</returns>
            public virtual RowSelectionModel.Builder SelectedRows(Action<SelectedRowCollection> action)
            {
                action(this.ToComponent().SelectedRows);
                return this as RowSelectionModel.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of RowSelectionModel.Builder</returns>
            public virtual RowSelectionModel.Builder SelectedRow(Action<SelectedRow> action)
            {
                action(this.ToComponent().SelectedRow);
                return this as RowSelectionModel.Builder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual RowSelectionModel.Builder SelectedIndex(int selectedIndex)
            {
                this.ToComponent().SelectedIndex = selectedIndex;
                return this as RowSelectionModel.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RowSelectionModel.Builder SelectedRecordID(string selectedRecordID)
            {
                this.ToComponent().SelectedRecordID = selectedRecordID;
                return this as RowSelectionModel.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RowSelectionModel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RowSelectionModel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RowSelectionModel.Builder RowSelectionModel()
        {
            return this.RowSelectionModel(new RowSelectionModel());
        }

        /// <summary>
        /// 
        /// </summary>
        public RowSelectionModel.Builder RowSelectionModel(RowSelectionModel component)
        {
            return new RowSelectionModel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RowSelectionModel.Builder RowSelectionModel(RowSelectionModel.Config config)
        {
            return new RowSelectionModel.Builder(new RowSelectionModel(config));
        }
    }
}