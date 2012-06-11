/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ProxyCollection : SingleItemStateCollection<DataProxy>
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.ObjectAllowEmpty)]
		[Description("")]
        public DataProxy Proxy
        {
            get
            {
                if (this.Count>0)
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
        protected override void InsertItem(int index, DataProxy item)
        {
            base.InsertItem(index, item);
            item.Store = Store;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void SetItem(int index, DataProxy item)
        {
            base.SetItem(index, item);
            item.Store = Store;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ProxyCollectionEditor : CollectionEditor
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ProxyCollectionEditor(Type type) : base(type) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override bool CanSelectMultipleInstances()
        {
            return false;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override Type[] CreateNewItemTypes()
        {
            return new Type[]
              {
                typeof(HttpProxy),
                typeof(ScriptTagProxy)
              };
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override Type CreateCollectionItemType()
        {
            return typeof(HttpProxy);
        }
    }
}
