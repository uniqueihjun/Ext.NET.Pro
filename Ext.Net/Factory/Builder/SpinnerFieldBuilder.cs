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
    public partial class SpinnerField
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : NumberFieldBase.Builder<SpinnerField, SpinnerField.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SpinnerField()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SpinnerField component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SpinnerField.Config config) : base(new SpinnerField(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SpinnerField component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Increment Value
			/// </summary>
            public virtual SpinnerField.Builder DeferHeight(bool deferHeight)
            {
                this.ToComponent().DeferHeight = deferHeight;
                return this as SpinnerField.Builder;
            }
             
 			/// <summary>
			/// Increment Value
			/// </summary>
            public virtual SpinnerField.Builder IncrementValue(double incrementValue)
            {
                this.ToComponent().IncrementValue = incrementValue;
                return this as SpinnerField.Builder;
            }
             
 			/// <summary>
			/// Alerternate Increment Value
			/// </summary>
            public virtual SpinnerField.Builder AlternateIncrementValue(double alternateIncrementValue)
            {
                this.ToComponent().AlternateIncrementValue = alternateIncrementValue;
                return this as SpinnerField.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SpinnerField.Builder TriggerClass(string triggerClass)
            {
                this.ToComponent().TriggerClass = triggerClass;
                return this as SpinnerField.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SpinnerField.Builder SplitterClass(string splitterClass)
            {
                this.ToComponent().SplitterClass = splitterClass;
                return this as SpinnerField.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SpinnerField.Builder DefaultValue(double defaultValue)
            {
                this.ToComponent().DefaultValue = defaultValue;
                return this as SpinnerField.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SpinnerField.Builder Accelerate(bool accelerate)
            {
                this.ToComponent().Accelerate = accelerate;
                return this as SpinnerField.Builder;
            }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(SpinnerFieldListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(SpinnerFieldDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual SpinnerField.Builder Spin()
            {
                this.ToComponent().Spin();
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual SpinnerField.Builder Spin(bool down)
            {
                this.ToComponent().Spin(down);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual SpinnerField.Builder Spin(bool down, bool alternate)
            {
                this.ToComponent().Spin(down, alternate);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual SpinnerField.Builder FixBoundries(double value)
            {
                this.ToComponent().FixBoundries(value);
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public SpinnerField.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SpinnerField(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SpinnerField.Builder SpinnerField()
        {
            return this.SpinnerField(new SpinnerField());
        }

        /// <summary>
        /// 
        /// </summary>
        public SpinnerField.Builder SpinnerField(SpinnerField component)
        {
            return new SpinnerField.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SpinnerField.Builder SpinnerField(SpinnerField.Config config)
        {
            return new SpinnerField.Builder(new SpinnerField(config));
        }
    }
}