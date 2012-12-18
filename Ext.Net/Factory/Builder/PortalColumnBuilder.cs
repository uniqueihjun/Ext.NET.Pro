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
    public partial class PortalColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TPortalColumn, TBuilder> : Panel.Builder<TPortalColumn, TBuilder>
            where TPortalColumn : PortalColumn
            where TBuilder : Builder<TPortalColumn, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TPortalColumn component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : PortalColumn.Builder<PortalColumn, PortalColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new PortalColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PortalColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PortalColumn.Config config) : base(new PortalColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(PortalColumn component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public PortalColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.PortalColumn(this);
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
        public PortalColumn.Builder PortalColumn()
        {
#if MVC
			return this.PortalColumn(new PortalColumn { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.PortalColumn(new PortalColumn());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public PortalColumn.Builder PortalColumn(PortalColumn component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new PortalColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public PortalColumn.Builder PortalColumn(PortalColumn.Config config)
        {
#if MVC
			return new PortalColumn.Builder(new PortalColumn(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new PortalColumn.Builder(new PortalColumn(config));
#endif			
        }
    }
}