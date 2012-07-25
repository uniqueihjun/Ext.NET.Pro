/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// The base class that other non-interacting Toolbar Item classes should extend in order to get some basic common toolbar item functionality.
    /// </summary>
    [Meta]
    [Description("")]
    public abstract partial class ToolbarItem : ComponentBase, IToolbarItem
    {
        private ToolbarBase toolbar;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarBase Toolbar
        {
            get
            {
                if (this.toolbar == null)
                {
                    this.toolbar = (ToolbarBase)ReflectionUtils.GetTypeOfParent(this, typeof(ToolbarBase));
                }
                
                return this.toolbar;
            }
        }

        /// <summary>
        /// Text to be used for the menu if the item is overflowed.
        /// </summary>
        [ConfigOption]
        [Category("4. ToolbarItem")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Text to be used for the menu if the item is overflowed.")]
        public virtual string OverflowText
        {
            get
            {
                return this.State.Get<string>("OverflowText", "");
            }
            set
            {
                this.State.Set("OverflowText", value);
            }
        }
    }
}