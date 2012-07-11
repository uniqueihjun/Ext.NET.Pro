/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class DrawComponentDirectEvents
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
                
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(DirectEventJsonConverter)), null, this.Click ));
                list.Add("dblClick", new ConfigOption("dblClick", new SerializationOptions("dblclick", typeof(DirectEventJsonConverter)), null, this.DblClick ));
                list.Add("mouseUp", new ConfigOption("mouseUp", new SerializationOptions("mouseup", typeof(DirectEventJsonConverter)), null, this.MouseUp ));
                list.Add("mouseDown", new ConfigOption("mouseDown", new SerializationOptions("mousedown", typeof(DirectEventJsonConverter)), null, this.MouseDown ));
                list.Add("mouseEnter", new ConfigOption("mouseEnter", new SerializationOptions("mouseenter", typeof(DirectEventJsonConverter)), null, this.MouseEnter ));
                list.Add("mouseLeave", new ConfigOption("mouseLeave", new SerializationOptions("mouseleave", typeof(DirectEventJsonConverter)), null, this.MouseLeave ));
                list.Add("mouseMove", new ConfigOption("mouseMove", new SerializationOptions("mousemove", typeof(DirectEventJsonConverter)), null, this.MouseMove ));

                return list;
            }
        }
    }
}