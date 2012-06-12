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
    public partial class MultiSelect
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : MultiSelectBase<ListItem>.Builder<MultiSelect, MultiSelect.Builder>
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
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(MultiSelectListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side DirectEventHandlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(MultiSelectDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

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