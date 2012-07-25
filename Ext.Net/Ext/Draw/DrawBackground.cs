/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    [Meta]
    public partial class DrawBackground : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        public DrawBackground()
        {
        }

        /// <summary>
        /// The fill color
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [Description("The fill color")]
        public virtual string Fill
        {
            get
            {
                return this.State.Get<string>("Fill", "");
            }
            set
            {
                this.State.Set("Fill", value);
            }
        }

        /// <summary>
        /// The background image
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [Description("The background image")]
        public virtual string Image
        {
            get
            {
                return this.State.Get<string>("Image", "");
            }
            set
            {
                this.State.Set("Image", value);
            }
        }

        private Gradient gradient;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Object)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public Gradient Gradient
        {
            get
            {
                return this.gradient;
            }
            set
            {
                this.gradient = value;
            }
        }
    }
}
