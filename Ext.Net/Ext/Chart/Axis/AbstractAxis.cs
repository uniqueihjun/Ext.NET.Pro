/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Base class for all axis classes.
    /// </summary>
    [Meta]
    public abstract partial class AbstractAxis : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [Description("")]
        public virtual string AxisID
        {
            get
            {
                return this.State.Get<string>("AxisID", "");
            }
            set
            {
                this.State.Set("AxisID", value);
            }
        }

        private SpriteAttributes labelTitle;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Object)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public SpriteAttributes LabelTitle
        {
            get
            {
                return this.labelTitle;
            }
            set
            {
                this.labelTitle = value;
            }
        }

        private AxisLabel label;

        /// <summary>
        /// The config for chart label.
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Object)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public AxisLabel Label
        {
            get
            {
                return this.label;
            }
            set
            {
                this.label = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool Hidden
        {
            get
            {
                return this.State.Get<bool>("Hidden", false);
            }
            set
            {
                this.State.Set("Hidden", value);
            }
        }

        public virtual Chart Chart
        {
            get
            {
                var chart = this.Owner as Chart;
                if (chart == null && !this.DesignMode)
                {
                    throw new Exception("Axis has no a chart reference");
                }

                return chart;
            }
        }
    }

    public class AxisCollection : BaseItemCollection<AbstractAxis>
    {
    }
}
