/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class MenuItemListeners
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
                list.Add("activate", new ConfigOption("activate", new SerializationOptions("activate", typeof(ListenerJsonConverter)), null, this.Activate ));
                list.Add("deactivate", new ConfigOption("deactivate", new SerializationOptions("deactivate", typeof(ListenerJsonConverter)), null, this.Deactivate ));
                list.Add("textChange", new ConfigOption("textChange", new SerializationOptions("textchange", typeof(ListenerJsonConverter)), null, this.TextChange ));
                list.Add("iconChange", new ConfigOption("iconChange", new SerializationOptions("iconchange", typeof(ListenerJsonConverter)), null, this.IconChange ));

                return list;
            }
        }
    }
}