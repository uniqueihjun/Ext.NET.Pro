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
    public partial class ComponentColumnListeners
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
                
                list.Add("pin", new ConfigOption("pin", new SerializationOptions("pin", typeof(ListenerJsonConverter)), null, this.Pin ));
                list.Add("unpin", new ConfigOption("unpin", new SerializationOptions("unpin", typeof(ListenerJsonConverter)), null, this.Unpin ));
                list.Add("bind", new ConfigOption("bind", new SerializationOptions("bind", typeof(ListenerJsonConverter)), null, this.Bind ));
                list.Add("unbind", new ConfigOption("unbind", new SerializationOptions("unbind", typeof(ListenerJsonConverter)), null, this.Unbind ));

                return list;
            }
        }
    }
}