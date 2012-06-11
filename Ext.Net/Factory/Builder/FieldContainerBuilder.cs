/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class FieldContainer
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : FieldContainerBase.Builder<FieldContainer, FieldContainer.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FieldContainer()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldContainer component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldContainer.Config config) : base(new FieldContainer(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FieldContainer component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of FieldContainer.Builder</returns>
            public virtual FieldContainer.Builder Listeners(Action<FieldContainerListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as FieldContainer.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of FieldContainer.Builder</returns>
            public virtual FieldContainer.Builder DirectEvents(Action<FieldContainerDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as FieldContainer.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldContainer.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FieldContainer(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FieldContainer.Builder FieldContainer()
        {
            return this.FieldContainer(new FieldContainer());
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldContainer.Builder FieldContainer(FieldContainer component)
        {
            return new FieldContainer.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldContainer.Builder FieldContainer(FieldContainer.Config config)
        {
            return new FieldContainer.Builder(new FieldContainer(config));
        }
    }
}