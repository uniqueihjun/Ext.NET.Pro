/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class BoxReordererDirectEvents
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
                
                list.Add("startDrag", new ConfigOption("startDrag", new SerializationOptions("StartDrag", typeof(DirectEventJsonConverter)), null, this.StartDrag ));
                list.Add("drag", new ConfigOption("drag", new SerializationOptions("Drag", typeof(DirectEventJsonConverter)), null, this.Drag ));
                list.Add("changeIndex", new ConfigOption("changeIndex", new SerializationOptions("ChangeIndex", typeof(DirectEventJsonConverter)), null, this.ChangeIndex ));
                list.Add("drop", new ConfigOption("drop", new SerializationOptions("Drop", typeof(DirectEventJsonConverter)), null, this.Drop ));

                return list;
            }
        }
    }
}