/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class ComboBox
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ComboBoxBaseSingle<ListItem>.Builder<ComboBox, ComboBox.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ComboBox()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ComboBox component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ComboBox.Config config) : base(new ComboBox(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ComboBox component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(ComboBoxListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(ComboBoxDirectEvents directEvents)
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
        public ComboBox.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ComboBox(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ComboBox.Builder ComboBox()
        {
            return this.ComboBox(new ComboBox());
        }

        /// <summary>
        /// 
        /// </summary>
        public ComboBox.Builder ComboBox(ComboBox component)
        {
            return new ComboBox.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ComboBox.Builder ComboBox(ComboBox.Config config)
        {
            return new ComboBox.Builder(new ComboBox(config));
        }
    }
}