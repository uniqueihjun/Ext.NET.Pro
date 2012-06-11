/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class PanelDirectEvents
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
                
                list.Add("activate", new ConfigOption("activate", new SerializationOptions("activate", typeof(DirectEventJsonConverter)), null, this.Activate ));
                list.Add("beforeClose", new ConfigOption("beforeClose", new SerializationOptions("beforeclose", typeof(DirectEventJsonConverter)), null, this.BeforeClose ));
                list.Add("beforeCollapse", new ConfigOption("beforeCollapse", new SerializationOptions("beforecollapse", typeof(DirectEventJsonConverter)), null, this.BeforeCollapse ));
                list.Add("beforeExpand", new ConfigOption("beforeExpand", new SerializationOptions("beforeexpand", typeof(DirectEventJsonConverter)), null, this.BeforeExpand ));
                list.Add("bodyResize", new ConfigOption("bodyResize", new SerializationOptions("bodyresize", typeof(DirectEventJsonConverter)), null, this.BodyResize ));
                list.Add("close", new ConfigOption("close", new SerializationOptions("close", typeof(DirectEventJsonConverter)), null, this.Close ));
                list.Add("collapse", new ConfigOption("collapse", new SerializationOptions("collapse", typeof(DirectEventJsonConverter)), null, this.Collapse ));
                list.Add("deactivate", new ConfigOption("deactivate", new SerializationOptions("deactivate", typeof(DirectEventJsonConverter)), null, this.Deactivate ));
                list.Add("expand", new ConfigOption("expand", new SerializationOptions("expand", typeof(DirectEventJsonConverter)), null, this.Expand ));
                list.Add("titleChange", new ConfigOption("titleChange", new SerializationOptions("titlechange", typeof(DirectEventJsonConverter)), null, this.TitleChange ));
                list.Add("beforeUpdate", new ConfigOption("beforeUpdate", new SerializationOptions("beforeupdate", typeof(DirectEventJsonConverter)), null, this.BeforeUpdate ));
                list.Add("update", new ConfigOption("update", new SerializationOptions("update", typeof(DirectEventJsonConverter)), null, this.Update ));
                list.Add("failure", new ConfigOption("failure", new SerializationOptions("failure", typeof(DirectEventJsonConverter)), null, this.Failure ));
                list.Add("iconChange", new ConfigOption("iconChange", new SerializationOptions("iconchange", typeof(DirectEventJsonConverter)), null, this.IconChange ));

                return list;
            }
        }
    }
}