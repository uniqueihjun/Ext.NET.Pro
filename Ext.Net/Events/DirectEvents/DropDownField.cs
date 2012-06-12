/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class DropDownFieldDirectEvents : TriggerFieldDirectEvents
    {
        private ComponentDirectEvent collapse;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("collapse", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Collapse
        {
            get
            {
                if (this.collapse == null)
                {
                    this.collapse = new ComponentDirectEvent();
                }

                return this.collapse;
            }
        }

        private ComponentDirectEvent expand;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("expand", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Expand
        {
            get
            {
                if (this.expand == null)
                {
                    this.expand = new ComponentDirectEvent();
                }

                return this.expand;
            }
        }
    }
}