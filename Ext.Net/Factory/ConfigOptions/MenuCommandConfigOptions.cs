/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class MenuCommand
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
                
                list.Add("commandName", new ConfigOption("commandName", new SerializationOptions("command"), "", this.CommandName ));
                list.Add("iconCls", new ConfigOption("iconCls", null, "", this.IconCls ));
                list.Add("text", new ConfigOption("text", null, "", this.Text ));
                list.Add("cls", new ConfigOption("cls", null, "", this.Cls ));
                list.Add("ctCls", new ConfigOption("ctCls", null, "", this.CtCls ));
                list.Add("disabled", new ConfigOption("disabled", null, false, this.Disabled ));
                list.Add("disabledClass", new ConfigOption("disabledClass", null, "", this.DisabledClass ));
                list.Add("hidden", new ConfigOption("hidden", null, false, this.Hidden ));
                list.Add("overCls", new ConfigOption("overCls", null, "", this.OverCls ));
                list.Add("itemCls", new ConfigOption("itemCls", null, "", this.ItemCls ));
                list.Add("menu", new ConfigOption("menu", new SerializationOptions("menu", JsonMode.Object), null, this.Menu ));
                list.Add("handler", new ConfigOption("handler", new SerializationOptions(JsonMode.Raw), "", this.Handler ));
                list.Add("hideOnClick", new ConfigOption("hideOnClick", null, true, this.HideOnClick ));

                return list;
            }
        }
    }
}