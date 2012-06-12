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
    public abstract partial class ImageBase
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
                
                list.Add("height", new ConfigOption("height", null, Unit.Empty, this.Height ));
                list.Add("width", new ConfigOption("width", null, Unit.Empty, this.Width ));
                list.Add("imageUrl", new ConfigOption("imageUrl", new SerializationOptions(JsonMode.Ignore), "", this.ImageUrl ));
                list.Add("imageUrlProxy", new ConfigOption("imageUrlProxy", new SerializationOptions("imageUrl"), "", this.ImageUrlProxy ));
                list.Add("alternateText", new ConfigOption("alternateText", new SerializationOptions("altText"), "", this.AlternateText ));
                list.Add("align", new ConfigOption("align", new SerializationOptions(JsonMode.ToLower), ImageAlign.NotSet, this.Align ));
                list.Add("lazyLoad", new ConfigOption("lazyLoad", null, false, this.LazyLoad ));
                list.Add("monitorComplete", new ConfigOption("monitorComplete", null, true, this.MonitorComplete ));
                list.Add("allowPan", new ConfigOption("allowPan", null, false, this.AllowPan ));
                list.Add("resizable", new ConfigOption("resizable", null, false, this.Resizable ));
                list.Add("monitorPoll", new ConfigOption("monitorPoll", null, 200, this.MonitorPoll ));
                list.Add("resizeConfigProxy", new ConfigOption("resizeConfigProxy", new SerializationOptions("resizeConfig", JsonMode.Raw), "", this.ResizeConfigProxy ));
                list.Add("xDelta", new ConfigOption("xDelta", null, 0, this.XDelta ));
                list.Add("yDelta", new ConfigOption("yDelta", null, 0, this.YDelta ));
                list.Add("loadMask", new ConfigOption("loadMask", new SerializationOptions("loadMask", typeof(LoadMaskJsonConverter)), null, this.LoadMask ));

                return list;
            }
        }
    }
}