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
    public abstract partial class Layout
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
                
                list.Add("layoutTypeProxy", new ConfigOption("layoutTypeProxy", new SerializationOptions("layout"), "container", this.LayoutTypeProxy ));
                list.Add("configIDProxy", new ConfigOption("configIDProxy", new SerializationOptions(JsonMode.Ignore), null, this.ConfigIDProxy ));
                list.Add("renderToProxy", new ConfigOption("renderToProxy", new SerializationOptions(JsonMode.Ignore), null, this.RenderToProxy ));
                list.Add("extraCls", new ConfigOption("extraCls", new SerializationOptions(JsonMode.Ignore), "", this.ExtraCls ));
                list.Add("renderHidden", new ConfigOption("renderHidden", new SerializationOptions(JsonMode.Ignore), false, this.RenderHidden ));

                return list;
            }
        }
    }
}