/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ResourcesRegistrator
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ResourcesRegistrator.Builder<ResourcesRegistrator, ResourcesRegistrator.Builder>
        {            
            public virtual ResourcesRegistrator.Builder ResourceItems(string url)
            {
                this.ToComponent().ResourceItems.Add(new ClientResourceItem(url));   
                return this as ResourcesRegistrator.Builder;
            }

            public virtual ResourcesRegistrator.Builder ResourceItems(params string[] url)
            {
                this.ToComponent().ResourceItems.AddRange(url.Select(u=>new ClientResourceItem(u)));
                return this as ResourcesRegistrator.Builder;
            }

            public virtual ResourcesRegistrator.Builder ResourceItems(IEnumerable<string> url)
            {
                this.ToComponent().ResourceItems.AddRange(url.Select(u => new ClientResourceItem(u)));
                return this as ResourcesRegistrator.Builder;
            }

            public virtual ResourcesRegistrator.Builder ResourceItems(string url, bool isCss)
            {
                this.ToComponent().ResourceItems.Add(new ClientResourceItem(url, isCss));
                return this as ResourcesRegistrator.Builder;
            }

            public virtual ResourcesRegistrator.Builder ResourceItems(bool isCss, params string[] url)
            {
                this.ToComponent().ResourceItems.AddRange(url.Select(u => new ClientResourceItem(u, isCss)));
                return this as ResourcesRegistrator.Builder;
            }

            public virtual ResourcesRegistrator.Builder ResourceItems(bool isCss, IEnumerable<string> url)
            {
                this.ToComponent().ResourceItems.AddRange(url.Select(u => new ClientResourceItem(u, isCss)));
                return this as ResourcesRegistrator.Builder;
            }

            public virtual ResourcesRegistrator.Builder ResourceItems(Type type, string resourceName)
            {
                this.ToComponent().ResourceItems.Add(new ClientResourceItem(type, resourceName));
                return this as ResourcesRegistrator.Builder;
            }

            public virtual ResourcesRegistrator.Builder ResourceItems(Type type, string resourceName, bool isCss)
            {
                this.ToComponent().ResourceItems.Add(new ClientResourceItem(type, resourceName, isCss));
                return this as ResourcesRegistrator.Builder;
            }
        }        
    }
}