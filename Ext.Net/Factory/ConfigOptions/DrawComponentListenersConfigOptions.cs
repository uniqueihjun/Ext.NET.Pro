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
    public partial class DrawComponentListeners
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
                
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(ListenerJsonConverter)), null, this.Click ));
                list.Add("dblClick", new ConfigOption("dblClick", new SerializationOptions("dblclick", typeof(ListenerJsonConverter)), null, this.DblClick ));
                list.Add("mouseUp", new ConfigOption("mouseUp", new SerializationOptions("mouseup", typeof(ListenerJsonConverter)), null, this.MouseUp ));
                list.Add("mouseDown", new ConfigOption("mouseDown", new SerializationOptions("mousedown", typeof(ListenerJsonConverter)), null, this.MouseDown ));
                list.Add("mouseEnter", new ConfigOption("mouseEnter", new SerializationOptions("mouseenter", typeof(ListenerJsonConverter)), null, this.MouseEnter ));
                list.Add("mouseLeave", new ConfigOption("mouseLeave", new SerializationOptions("mouseleave", typeof(ListenerJsonConverter)), null, this.MouseLeave ));
                list.Add("mouseMove", new ConfigOption("mouseMove", new SerializationOptions("mousemove", typeof(ListenerJsonConverter)), null, this.MouseMove ));

                return list;
            }
        }
    }
}