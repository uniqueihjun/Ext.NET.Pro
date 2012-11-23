/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class LayerConfig
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
                
                list.Add("cls", new ConfigOption("cls", null, "", this.Cls ));
                list.Add("iD", new ConfigOption("iD", new SerializationOptions("id"), "", this.ID ));
                list.Add("constrain", new ConfigOption("constrain", null, true, this.Constrain ));
                list.Add("dH", new ConfigOption("dH", new SerializationOptions("dh", JsonMode.Object), null, this.DH ));
                list.Add("shadow", new ConfigOption("shadow", new SerializationOptions(typeof(ShadowJsonConverter)), ShadowMode.None, this.Shadow ));
                list.Add("shadowOffset", new ConfigOption("shadowOffset", null, 4, this.ShadowOffset ));
                list.Add("shim", new ConfigOption("shim", null, true, this.Shim ));
                list.Add("useDisplay", new ConfigOption("useDisplay", null, false, this.UseDisplay ));
                list.Add("zIndex", new ConfigOption("zIndex", new SerializationOptions("zindex"), 11000, this.ZIndex ));
                list.Add("parentElementProxy", new ConfigOption("parentElementProxy", new SerializationOptions("parentEl", JsonMode.Raw), "", this.ParentElementProxy ));

                return list;
            }
        }
    }
}