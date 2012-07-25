/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    internal class CollectionDataSourceView : DataSourceView
    {
        readonly IEnumerable collection;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public CollectionDataSourceView(IDataSource owner, string viewName, IEnumerable collection)
            : base(owner, viewName)
        {
            this.collection = collection;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override IEnumerable ExecuteSelect(DataSourceSelectArguments arguments)
        {
            return collection;
        }
    }
}
