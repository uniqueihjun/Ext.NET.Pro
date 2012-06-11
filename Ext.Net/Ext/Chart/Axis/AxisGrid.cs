/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// The grid configuration enables you to set a background grid for an axis. If set to true on a vertical axis, vertical lines will be drawn. If set to true on a horizontal axis, horizontal lines will be drawn. If both are set, a proper grid with horizontal and vertical lines will be drawn.
    /// You can set specific options for the grid configuration for odd and/or even lines/rows. Since the rows being drawn are rectangle sprites, you can set to an odd or even property all styles that apply to Ext.draw.Sprite. For more information on all the style properties you can set please take a look at Ext.draw.Sprite. Some useful style properties are opacity, fill, stroke, stroke-width, etc.
    /// The possible values for a grid option are then true, false, or an object with { odd, even } properties where each property contains a sprite style descriptor object that is defined in Ext.draw.Sprite.
    /// </summary>
    [Meta]
    public partial class AxisGrid : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        public AxisGrid()
        {
        }

        private SpriteAttributes odd;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Object)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public SpriteAttributes Odd
        {
            get
            {
                return this.odd;
            }
            set
            {
                this.odd = value;
            }
        }

        private SpriteAttributes even;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Object)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public SpriteAttributes Even 
        {
            get
            {
                return this.even;
            }
            set
            {
                this.even = value;
            }
        }
    }
}
