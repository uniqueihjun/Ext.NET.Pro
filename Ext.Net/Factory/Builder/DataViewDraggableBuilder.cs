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
    public partial class DataViewDraggable
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDataViewDraggable, TBuilder> : Plugin.Builder<TDataViewDraggable, TBuilder>
            where TDataViewDraggable : DataViewDraggable
            where TBuilder : Builder<TDataViewDraggable, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDataViewDraggable component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The CSS class added to the outermost element of the created ghost proxy
			/// </summary>
            public virtual TBuilder GhostCls(string ghostCls)
            {
                this.ToComponent().GhostCls = ghostCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The template used in the ghost DataView
			/// </summary>
            public virtual TBuilder GhostTpl(XTemplate ghostTpl)
            {
                this.ToComponent().GhostTpl = ghostTpl;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Config object that is applied to the internally created DragZone
			/// </summary>
            public virtual TBuilder DDConfig(DragZone dDConfig)
            {
                this.ToComponent().DDConfig = dDConfig;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DataViewDraggable.Builder<DataViewDraggable, DataViewDraggable.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DataViewDraggable()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewDraggable component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewDraggable.Config config) : base(new DataViewDraggable(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DataViewDraggable component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewDraggable.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DataViewDraggable(this);
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
        public DataViewDraggable.Builder DataViewDraggable()
        {
#if MVC
			return this.DataViewDraggable(new DataViewDraggable { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DataViewDraggable(new DataViewDraggable());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewDraggable.Builder DataViewDraggable(DataViewDraggable component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DataViewDraggable.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewDraggable.Builder DataViewDraggable(DataViewDraggable.Config config)
        {
#if MVC
			return new DataViewDraggable.Builder(new DataViewDraggable(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DataViewDraggable.Builder(new DataViewDraggable(config));
#endif			
        }
    }
}