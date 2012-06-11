/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class PanelHeaderListeners : ContainerListeners
    {
        private ComponentListener click;

        /// <summary>
        /// Fires when the header is clicked. This event will not be fired if the click was on a Ext.panel.Tool
        /// Parameters
        /// item : Ext.panel.Header
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the header is clicked. This event will not be fired if the click was on a Ext.panel.Tool")]
        public virtual ComponentListener Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentListener());
            }
        }

        private ComponentListener dblclick;

        /// <summary>
        /// Fires when the header is double clicked. This event will not be fired if the click was on a Ext.panel.Tool
        /// Parameters
        /// item : Ext.panel.Header
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dblclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the header is double clicked. This event will not be fired if the click was on a Ext.panel.Tool")]
        public virtual ComponentListener DblClick
        {
            get
            {
                return this.dblclick ?? (this.dblclick = new ComponentListener());
            }
        }
    }
}