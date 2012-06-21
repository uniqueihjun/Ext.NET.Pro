/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public abstract partial class AbstractValidation
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TAbstractValidation, TBuilder> : BaseItem.Builder<TAbstractValidation, TBuilder>
            where TAbstractValidation : AbstractValidation
            where TBuilder : Builder<TAbstractValidation, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAbstractValidation component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The name of the field to validate
			/// </summary>
            public virtual TBuilder Field(string field)
            {
                this.ToComponent().Field = field;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The error message used when a validation fails
			/// </summary>
            public virtual TBuilder Message(string message)
            {
                this.ToComponent().Message = message;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}