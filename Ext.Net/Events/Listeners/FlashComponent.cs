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
    public partial class FlashComponentListeners : BoxComponentListeners
    {
        private ComponentListener initialize;

        /// <summary>
        /// Fires after the component is initialized.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("initialize", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the flash is initialized.")]
        public virtual ComponentListener Initialize
        {
            get
            {
                if (this.initialize == null)
                {
                    this.initialize = new ComponentListener();
                }

                return this.initialize;
            }
        }
    }
}