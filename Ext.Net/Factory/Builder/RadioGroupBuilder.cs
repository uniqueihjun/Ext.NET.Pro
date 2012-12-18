/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class RadioGroup
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TRadioGroup, TBuilder> : CheckboxGroupBase.Builder<TRadioGroup, TBuilder>
            where TRadioGroup : RadioGroup
            where TBuilder : Builder<TRadioGroup, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TRadioGroup component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<CheckboxGroupListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<CheckboxGroupDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Automatic grouping (defaults to true).
			/// </summary>
            public virtual TBuilder AutomaticGrouping(bool automaticGrouping)
            {
                this.ToComponent().AutomaticGrouping = automaticGrouping;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The field's HTML name attribute.
			/// </summary>
            public virtual TBuilder GroupName(string groupName)
            {
                this.ToComponent().GroupName = groupName;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : RadioGroup.Builder<RadioGroup, RadioGroup.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public RadioGroup.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RadioGroup(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.RadioGroup(new RadioGroup { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.RadioGroup(new RadioGroup());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public RadioGroup.Builder RadioGroup(RadioGroup component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new RadioGroup.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RadioGroup.Builder RadioGroup(RadioGroup.Config config)
        {
#if MVC
			return new RadioGroup.Builder(new RadioGroup(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new RadioGroup.Builder(new RadioGroup(config));
#endif			
        }
    }
}