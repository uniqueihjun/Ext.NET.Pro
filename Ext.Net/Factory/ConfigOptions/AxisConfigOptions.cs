/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class Axis
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("adjustEnd", new ConfigOption("adjustEnd", null, true, this.AdjustEnd ));
                list.Add("dashSize", new ConfigOption("dashSize", null, 3, this.DashSize ));
                list.Add("grid", new ConfigOption("grid", null, false, this.Grid ));
                list.Add("gridConfig", new ConfigOption("gridConfig", new SerializationOptions("grid", JsonMode.Object), null, this.GridConfig ));
                list.Add("length", new ConfigOption("length", null, 0, this.Length ));
                list.Add("majorTickSteps", new ConfigOption("majorTickSteps", null, int.MinValue, this.MajorTickSteps ));
                list.Add("minorTickSteps", new ConfigOption("minorTickSteps", null, 0, this.MinorTickSteps ));
                list.Add("positionProxy", new ConfigOption("positionProxy", new SerializationOptions("position"), null, this.PositionProxy ));
                list.Add("title", new ConfigOption("title", null, "", this.Title ));
                list.Add("width", new ConfigOption("width", null, 0, this.Width ));
                list.Add("fields", new ConfigOption("fields", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.Fields ));

                return list;
            }
        }
    }
}