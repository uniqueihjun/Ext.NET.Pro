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
    public abstract partial class MenuItemBase
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
                
                list.Add("activeCls", new ConfigOption("activeCls", null, "", this.ActiveCls ));
                list.Add("canActivate", new ConfigOption("canActivate", null, true, this.CanActivate ));
                list.Add("clickHideDelay", new ConfigOption("clickHideDelay", null, 1, this.ClickHideDelay ));
                list.Add("handler", new ConfigOption("handler", new SerializationOptions(typeof(FunctionJsonConverter)), "", this.Handler ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "", this.Scope ));
                list.Add("destroyMenu", new ConfigOption("destroyMenu", null, true, this.DestroyMenu ));
                list.Add("hideOnClick", new ConfigOption("hideOnClick", null, true, this.HideOnClick ));
                list.Add("href", new ConfigOption("href", null, "#", this.Href ));
                list.Add("hrefTarget", new ConfigOption("hrefTarget", null, "", this.HrefTarget ));
                list.Add("iconUrl", new ConfigOption("iconUrl", new SerializationOptions("icon", JsonMode.Url), "", this.IconUrl ));
                list.Add("iconClsProxy", new ConfigOption("iconClsProxy", new SerializationOptions("iconCls"), "", this.IconClsProxy ));
                list.Add("menuAlign", new ConfigOption("menuAlign", null, "", this.MenuAlign ));
                list.Add("menuExpandDelay", new ConfigOption("menuExpandDelay", null, 200, this.MenuExpandDelay ));
                list.Add("menuHideDelay", new ConfigOption("menuHideDelay", null, 200, this.MenuHideDelay ));
                list.Add("plain", new ConfigOption("plain", null, false, this.Plain ));
                list.Add("text", new ConfigOption("text", null, "", this.Text ));
                list.Add("menu", new ConfigOption("menu", new SerializationOptions("menu", typeof(SingleItemCollectionJsonConverter)), null, this.Menu ));
                list.Add("toolTip", new ConfigOption("toolTip", new SerializationOptions("tooltip"), "", this.ToolTip ));
                list.Add("qTipCfg", new ConfigOption("qTipCfg", new SerializationOptions("tooltip", JsonMode.Object), null, this.QTipCfg ));
                list.Add("toolTipType", new ConfigOption("toolTipType", new SerializationOptions("tooltipType"), ToolTipType.Qtip, this.ToolTipType ));

                return list;
            }
        }
    }
}