/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    internal class CollectionDataSource : IDataSource
    {
        static readonly string[] names = new string[0];
        readonly IEnumerable collection;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public CollectionDataSource(IEnumerable collection)
        {
            this.collection = collection;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public event EventHandler DataSourceChanged
        {
            add { }
            remove { }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public DataSourceView GetView(string viewName)
        {
            return new CollectionDataSourceView(this, viewName, collection);
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public ICollection GetViewNames()
        {
            return names;
        }
    }
}
