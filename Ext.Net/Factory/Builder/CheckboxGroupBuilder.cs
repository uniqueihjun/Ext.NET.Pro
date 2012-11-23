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
    public partial class CheckboxGroup
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CheckboxGroupBase.Builder<CheckboxGroup, CheckboxGroup.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CheckboxGroup()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckboxGroup component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckboxGroup.Config config) : base(new CheckboxGroup(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CheckboxGroup component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The default type of content Container represented by this object as registered in Ext.ComponentMgr (defaults to 'checkbox').
			/// </summary>
            public virtual CheckboxGroup.Builder DefaultType(string defaultType)
            {
                this.ToComponent().DefaultType = defaultType;
                return this as CheckboxGroup.Builder;
            }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(CheckboxGroupListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(CheckboxGroupDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Items collection
			// /// </summary>
            // public virtual TBuilder Items(ItemsCollection<Checkbox> items)
            // {
            //    this.ToComponent().Items = items;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CheckboxGroup(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder CheckboxGroup()
        {
            return this.CheckboxGroup(new CheckboxGroup());
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder CheckboxGroup(CheckboxGroup component)
        {
            return new CheckboxGroup.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder CheckboxGroup(CheckboxGroup.Config config)
        {
            return new CheckboxGroup.Builder(new CheckboxGroup(config));
        }
    }
}