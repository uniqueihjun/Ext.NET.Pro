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
    public partial class PanelListeners
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
                
                list.Add("beforeClose", new ConfigOption("beforeClose", new SerializationOptions("beforeclose", typeof(ListenerJsonConverter)), null, this.BeforeClose ));
                list.Add("beforeCollapse", new ConfigOption("beforeCollapse", new SerializationOptions("beforecollapse", typeof(ListenerJsonConverter)), null, this.BeforeCollapse ));
                list.Add("beforeExpand", new ConfigOption("beforeExpand", new SerializationOptions("beforeexpand", typeof(ListenerJsonConverter)), null, this.BeforeExpand ));
                list.Add("bodyResize", new ConfigOption("bodyResize", new SerializationOptions("bodyresize", typeof(ListenerJsonConverter)), null, this.BodyResize ));
                list.Add("close", new ConfigOption("close", new SerializationOptions("close", typeof(ListenerJsonConverter)), null, this.Close ));
                list.Add("collapse", new ConfigOption("collapse", new SerializationOptions("collapse", typeof(ListenerJsonConverter)), null, this.Collapse ));
                list.Add("expand", new ConfigOption("expand", new SerializationOptions("expand", typeof(ListenerJsonConverter)), null, this.Expand ));
                list.Add("titleChange", new ConfigOption("titleChange", new SerializationOptions("titlechange", typeof(ListenerJsonConverter)), null, this.TitleChange ));
                list.Add("iconClsChange", new ConfigOption("iconClsChange", new SerializationOptions("iconclschange", typeof(ListenerJsonConverter)), null, this.IconClsChange ));
                list.Add("iconChange", new ConfigOption("iconChange", new SerializationOptions("iconchange", typeof(ListenerJsonConverter)), null, this.IconChange ));

                return list;
            }
        }
    }
}