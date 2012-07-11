/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel.Design;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class GridViewCollection : SingleItemCollection<GridView>
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(typeof(LazyControlJsonConverter))]
		[Description("")]
        public GridView View
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
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class GridViewCollectionEditor : CollectionEditor
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public GridViewCollectionEditor(Type type) : base(type) { }

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
                typeof(GridView),
                typeof(GroupingView)
              };
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override Type CreateCollectionItemType()
        {
            return typeof(GridView);
        }
    }
}
