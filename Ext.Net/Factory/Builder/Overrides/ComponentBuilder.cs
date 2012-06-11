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
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class AbstractComponent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAbstractComponent"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TAbstractComponent, TBuilder> : Observable.Builder<TAbstractComponent, TBuilder>
            where TAbstractComponent : AbstractComponent
            where TBuilder : Builder<TAbstractComponent, TBuilder>
        {
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/

            /// <summary>
            /// 
            /// </summary>
            /// <param name="control"></param>
            /// <returns></returns>
            public virtual TBuilder RenderTo(Control control)
            {
                return this.RenderTo(control.ClientID);
            }


            /*  Methods
                -----------------------------------------------------------------------------------------------*/

            //protected internal TBuilder SetParent<TParent, TParentBuilder>(TParent parent, TParentBuilder parentBuilder)
            //    where TParent : ComponentBase
            //    where TParentBuilder : ComponentBase.Builder<TParent, TParentBuilder>
            //{
            //    var temp = new ParentComponentBase<TParent, TParentBuilder>(parent, parentBuilder);
                
            //    return this as TBuilder;
            //}

            //public virtual TBuilder Parent()
            //{
            //    return this.OwnerBuilder as IControlBuilder<AbstractComponent>;
            //}
        }        
    }
}