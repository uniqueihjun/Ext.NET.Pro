/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class ToolbarCollection : ItemsCollection<ToolbarBase>
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.Object)]
		[Description("")]
        public ToolbarBase Toolbar
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

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarCollection()
        {
            this.SingleItemMode = true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ToolbarCollectionEditor : CollectionEditor
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarCollectionEditor(Type type) : base(type) { }

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
                typeof(Toolbar),
                typeof(PagingToolbar)
              };
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override Type CreateCollectionItemType()
        {
            return typeof(Toolbar);
        }
    }
}
