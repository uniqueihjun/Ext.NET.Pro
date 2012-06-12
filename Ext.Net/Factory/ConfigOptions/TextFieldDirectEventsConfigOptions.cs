/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class TextFieldDirectEvents
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
                
                list.Add("autoSize", new ConfigOption("autoSize", new SerializationOptions("autosize", typeof(DirectEventJsonConverter)), null, this.AutoSize ));
                list.Add("keyDown", new ConfigOption("keyDown", new SerializationOptions("keydown", typeof(DirectEventJsonConverter)), null, this.KeyDown ));
                list.Add("keyPress", new ConfigOption("keyPress", new SerializationOptions("keypress", typeof(DirectEventJsonConverter)), null, this.KeyPress ));
                list.Add("keyUp", new ConfigOption("keyUp", new SerializationOptions("keyup", typeof(DirectEventJsonConverter)), null, this.KeyUp ));
                list.Add("iconClick", new ConfigOption("iconClick", new SerializationOptions("iconclick", typeof(DirectEventJsonConverter)), null, this.IconClick ));

                return list;
            }
        }
    }
}