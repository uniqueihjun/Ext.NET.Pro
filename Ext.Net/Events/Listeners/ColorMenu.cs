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
    public partial class ColorMenuListeners : MenuListeners
    {
        private ComponentListener select;

		/// <summary>
		/// 
		/// </summary>
        [ListenerArgument(0, "item", typeof(ColorPalette), "palette")]
        [ListenerArgument(1, "color", typeof(object), "color")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
		[Description("")]
        public virtual ComponentListener Select
        {
            get
            {
                if (this.select == null)
                {
                    this.select = new ComponentListener();
                }

                return this.select;
            }
        }
    }
}