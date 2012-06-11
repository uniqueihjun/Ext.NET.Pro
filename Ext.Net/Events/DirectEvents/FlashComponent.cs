/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    public partial class FlashComponentDirectEvents : BoxComponentDirectEvents
    {
        private ComponentDirectEvent initialize;

        /// <summary>
        /// Fires after the component is resized.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("initialize", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the flash is initialized.")]
        public virtual ComponentDirectEvent Initialize
        {
            get
            {
                if (this.initialize == null)
                {
                    this.initialize = new ComponentDirectEvent();
                }

                return this.initialize;
            }
        }
    }
}