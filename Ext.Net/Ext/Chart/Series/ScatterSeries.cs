/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Creates a Scatter Chart. The scatter plot is useful when trying to display more than two variables in the same visualization. These variables can be mapped into x, y coordinates and also to an element's radius/size, color, etc. As with all other series, the Scatter Series must be appended in the series Chart array configuration.
    /// </summary>
    [Meta]
    public partial class ScatterSeries : CartesianSeries
    {
        /// <summary>
        /// 
        /// </summary>
        public ScatterSeries()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        protected virtual string Type
        {
            get
            {
                return "scatter";
            }
        }

        private SpriteAttributes markerConfig;

        /// <summary>
        /// The display style for the scatter series markers.
        /// </summary>
        [Meta]
        [ConfigOption("markerConfig", JsonMode.Object)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public SpriteAttributes MarkerConfig
        {
            get
            {
                return this.markerConfig;
            }
            set
            {
                this.markerConfig = value;
            }
        }

        private SpriteAttributes style;

        /// <summary>
        /// An object containing styles for overriding series styles from Theming.
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Object)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public SpriteAttributes Style
        {
            get
            {
                return this.style;
            }
            set
            {
                this.style = value;
            }
        }
    }
}
