/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
    /// This is a base class for layouts that contain a single item that automatically expands to fill the layout's container. This class is intended to be extended or created via the layout:'fit' Ext.container.Container.layout config, and should generally not need to be created directly via the new keyword.
    /// Fit layout does not have any direct config options (other than inherited ones). To fit a panel to a container using Fit layout, simply set layout: 'fit' on the container and add a single panel to it.
    /// If the container has multiple items, all of the items will all be equally sized. This is usually not desired, so to avoid this, place only a single item in the container. This sizing of all items can be used to provide a background image that is "behind" another item such as a dataview if you also absolutely position the items.
	/// </summary>
	[Description("")]
    public partial class CheckboxGroupLayoutConfig : LayoutConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("type")]
        [DefaultValue("")]
        protected override string LayoutType
        {
            get
            {
                return "checkboxgroup";
            }
        }

        /// <summary>
        /// By default, CheckboxGroup allocates all available space to the configured columns meaning that column are evenly spaced across the container.
        /// To have each column only be wide enough to fit the container Checkboxes (or Radios), set autoFlex to false. Defaults to: true
        /// </summary>
        [ConfigOption]
        [DefaultValue(true)]
        public virtual bool AutoFlex
        {
            get
            {
                return this.State.Get<bool>("AutoFlex", true);
            }
            set
            {
                this.State.Set("AutoFlex", value);
            }
        }
    }
}