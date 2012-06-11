/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Adds a separator bar to a menu, used to divide logical groups of menu items. Generally you will add one of these by using "-" in your call to add() or in your items config rather than creating one directly.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("Adds a separator bar to a menu, used to divide logical groups of menu items. Generally you will add one of these by using \" - \" in your call to add() or in your items config rather than creating one directly.")]
    public partial class MenuSeparator : MenuItemBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public MenuSeparator() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.menu.Separator";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "menuseparator";
            }
        }

        /// <summary>
        /// The CSS class used by the separator item to show the incised line. Defaults to Ext.baseCSSPrefix + 'menu-item-separator'.
        /// </summary>
        [ConfigOption]
        [Category("5. Separator")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The CSS class used by the separator item to show the incised line. Defaults to Ext.baseCSSPrefix + 'menu-item-separator'.")]
        public virtual string SeparatorCls
        {
            get
            {
                return this.State.Get<string>("SeparatorCls", "");
            }
            set
            {
                this.State.Set("SeparatorCls", value);
            }
        }
    }
}