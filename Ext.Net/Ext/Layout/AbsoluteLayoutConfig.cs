/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// This is a layout that inherits the anchoring of Ext.layout.container.Anchor and adds the ability for x/y positioning using the standard x and y component config options.
    /// This class is intended to be extended or created via the layout configuration property. See Ext.container.Container.layout for additional details.
    /// </summary>
    public partial class AbsoluteLayoutConfig : AnchorLayoutConfig
    {
        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AbsoluteLayoutConfig() { }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("type")]
        [DefaultValue("")]
        protected override string LayoutType
        {
            get
            {
                return "absolute";
            }
        }

        /// <summary>
        /// True indicates that changes to one item in this layout do not effect the layout in general. This may need to be set to false if Ext.AbstractComponent.autoScroll is enabled for the container. Defaults to: true
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(true)]
        [Description("True indicates that changes to one item in this layout do not effect the layout in general. This may need to be set to false if Ext.AbstractComponent.autoScroll is enabled for the container. Defaults to: true")]
        public virtual bool IgnoreOnContentChange
        {
            get
            {
                return this.State.Get<bool>("IgnoreOnContentChange", true);
            }
            set
            {
                this.State.Set("IgnoreOnContentChange", value);
            }
        }
    }
}
