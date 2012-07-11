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
    public partial class MultiSelect
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : MultiSelectBase.Builder<MultiSelect, MultiSelect.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MultiSelect()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MultiSelect component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MultiSelect.Config config) : base(new MultiSelect(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MultiSelect component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of MultiSelect.Builder</returns>
            public virtual MultiSelect.Builder Listeners(Action<MultiSelectListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as MultiSelect.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of MultiSelect.Builder</returns>
            public virtual MultiSelect.Builder DirectEvents(Action<MultiSelectDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as MultiSelect.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiSelect.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MultiSelect(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public MultiSelect.Builder MultiSelect()
        {
            return this.MultiSelect(new MultiSelect());
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiSelect.Builder MultiSelect(MultiSelect component)
        {
            return new MultiSelect.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiSelect.Builder MultiSelect(MultiSelect.Config config)
        {
            return new MultiSelect.Builder(new MultiSelect(config));
        }
    }
}