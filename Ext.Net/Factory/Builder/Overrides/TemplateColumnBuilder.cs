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
    public partial class TemplateColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTemplateColumn, TBuilder> : CellCommandColumn.Builder<TTemplateColumn, TBuilder>
            where TTemplateColumn : TemplateColumn
            where TBuilder : Builder<TTemplateColumn, TBuilder>
        {
 			/// <summary>
			/// An XTemplate, or an XTemplate definition string to use to process a Model's data to produce a column's rendered value.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder TemplateString(Func<object, object> html)
            {
                object result = html(null);
                this.ToComponent().Template.Html = result.ToString();

                return this as TBuilder;
            }			
        }		
    }
}