/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    public partial class MultiSelectionModelListeners : ComponentListeners
    {
        private ComponentListener selectionChange;

        /// <summary>
        /// Fires when the selected nodes change
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "nodes")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("selectionchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the selected nodes change")]
        public virtual ComponentListener SelectionChange
        {
            get
            {
                if (this.selectionChange == null)
                {
                    this.selectionChange = new ComponentListener();
                }

                return this.selectionChange;
            }
        }
    }
}