/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class ClickRepeaterDirectEvents
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
                list.Add("leftClick", new ConfigOption("leftClick", new SerializationOptions("leftclick", typeof(DirectEventJsonConverter)), null, this.LeftClick ));
                list.Add("middleClick", new ConfigOption("middleClick", new SerializationOptions("middleclick", typeof(DirectEventJsonConverter)), null, this.MiddleClick ));
                list.Add("rightClick", new ConfigOption("rightClick", new SerializationOptions("rightclick", typeof(DirectEventJsonConverter)), null, this.RightClick ));
                list.Add("mouseDown", new ConfigOption("mouseDown", new SerializationOptions("mousedown", typeof(DirectEventJsonConverter)), null, this.MouseDown ));
                list.Add("mouseUp", new ConfigOption("mouseUp", new SerializationOptions("mouseup", typeof(DirectEventJsonConverter)), null, this.MouseUp ));

                return list;
            }
        }
    }
}