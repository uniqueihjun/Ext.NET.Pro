/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class MenuPanel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : PanelBase.Builder<MenuPanel, MenuPanel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MenuPanel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MenuPanel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MenuPanel.Config config) : base(new MenuPanel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MenuPanel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder Items(ItemsCollection<Component> items)
            // {
            //    this.ToComponent().Items = items;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Standard menu attribute consisting of a reference to a menu object, a menu id or a menu config blob
			// /// </summary>
            // public virtual TBuilder Menu(Menu menu)
            // {
            //    this.ToComponent().Menu = menu;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// Save selection after click
			/// </summary>
            public virtual MenuPanel.Builder SaveSelection(bool saveSelection)
            {
                this.ToComponent().SaveSelection = saveSelection;
                return this as MenuPanel.Builder;
            }
             
 			/// <summary>
			/// Fit menu's height
			/// </summary>
            public virtual MenuPanel.Builder FitHeight(bool fitHeight)
            {
                this.ToComponent().FitHeight = fitHeight;
                return this as MenuPanel.Builder;
            }
             
 			/// <summary>
			/// Index of selected item
			/// </summary>
            public virtual MenuPanel.Builder SelectedIndex(int selectedIndex)
            {
                this.ToComponent().SelectedIndex = selectedIndex;
                return this as MenuPanel.Builder;
            }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(PanelListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(PanelDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual MenuPanel.Builder SetSelectedIndex(int index)
            {
                this.ToComponent().SetSelectedIndex(index);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual MenuPanel.Builder ClearSelection()
            {
                this.ToComponent().ClearSelection();
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuPanel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MenuPanel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public MenuPanel.Builder MenuPanel()
        {
            return this.MenuPanel(new MenuPanel());
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuPanel.Builder MenuPanel(MenuPanel component)
        {
            return new MenuPanel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuPanel.Builder MenuPanel(MenuPanel.Config config)
        {
            return new MenuPanel.Builder(new MenuPanel(config));
        }
    }
}