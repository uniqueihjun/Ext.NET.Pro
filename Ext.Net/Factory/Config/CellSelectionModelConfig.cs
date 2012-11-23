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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CellSelectionModel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CellSelectionModel.Config Conversion to CellSelectionModel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CellSelectionModel(CellSelectionModel.Config config)
        {
            return new CellSelectionModel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractSelectionModel.Config 
        { 
			/*  Implicit CellSelectionModel.Config Conversion to CellSelectionModel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CellSelectionModel.Builder(CellSelectionModel.Config config)
			{
				return new CellSelectionModel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private CellSelectionModelListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public CellSelectionModelListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new CellSelectionModelListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private CellSelectionModelDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public CellSelectionModelDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new CellSelectionModelDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			        
			private SelectedCell selectedCell = null;

			/// <summary>
			/// Selected cell
			/// </summary>
			public SelectedCell SelectedCell
			{
				get
				{
					if (this.selectedCell == null)
					{
						this.selectedCell = new SelectedCell();
					}
			
					return this.selectedCell;
				}
			}
			
        }
    }
}