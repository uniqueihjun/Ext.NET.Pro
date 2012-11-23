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
    public abstract partial class ServerProxy
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TServerProxy, TBuilder> : AbstractProxy.Builder<TServerProxy, TBuilder>
            where TServerProxy : ServerProxy
            where TBuilder : Builder<TServerProxy, TBuilder>
        {
            
            public virtual TBuilder Reader(AbstractReader reader)
            {
                this.ToComponent().Reader.Add(reader);
                return this as TBuilder;
            }			
        }        
    }
}