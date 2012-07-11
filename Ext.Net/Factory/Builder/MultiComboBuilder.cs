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
    public partial class MultiCombo
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ComboBoxBase.Builder<MultiCombo, MultiCombo.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MultiCombo()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MultiCombo component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MultiCombo.Config config) : base(new MultiCombo(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MultiCombo component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to wrap by square brackets.
			/// </summary>
            public virtual MultiCombo.Builder WrapBySquareBrackets(bool wrapBySquareBrackets)
            {
                this.ToComponent().WrapBySquareBrackets = wrapBySquareBrackets;
                return this as MultiCombo.Builder;
            }
             
 			/// <summary>
			/// Selection UI mode
			/// </summary>
            public virtual MultiCombo.Builder SelectionMode(MultiSelectMode selectionMode)
            {
                this.ToComponent().SelectionMode = selectionMode;
                return this as MultiCombo.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of MultiCombo.Builder</returns>
            public virtual MultiCombo.Builder Listeners(Action<ComboBoxListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as MultiCombo.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of MultiCombo.Builder</returns>
            public virtual MultiCombo.Builder DirectEvents(Action<ComboBoxDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as MultiCombo.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// Select all items
			/// </summary>
            public virtual MultiCombo.Builder SelectAll()
            {
                this.ToComponent().SelectAll();
                return this;
            }
            
 			/// <summary>
			/// Deselect item by index
			/// </summary>
            public virtual MultiCombo.Builder DeselectItem(int index)
            {
                this.ToComponent().DeselectItem(index);
                return this;
            }
            
 			/// <summary>
			/// Deselect item by value
			/// </summary>
            public virtual MultiCombo.Builder DeselectItem(string value)
            {
                this.ToComponent().DeselectItem(value);
                return this;
            }
            
 			/// <summary>
			/// Select item by index
			/// </summary>
            public virtual MultiCombo.Builder SelectItem(int index)
            {
                this.ToComponent().SelectItem(index);
                return this;
            }
            
 			/// <summary>
			/// Select item by value
			/// </summary>
            public virtual MultiCombo.Builder SelectItem(string value)
            {
                this.ToComponent().SelectItem(value);
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiCombo.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MultiCombo(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public MultiCombo.Builder MultiCombo()
        {
            return this.MultiCombo(new MultiCombo());
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiCombo.Builder MultiCombo(MultiCombo component)
        {
            return new MultiCombo.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiCombo.Builder MultiCombo(MultiCombo.Config config)
        {
            return new MultiCombo.Builder(new MultiCombo(config));
        }
    }
}