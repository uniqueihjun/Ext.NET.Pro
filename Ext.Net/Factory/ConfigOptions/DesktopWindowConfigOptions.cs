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
    public partial class DesktopWindow
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
                
                list.Add("maximizable", new ConfigOption("maximizable", new SerializationOptions(JsonMode.Ignore), true, this.Maximizable ));
                list.Add("lazyRender", new ConfigOption("lazyRender", null, true, this.LazyRender ));
                list.Add("showInTaskbar", new ConfigOption("showInTaskbar", null, true, this.ShowInTaskbar ));
                list.Add("minimizable", new ConfigOption("minimizable", new SerializationOptions(JsonMode.Ignore), true, this.Minimizable ));
                list.Add("renderToProxy", new ConfigOption("renderToProxy", new SerializationOptions(JsonMode.Ignore), null, this.RenderToProxy ));
                list.Add("manager", new ConfigOption("manager", new SerializationOptions(JsonMode.Raw), "", this.Manager ));
                list.Add("desktopReference", new ConfigOption("desktopReference", new SerializationOptions("desktop", JsonMode.Raw), "", this.DesktopReference ));

                return list;
            }
        }
    }
}