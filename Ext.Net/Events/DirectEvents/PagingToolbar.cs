/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class PagingToolbarDirectEvents : BoxComponentDirectEvents
    {
        private ComponentDirectEvent change;

        /// <summary>
        /// Fires after page changing
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "data", typeof(object), "{total, activePage, pages}")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("change", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after page changing")]
        public virtual ComponentDirectEvent Change
        {
            get
            {
                if (this.change == null)
                {
                    this.change = new ComponentDirectEvent();
                }

                return this.change;
            }
        }

        private ComponentDirectEvent beforeChange;

        /// <summary>
        /// Fires before page changing
        /// </summary>
        [ListenerArgument(0, "item", typeof(Button), "this")]
        [ListenerArgument(1, "o", typeof(object), "{start, limit}")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforechange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before page changing")]
        public virtual ComponentDirectEvent BeforeChange
        {
            get
            {
                if (this.beforeChange == null)
                {
                    this.beforeChange = new ComponentDirectEvent();
                }

                return this.beforeChange;
            }
        }
    }
}