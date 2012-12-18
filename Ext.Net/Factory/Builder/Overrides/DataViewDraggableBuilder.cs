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
 			/// <summary>
			/// The template used in the ghost DataView
			/// </summary>
            public virtual TBuilder GhostTpl(Func<object, object> html)
            {
                object result = html(null);
                this.ToComponent().GhostTpl = new XTemplate { Html = result.ToString() };

                return this as TBuilder;
            }			
        }		
    }    
}