/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class CycleButtonListeners : SplitButtonListeners
    {
        private ComponentListener change;

        /// <summary>
        /// Fires after the button's active menu items has changed. Note that if a changeHandler function is set on this CycleButton, it will be called instead on active items change and this change event will not be fired.
        /// Parameters
        /// item : Ext.button.Cycle
        /// checkitem : Ext.menu.CheckItem
        ///     The menu item that was selected
        /// </summary>
        [ListenerArgument(0, "item", typeof(CycleButton), "this")]
        [ListenerArgument(1, "checkitem")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("change", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the button's active menu items has changed. Note that if a changeHandler function is set on this CycleButton, it will be called instead on active items change and this change event will not be fired.")]
        public virtual ComponentListener Change
        {
            get
            {
                return this.change ?? (this.change = new ComponentListener());
            }
        }
    }
}