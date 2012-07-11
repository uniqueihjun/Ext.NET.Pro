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
    public partial class HeaderColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<HeaderColumn, HeaderColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HeaderColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HeaderColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HeaderColumn.Config config) : base(new HeaderColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HeaderColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The target element which will be placed to the header.
			/// </summary>
            public virtual HeaderColumn.Builder Target(string target)
            {
                this.ToComponent().Target = target;
                return this as HeaderColumn.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HeaderColumn.Builder AutoWidthElement(bool autoWidthElement)
            {
                this.ToComponent().AutoWidthElement = autoWidthElement;
                return this as HeaderColumn.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HeaderColumn.Builder AutoWidthCorrection(int autoWidthCorrection)
            {
                this.ToComponent().AutoWidthCorrection = autoWidthCorrection;
                return this as HeaderColumn.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HeaderColumn.Builder Cls(string cls)
            {
                this.ToComponent().Cls = cls;
                return this as HeaderColumn.Builder;
            }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder Component(ItemsCollection<Component> component)
            // {
            //    this.ToComponent().Component = component;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public HeaderColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HeaderColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public HeaderColumn.Builder HeaderColumn()
        {
            return this.HeaderColumn(new HeaderColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public HeaderColumn.Builder HeaderColumn(HeaderColumn component)
        {
            return new HeaderColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HeaderColumn.Builder HeaderColumn(HeaderColumn.Config config)
        {
            return new HeaderColumn.Builder(new HeaderColumn(config));
        }
    }
}