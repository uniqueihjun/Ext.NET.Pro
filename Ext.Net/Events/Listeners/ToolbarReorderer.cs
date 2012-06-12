/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ToolbarReordererListeners : ComponentListeners
    {
        private ComponentListener reorder;

        /// <summary>
        /// Fires after a reorder has occured.
        /// </summary>
        [ListenerArgument(0, "button", typeof(object), "moved button")]
        [ListenerArgument(1, "tbar", typeof(Toolbar), "")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("reorder", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after a reorder has occured.")]
        public virtual ComponentListener Reorder
        {
            get
            {
                if (this.reorder == null)
                {
                    this.reorder = new ComponentListener();
                }

                return this.reorder;
            }
        }
    }
}