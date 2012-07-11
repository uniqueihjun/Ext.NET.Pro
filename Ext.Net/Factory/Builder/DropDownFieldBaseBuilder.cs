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
    public abstract partial class DropDownFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDropDownFieldBase, TBuilder> : BaseTriggerField.Builder<TDropDownFieldBase, TBuilder>
            where TDropDownFieldBase : DropDownFieldBase
            where TBuilder : Builder<TDropDownFieldBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDropDownFieldBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The Text value to initialize this field with.
			/// </summary>
            public virtual TBuilder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The underlying value which mapping on the Text, similar the Value property but can be set declarative
			/// </summary>
            public virtual TBuilder UnderlyingValue(string underlyingValue)
            {
                this.ToComponent().UnderlyingValue = underlyingValue;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mode(DropDownMode mode)
            {
                this.ToComponent().Mode = mode;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// False to hide the component when the field is blurred. Defaults to false.
			/// </summary>
            public virtual TBuilder AllowBlur(bool allowBlur)
            {
                this.ToComponent().AllowBlur = allowBlur;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to not initialize the list for this combo until the field is focused. (defaults to true).
			/// </summary>
            public virtual TBuilder LazyInit(bool lazyInit)
            {
                this.ToComponent().LazyInit = lazyInit;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A valid anchor position value. See Ext.Element.alignTo for details on supported anchor positions (defaults to 'tl-bl').
			/// </summary>
            public virtual TBuilder ComponentAlign(string componentAlign)
            {
                this.ToComponent().ComponentAlign = componentAlign;
                return this as TBuilder;
            }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder Component(ItemsCollection<PanelBase> component)
            // {
            //    this.ToComponent().Component = component;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// The id of the node, a DOM node or an existing Element that will be the content Container to render this component into.
			/// </summary>
            public virtual TBuilder ComponentRenderTo(string componentRenderTo)
            {
                this.ToComponent().ComponentRenderTo = componentRenderTo;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}