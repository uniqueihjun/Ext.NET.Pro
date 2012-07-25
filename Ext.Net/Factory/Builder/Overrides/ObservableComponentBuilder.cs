/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Dynamic;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class Observable
    {
        new public abstract partial class Builder<TObservable, TBuilder> : BaseControl.Builder<TObservable, TBuilder>
            where TObservable : Observable
            where TBuilder : Builder<TObservable, TBuilder>
        {
            public virtual TBuilder Config(string name, object value)
            {
                ((DynamicConfigDictionary)this.ToComponent().Configs).SetDynamicValue(name, value);
                
                return this as TBuilder;
            }  
        }
    }
}