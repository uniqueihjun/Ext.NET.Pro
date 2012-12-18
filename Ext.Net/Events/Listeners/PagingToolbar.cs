/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class PagingToolbarListeners : AbstractComponentListeners
    {
        private ComponentListener change;

        /// <summary>
        /// Fires after the active page has been changed.
        /// Parameters
        /// item : Ext.toolbar.Paging
        /// pageData : Object
        ///     An object that has these properties:
        ///         - total : Number
        ///             The total number of records in the dataset as returned by the server
        ///         - currentPage : Number
        ///             The current page number
        ///         - pageCount : Number
        ///             The total number of pages (calculated from the total number of records in the dataset as returned by the server and the current pageSize)
        ///         - toRecord : Number
        ///             The starting record index for the current page
        ///         - fromRecord : Number
        ///             The ending record index for the current page
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "pageData")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("change", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after page changing")]
        public virtual ComponentListener Change
        {
            get
            {
                return this.change ?? (this.change = new ComponentListener());
            }
        }

        private ComponentListener beforeChange;

        /// <summary>
        /// Fires just before the active page is changed. Return false to prevent the active page from being changed.
        /// Parameters
        /// this : Ext.toolbar.Paging
        /// page : Number
        ///     The page number that will be loaded on change
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "page")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforechange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before page changing")]
        public virtual ComponentListener BeforeChange
        {
            get
            {
                return this.beforeChange ?? (this.beforeChange = new ComponentListener());
            }
        }
    }
}