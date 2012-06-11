/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public abstract partial class SpinnerFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TSpinnerFieldBase, TBuilder> : TriggerFieldBase.Builder<TSpinnerFieldBase, TBuilder>
            where TSpinnerFieldBase : SpinnerFieldBase
            where TBuilder : Builder<TSpinnerFieldBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TSpinnerFieldBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Specifies whether the up and down arrow keys should trigger spinning up and down. Defaults to true.
			/// </summary>
            public virtual TBuilder KeyNavEnabled(bool keyNavEnabled)
            {
                this.ToComponent().KeyNavEnabled = keyNavEnabled;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Specifies whether the mouse wheel should trigger spinning up and down while the field has focus. Defaults to true.
			/// </summary>
            public virtual TBuilder MouseWheelEnabled(bool mouseWheelEnabled)
            {
                this.ToComponent().MouseWheelEnabled = mouseWheelEnabled;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Specifies whether the down spinner button is enabled. Defaults to true. To change this after the component is created, use the setSpinDownEnabled method.
			/// </summary>
            public virtual TBuilder SpinDownEnabled(bool spinDownEnabled)
            {
                this.ToComponent().SpinDownEnabled = spinDownEnabled;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Specifies whether the up spinner button is enabled. Defaults to true. To change this after the component is created, use the setSpinUpEnabled method.
			/// </summary>
            public virtual TBuilder SpinUpEnabled(bool spinUpEnabled)
            {
                this.ToComponent().SpinUpEnabled = spinUpEnabled;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetSpinDownEnabled(bool enabled)
            {
                this.ToComponent().SetSpinDownEnabled(enabled);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetSpinUpEnabled(bool enabled)
            {
                this.ToComponent().SetSpinUpEnabled(enabled);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SpinDown()
            {
                this.ToComponent().SpinDown();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SpinUp()
            {
                this.ToComponent().SpinUp();
                return this as TBuilder;
            }
            
        }        
    }
}