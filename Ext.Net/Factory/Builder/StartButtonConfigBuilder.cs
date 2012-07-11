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
    public partial class StartButtonConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<StartButtonConfig, StartButtonConfig.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new StartButtonConfig()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(StartButtonConfig component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(StartButtonConfig.Config config) : base(new StartButtonConfig(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(StartButtonConfig component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The icon to use for the start button. See also, IconCls to set an icon with a custom Css class.
			/// </summary>
            public virtual StartButtonConfig.Builder Icon(Icon icon)
            {
                this.ToComponent().Icon = icon;
                return this as StartButtonConfig.Builder;
            }
             
 			/// <summary>
			/// A css class to be added to the start button icon element for applying css background images
			/// </summary>
            public virtual StartButtonConfig.Builder IconCls(string iconCls)
            {
                this.ToComponent().IconCls = iconCls;
                return this as StartButtonConfig.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual StartButtonConfig.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as StartButtonConfig.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public StartButtonConfig.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.StartButtonConfig(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public StartButtonConfig.Builder StartButtonConfig()
        {
            return this.StartButtonConfig(new StartButtonConfig());
        }

        /// <summary>
        /// 
        /// </summary>
        public StartButtonConfig.Builder StartButtonConfig(StartButtonConfig component)
        {
            return new StartButtonConfig.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public StartButtonConfig.Builder StartButtonConfig(StartButtonConfig.Config config)
        {
            return new StartButtonConfig.Builder(new StartButtonConfig(config));
        }
    }
}