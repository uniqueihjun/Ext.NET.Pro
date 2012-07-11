/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class TriggerField
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseTriggerField.Builder<TriggerField, TriggerField.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TriggerField()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TriggerField component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TriggerField.Config config) : base(new TriggerField(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TriggerField component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TriggerField.Builder</returns>
            public virtual TriggerField.Builder Listeners(Action<TriggerFieldListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TriggerField.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TriggerField.Builder</returns>
            public virtual TriggerField.Builder DirectEvents(Action<TriggerFieldDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TriggerField.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TriggerField.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TriggerField(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TriggerField.Builder TriggerField()
        {
            return this.TriggerField(new TriggerField());
        }

        /// <summary>
        /// 
        /// </summary>
        public TriggerField.Builder TriggerField(TriggerField component)
        {
            return new TriggerField.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TriggerField.Builder TriggerField(TriggerField.Config config)
        {
            return new TriggerField.Builder(new TriggerField(config));
        }
    }
}