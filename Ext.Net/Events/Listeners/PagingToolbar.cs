/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class PagingToolbarListeners : BoxComponentListeners
    {
        private ComponentListener change;

        /// <summary>
        /// Fires after page changing
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "data", typeof(object), "{total, activePage, pages}")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("change", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after page changing")]
        public virtual ComponentListener Change
        {
            get
            {
                if (this.change == null)
                {
                    this.change = new ComponentListener();
                }

                return this.change;
            }
        }

        private ComponentListener beforeChange;

        /// <summary>
        /// Fires before page changing
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "o", typeof(object), "{start, limit}")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforechange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before page changing")]
        public virtual ComponentListener BeforeChange
        {
            get
            {
                if (this.beforeChange == null)
                {
                    this.beforeChange = new ComponentListener();
                }

                return this.beforeChange;
            }
        }
    }
}