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
    public partial class FormPanel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : FormPanelBase.Builder<FormPanel, FormPanel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FormPanel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FormPanel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FormPanel.Config config) : base(new FormPanel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FormPanel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(FormPanelListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(FormPanelDirectEvents directEvents)
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
        public FormPanel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FormPanel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FormPanel.Builder FormPanel()
        {
            return this.FormPanel(new FormPanel());
        }

        /// <summary>
        /// 
        /// </summary>
        public FormPanel.Builder FormPanel(FormPanel component)
        {
            return new FormPanel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FormPanel.Builder FormPanel(FormPanel.Config config)
        {
            return new FormPanel.Builder(new FormPanel(config));
        }
    }
}