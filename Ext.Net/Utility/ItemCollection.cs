/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ItemCollection : Collection<Component>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void InsertItem(int index, Component item)
        {
            this.CheckItem(item);
            base.InsertItem(index, item);

            if (this.AfterInsert != null)
            {
                this.AfterInsert(item); 
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void SetItem(int index, Component item)
        {
            this.CheckItem(item);
            base.SetItem(index, item);

            if (this.AfterInsert != null)
            {
                this.AfterInsert(item);
            }
        }

        private void CheckItem(Component item)
        {
            if (this.SingleItemMode && this.Count>0)
            {
                throw new InvalidOperationException("Only one Component allowed in the Items Collection");
            }
            
            item.AutoRender = false;

            if (item is Viewport || item is Window)
            {
                throw new InvalidCastException("Invalid type of Control ({0}). This type can not be added to Items Collection".FormatWith(item.GetType()));
            }
        }

        private bool singleItemMode;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool SingleItemMode
        {
            get 
            { 
                return this.singleItemMode; 
            }
            internal set
            {
                this.singleItemMode = value;
            }
        }

        internal delegate void AfterInsertHandler(Component item);
        internal event AfterInsertHandler AfterInsert;
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ItemCollectionEditor : CollectionEditor
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ItemCollectionEditor(Type type) : base(type) {}

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
                typeof(Panel),
                typeof(TabPanel)
              };
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override Type CreateCollectionItemType()
        {
            return typeof(Panel);
        }
    }
}