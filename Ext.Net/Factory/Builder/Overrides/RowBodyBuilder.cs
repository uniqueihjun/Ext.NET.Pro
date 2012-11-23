/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    public partial class RowBody
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TRowBody, TBuilder> : GridFeature.Builder<TRowBody, TBuilder>
            where TRowBody : RowBody
            where TBuilder : Builder<TRowBody, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action">The action delegate</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GetAdditionalData(string handler)
            {
                if(JFunction.IsFunctionName(handler))
                {
                    this.ToComponent().GetAdditionalData.Fn = handler;
                }
                else
                {
                    this.ToComponent().GetAdditionalData.Handler = handler;
                }
                
                return this as TBuilder;
            }
        }
    }
}