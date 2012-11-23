/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Reflection;

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
#if NET40
            public virtual TBuilder Config(string name, object value)
            {
                ((DynamicConfigDictionary)this.ToComponent().Configs).SetDynamicValue(name, value);                
                return this as TBuilder;
            }

            public virtual TBuilder Config(object configs)
            {
                if (configs != null)
                {
                    foreach (PropertyInfo x in configs.GetType().GetProperties())
	                {
                        ((DynamicConfigDictionary)this.ToComponent().Configs).SetDynamicValue(x.Name, x.GetValue(configs, null));
	                }                    
                }
                return this as TBuilder;
            }
#endif
        }
    }
}