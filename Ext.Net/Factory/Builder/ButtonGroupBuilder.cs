/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class ButtonGroup
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TButtonGroup, TBuilder> : Panel.Builder<TButtonGroup, TBuilder>
            where TButtonGroup : ButtonGroup
            where TBuilder : Builder<TButtonGroup, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TButtonGroup component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The columns configuration property passed to the configured layout manager. See Ext.layout.TableLayout.columns.
			/// </summary>
            public virtual TBuilder Columns(int columns)
            {
                this.ToComponent().Columns = columns;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ButtonGroup.Builder<ButtonGroup, ButtonGroup.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ButtonGroup()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ButtonGroup component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ButtonGroup.Config config) : base(new ButtonGroup(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ButtonGroup component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ButtonGroup.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ButtonGroup(this);
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
        public ButtonGroup.Builder ButtonGroup()
        {
#if MVC
			return this.ButtonGroup(new ButtonGroup { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ButtonGroup(new ButtonGroup());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ButtonGroup.Builder ButtonGroup(ButtonGroup component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ButtonGroup.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ButtonGroup.Builder ButtonGroup(ButtonGroup.Config config)
        {
#if MVC
			return new ButtonGroup.Builder(new ButtonGroup(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ButtonGroup.Builder(new ButtonGroup(config));
#endif			
        }
    }
}