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
    public partial class GridCommand
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
                
                list.Add("xType", new ConfigOption("xType", new SerializationOptions("xtype"), "", this.XType ));
                list.Add("commandName", new ConfigOption("commandName", new SerializationOptions("command"), "", this.CommandName ));
                list.Add("toolTip", new ConfigOption("toolTip", new SerializationOptions("tooltip", JsonMode.Object), null, this.ToolTip ));
                list.Add("iconCls", new ConfigOption("iconCls", null, "", this.IconCls ));
                list.Add("text", new ConfigOption("text", null, "", this.Text ));
                list.Add("standOut", new ConfigOption("standOut", null, false, this.StandOut ));
                list.Add("cls", new ConfigOption("cls", null, "", this.Cls ));
                list.Add("ctCls", new ConfigOption("ctCls", null, "", this.CtCls ));
                list.Add("disabled", new ConfigOption("disabled", null, false, this.Disabled ));
                list.Add("disabledClass", new ConfigOption("disabledClass", null, "", this.DisabledClass ));
                list.Add("hidden", new ConfigOption("hidden", null, false, this.Hidden ));
                list.Add("overCls", new ConfigOption("overCls", null, "", this.OverCls ));
                list.Add("menu", new ConfigOption("menu", new SerializationOptions("menu", JsonMode.Object), null, this.Menu ));
                list.Add("hideMode", new ConfigOption("hideMode", new SerializationOptions(JsonMode.ToLower), HideMode.Display, this.HideMode ));
                list.Add("minWidth", new ConfigOption("minWidth", null, Unit.Pixel(16), this.MinWidth ));

                return list;
            }
        }
    }
}