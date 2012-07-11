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

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public partial class Gradient : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        public Gradient()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        protected internal override void BeforeSerialization()
        {
            base.BeforeSerialization();

            if (this.GradientID.IsEmpty())
            {
                throw new Exception("Please define GradientID");
            }
        }

        /// <summary>
        /// The unique name of the gradient.
        /// </summary>
        [Meta]
        [ConfigOption("id")]
        [DefaultValue("")]
        [Description("The unique name of the gradient.")]
        public virtual string GradientID
        {
            get
            {
                return this.State.Get<string>("GradientID", "");
            }
            set
            {
                this.State.Set("GradientID", value);
            }
        }

        /// <summary>
        /// The angle of the gradient in degrees.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(0)]
        [Description("The angle of the gradient in degrees.")]
        public virtual int Angle
        {
            get
            {
                return this.State.Get<int>("Angle", 0);
            }
            set
            {
                this.State.Set("Angle", value);
            }
        }

        private GradientStops stops;

        /// <summary>
        /// An object with numbers as keys (from 0 to 100) and style objects as values
        /// </summary>
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An object with numbers as keys (from 0 to 100) and style objects as values")]
        public virtual GradientStops Stops
        {
            get
            {
                if (this.stops == null)
                {
                    this.stops = new GradientStops();                    
                }

                return this.stops;
            }
        }

        [ConfigOption("stops", JsonMode.Raw)]
        [DefaultValue("")]
        protected virtual string StopsProxy
        {
            get
            {
                return this.Stops.Serialize();
            }
        }
    }

    public partial class Gradients : BaseItemCollection<Gradient>
    { 
    }
}
