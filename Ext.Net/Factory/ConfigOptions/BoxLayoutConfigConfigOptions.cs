/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public abstract partial class BoxLayoutConfig
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
                
                list.Add("animateProxy", new ConfigOption("animateProxy", new SerializationOptions("animate", JsonMode.Raw), "", this.AnimateProxy ));
                list.Add("defaultMarginsProxy", new ConfigOption("defaultMarginsProxy", new SerializationOptions("defaultMargins", JsonMode.Raw), "", this.DefaultMarginsProxy ));
                list.Add("padding", new ConfigOption("padding", new SerializationOptions("padding"), "0", this.Padding ));
                list.Add("pack", new ConfigOption("pack", new SerializationOptions(JsonMode.ToLower), BoxPack.Start, this.Pack ));
                list.Add("stretchMaxPartner", new ConfigOption("stretchMaxPartner", null, "", this.StretchMaxPartner ));
                list.Add("clearInnerCtOnLayout", new ConfigOption("clearInnerCtOnLayout", null, false, this.ClearInnerCtOnLayout ));
                list.Add("shrinkToFit", new ConfigOption("shrinkToFit", null, true, this.ShrinkToFit ));

                return list;
            }
        }
    }
}