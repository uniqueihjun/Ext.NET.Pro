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
    /// This is a base class for layouts that contain a single item that automatically expands to fill the layout's container. This class is intended to be extended or created via the layout:'fit' Ext.container.Container.layout config, and should generally not need to be created directly via the new keyword.
    /// Fit layout does not have any direct config options (other than inherited ones). To fit a panel to a container using Fit layout, simply set layout: 'fit' on the container and add a single panel to it.
    /// If the container has multiple items, all of the items will all be equally sized. This is usually not desired, so to avoid this, place only a single item in the container. This sizing of all items can be used to provide a background image that is "behind" another item such as a dataview if you also absolutely position the items.
	/// </summary>
	[Description("")]
    public partial class FitLayoutConfig : LayoutConfig
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
                return "fit";
            }
        }

        /// <summary>
        /// If the individual contained items do not have a margins property specified, the default margins from this property will be applied to each item.
        /// The order of the sides associated with each value matches the way CSS processes margin values:
        ///    If there is only one value, it applies to all sides.
        ///    If there are two values, the top and bottom borders are set to the first value and the right and left are set to the second.
        ///    If there are three values, the top is set to the first value, the left and right are set to the second, and the bottom is set to the third.
        ///    If there are four values, they apply to the top, right, bottom, and left, respectively.
        /// </summary>
        [DefaultValue("")]
        public string DefaultMargins
        {
            get
            {
                return this.State.Get<string>("DefaultMargins", "");
            }
            set
            {
                this.State.Set("DefaultMargins", value);
            }
        }

        [ConfigOption("defaultMargins", JsonMode.Raw)]
        [DefaultValue("")]
        protected string DefaultMarginsProxy
        {
            get
            {
                if (this.DefaultMargins.IsEmpty())
                {
                    return "";
                }

                return "Ext.util.Format.parseBox(" + JSON.Serialize(this.DefaultMargins) + ")";
            }
        }       
    }
}