/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class UpdateProxyCollection : SingleItemStateCollection<HttpWriteProxy>
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.Object)]
		[Description("")]
        public HttpWriteProxy Proxy
        {
            get
            {
                if (this.Count > 0)
                {
                    return this[0];
                }

                return null;
            }
        }

        private StoreBase store;

        internal StoreBase Store
        {
            get { return store; }
            set { store = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void InsertItem(int index, HttpWriteProxy item)
        {
            base.InsertItem(index, item);
            item.Store = Store;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void SetItem(int index, HttpWriteProxy item)
        {
            base.SetItem(index, item);
            item.Store = Store;
        }
    }
}
