/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class DropDownFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TDropDownFieldBase, TBuilder> : PickerField.Builder<TDropDownFieldBase, TBuilder>
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
			/// 
			/// </summary>
            public virtual TBuilder ValueHiddenName(string valueHiddenName)
            {
                this.ToComponent().ValueHiddenName = valueHiddenName;
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
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Component(Action<ItemsCollection<AbstractPanel>> action)
            {
                action(this.ToComponent().Component);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// The id of the node, a DOM node or an existing Element that will be the content Container to render this component into.
			/// </summary>
            public virtual TBuilder ComponentRenderTo(string componentRenderTo)
            {
                this.ToComponent().ComponentRenderTo = componentRenderTo;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Function to syncronize value of the field and dropdown control
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder SyncValue(Action<JFunction> action)
            {
                action(this.ToComponent().SyncValue);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}