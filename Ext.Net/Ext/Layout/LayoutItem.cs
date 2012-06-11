/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing.Design;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [DefaultProperty("Items")]
    [ParseChildren(true, "Items")]
    [Description("")]
    public abstract partial class LayoutItem : StateManagedItem
    {
        ItemsCollection<Component> items;

        /// <summary>
        /// Gets the Items Collection
        /// </summary>
        [Meta]
        [Category("2. LayoutItem")]
        [PersistenceMode(PersistenceMode.InnerDefaultProperty)]
        [Editor(typeof(ItemCollectionEditor), typeof(UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Items")]
        public virtual ItemsCollection<Component> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new ItemsCollection<Component>();
                    this.items.SingleItemMode = true;
                }

                return this.items;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Control Control
        {
            get
            {
                return this.Items.Count > 0 ? this.Items[0] : null;
            }
        }
    }
}