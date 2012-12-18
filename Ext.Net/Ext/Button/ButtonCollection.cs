/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ButtonCollection : Collection<Button>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void InsertItem(int index, Button item)
        {
            base.InsertItem(index, item);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void SetItem(int index, Button item)
        {
            base.SetItem(index, item);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ButtonCollectionEditor : CollectionEditor
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ButtonCollectionEditor(Type type) : base(type) { }

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
                typeof(Button)
                //typeof(Button),
                //typeof(SplitButton)
            };
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override Type CreateCollectionItemType()
        {
            return typeof(Button);
        }
    }
}