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
    public abstract partial class ToolTipBase
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
                
                list.Add("renderToProxy", new ConfigOption("renderToProxy", new SerializationOptions("renderTo"), "", this.RenderToProxy ));
                list.Add("anchorOffset", new ConfigOption("anchorOffset", null, 0, this.AnchorOffset ));
                list.Add("anchorToTarget", new ConfigOption("anchorToTarget", null, true, this.AnchorToTarget ));
                list.Add("autoHide", new ConfigOption("autoHide", null, true, this.AutoHide ));
                list.Add("delegate", new ConfigOption("delegate", null, "", this.Delegate ));
                list.Add("dismissDelay", new ConfigOption("dismissDelay", null, 5000, this.DismissDelay ));
                list.Add("hideDelay", new ConfigOption("hideDelay", null, 200, this.HideDelay ));
                list.Add("mouseOffset", new ConfigOption("mouseOffset", new SerializationOptions(typeof(IntArrayJsonConverter)), null, this.MouseOffset ));
                list.Add("showDelay", new ConfigOption("showDelay", null, 500, this.ShowDelay ));
                list.Add("targetProxy", new ConfigOption("targetProxy", new SerializationOptions("target", JsonMode.Raw), "", this.TargetProxy ));
                list.Add("trackMouse", new ConfigOption("trackMouse", null, false, this.TrackMouse ));

                return list;
            }
        }
    }
}