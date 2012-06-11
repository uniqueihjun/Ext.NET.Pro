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
    /// This is a layout that enables anchoring of contained elements relative to the container's dimensions. If the container is resized, all anchored items are automatically rerendered according to their anchor rules.
    ///
    /// This class is intended to be extended or created via the layout: 'anchor' Ext.layout.AbstractContainer-layout config, and should generally not need to be created directly via the new keyword.
    ///
    /// AnchorLayout does not have any direct config options (other than inherited ones). By default, AnchorLayout will calculate anchor measurements based on the size of the container itself. However, the container using the AnchorLayout can supply an anchoring-specific config property of anchorSize. If anchorSize is specifed, the layout will use it as a virtual container for the purposes of calculating anchor measurements based on it instead, allowing the container to be sized independently of the anchoring logic if necessary.
    /// </summary>
    public partial class AnchorLayoutConfig : LayoutConfig
    {
        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AnchorLayoutConfig() { }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("type")]
        [DefaultValue("")]
        protected override string LayoutType
        {
            get
            {
                return "anchor";
            }
        }

        /// <summary>
        /// Default anchor for all child container items applied if no anchor or specific width is set on the child item. Defaults to '100%'.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(null)]
        [Description("Default anchor for all child container items applied if no anchor or specific width is set on the child item. Defaults to '100%'.")]
        public virtual string DefaultAnchor
        {
            get
            {
                return this.State.Get<string>("DefaultAnchor", null);
            }
            set
            {
                this.State.Set("DefaultAnchor", value);
            }
        }
    }
}
