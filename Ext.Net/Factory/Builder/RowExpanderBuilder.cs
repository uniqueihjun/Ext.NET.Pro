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
    public partial class RowExpander
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<RowExpander, RowExpander.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RowExpander()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowExpander component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowExpander.Config config) : base(new RowExpander(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RowExpander component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The template string to use to display each item in the dropdown list.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of RowExpander.Builder</returns>
            public virtual RowExpander.Builder Template(Action<XTemplate> action)
            {
                action(this.ToComponent().Template);
                return this as RowExpander.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of RowExpander.Builder</returns>
            public virtual RowExpander.Builder Component(Action<ItemsCollection<AbstractComponent>> action)
            {
                action(this.ToComponent().Component);
                return this as RowExpander.Builder;
            }
			 
 			/// <summary>
			/// Recreate component on each row expand
			/// </summary>
            public virtual RowExpander.Builder RecreateComponent(bool recreateComponent)
            {
                this.ToComponent().RecreateComponent = recreateComponent;
                return this as RowExpander.Builder;
            }
             
 			/// <summary>
			/// Call doLayout after a row expanding/collapsing
			/// </summary>
            public virtual RowExpander.Builder DoLayoutOnExpand(bool doLayoutOnExpand)
            {
                this.ToComponent().DoLayoutOnExpand = doLayoutOnExpand;
                return this as RowExpander.Builder;
            }
             
 			/// <summary>
			/// Swallow row body's events
			/// </summary>
            public virtual RowExpander.Builder SwallowBodyEvents(bool swallowBodyEvents)
            {
                this.ToComponent().SwallowBodyEvents = swallowBodyEvents;
                return this as RowExpander.Builder;
            }
             
 			/// <summary>
			/// True to select a row when clicking on the expander icon (defaults to false).
			/// </summary>
            public virtual RowExpander.Builder SelectRowOnExpand(bool selectRowOnExpand)
            {
                this.ToComponent().SelectRowOnExpand = selectRowOnExpand;
                return this as RowExpander.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RowExpander.Builder ExpandOnEnter(bool expandOnEnter)
            {
                this.ToComponent().ExpandOnEnter = expandOnEnter;
                return this as RowExpander.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RowExpander.Builder ExpandOnDblClick(bool expandOnDblClick)
            {
                this.ToComponent().ExpandOnDblClick = expandOnDblClick;
                return this as RowExpander.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RowExpander.Builder SingleExpand(bool singleExpand)
            {
                this.ToComponent().SingleExpand = singleExpand;
                return this as RowExpander.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of RowExpander.Builder</returns>
            public virtual RowExpander.Builder Listeners(Action<RowExpanderListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as RowExpander.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of RowExpander.Builder</returns>
            public virtual RowExpander.Builder DirectEvents(Action<RowExpanderDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as RowExpander.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// Toggle (expand/collapse) row
			/// </summary>
            public virtual RowExpander.Builder ToggleRow(int row)
            {
                this.ToComponent().ToggleRow(row);
                return this;
            }
            
 			/// <summary>
			/// Expand all rows
			/// </summary>
            public virtual RowExpander.Builder ExpandAll()
            {
                this.ToComponent().ExpandAll();
                return this;
            }
            
 			/// <summary>
			/// Collapse all rows
			/// </summary>
            public virtual RowExpander.Builder CollapseAll()
            {
                this.ToComponent().CollapseAll();
                return this;
            }
            
 			/// <summary>
			/// Expand row
			/// </summary>
            public virtual RowExpander.Builder ExpandRow(int row)
            {
                this.ToComponent().ExpandRow(row);
                return this;
            }
            
 			/// <summary>
			/// Collapse row
			/// </summary>
            public virtual RowExpander.Builder CollapseRow(int row)
            {
                this.ToComponent().CollapseRow(row);
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public RowExpander.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RowExpander(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RowExpander.Builder RowExpander()
        {
            return this.RowExpander(new RowExpander());
        }

        /// <summary>
        /// 
        /// </summary>
        public RowExpander.Builder RowExpander(RowExpander component)
        {
            return new RowExpander.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RowExpander.Builder RowExpander(RowExpander.Config config)
        {
            return new RowExpander.Builder(new RowExpander(config));
        }
    }
}