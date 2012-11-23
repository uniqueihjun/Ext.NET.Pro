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
    public partial class ChildElement
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TChildElement, TBuilder> : BaseItem.Builder<TChildElement, TBuilder>
            where TChildElement : ChildElement
            where TBuilder : Builder<TChildElement, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TChildElement component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The property name on the Component for the child element.
			/// </summary>
            public virtual TBuilder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The id to combine with the Component's id that is the id of the child element.
			/// </summary>
            public virtual TBuilder ItemID(string itemID)
            {
                this.ToComponent().ItemID = itemID;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The id of the child element.
			/// </summary>
            public virtual TBuilder ID(string iD)
            {
                this.ToComponent().ID = iD;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ChildElement.Builder<ChildElement, ChildElement.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ChildElement()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChildElement component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChildElement.Config config) : base(new ChildElement(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ChildElement component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ChildElement.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ChildElement(this);
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
        public ChildElement.Builder ChildElement()
        {
#if MVC
			return this.ChildElement(new ChildElement { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ChildElement(new ChildElement());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ChildElement.Builder ChildElement(ChildElement component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ChildElement.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ChildElement.Builder ChildElement(ChildElement.Config config)
        {
#if MVC
			return new ChildElement.Builder(new ChildElement(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ChildElement.Builder(new ChildElement(config));
#endif			
        }
    }
}