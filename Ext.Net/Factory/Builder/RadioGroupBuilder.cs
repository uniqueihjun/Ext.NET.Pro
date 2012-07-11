/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class RadioGroup
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CheckboxGroupBase.Builder<RadioGroup, RadioGroup.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RadioGroup()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadioGroup component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadioGroup.Config config) : base(new RadioGroup(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RadioGroup component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The default type of content Container represented by this object as registered in Ext.ComponentMgr (defaults to 'radio').
			/// </summary>
            public virtual RadioGroup.Builder DefaultType(string defaultType)
            {
                this.ToComponent().DefaultType = defaultType;
                return this as RadioGroup.Builder;
            }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(RadioGroupListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(RadioGroupDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Items collection
			// /// </summary>
            // public virtual TBuilder Items(ItemsCollection<Radio> items)
            // {
            //    this.ToComponent().Items = items;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// Automatic grouping (defaults to true).
			/// </summary>
            public virtual RadioGroup.Builder AutomaticGrouping(bool automaticGrouping)
            {
                this.ToComponent().AutomaticGrouping = automaticGrouping;
                return this as RadioGroup.Builder;
            }
             
 			/// <summary>
			/// The field's HTML name attribute.
			/// </summary>
            public virtual RadioGroup.Builder GroupName(string groupName)
            {
                this.ToComponent().GroupName = groupName;
                return this as RadioGroup.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RadioGroup.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RadioGroup(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RadioGroup.Builder RadioGroup()
        {
            return this.RadioGroup(new RadioGroup());
        }

        /// <summary>
        /// 
        /// </summary>
        public RadioGroup.Builder RadioGroup(RadioGroup component)
        {
            return new RadioGroup.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RadioGroup.Builder RadioGroup(RadioGroup.Config config)
        {
            return new RadioGroup.Builder(new RadioGroup(config));
        }
    }
}