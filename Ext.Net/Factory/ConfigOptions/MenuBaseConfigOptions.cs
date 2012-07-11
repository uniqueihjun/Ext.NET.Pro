/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public abstract partial class MenuBase
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
                
                list.Add("defaultTypeProxy", new ConfigOption("defaultTypeProxy", new SerializationOptions("defaultType"), "menuitem", this.DefaultTypeProxy ));
                list.Add("enableScrolling", new ConfigOption("enableScrolling", null, false, this.EnableScrolling ));
                list.Add("floating", new ConfigOption("floating", null, true, this.Floating ));
                list.Add("allowOtherMenus", new ConfigOption("allowOtherMenus", null, false, this.AllowOtherMenus ));
                list.Add("offsetX", new ConfigOption("offsetX", null, 0, this.OffsetX ));
                list.Add("offsetY", new ConfigOption("offsetY", null, 0, this.OffsetY ));
                list.Add("defaultOffsets", new ConfigOption("defaultOffsets", new SerializationOptions(JsonMode.Raw), "", this.DefaultOffsets ));
                list.Add("ignoreParentClicks", new ConfigOption("ignoreParentClicks", null, false, this.IgnoreParentClicks ));
                list.Add("minWidth", new ConfigOption("minWidth", null, Unit.Pixel(120), this.MinWidth ));
                list.Add("maxHeight", new ConfigOption("maxHeight", null, Unit.Empty, this.MaxHeight ));
                list.Add("scrollIncrement", new ConfigOption("scrollIncrement", new SerializationOptions(JsonMode.Raw), 24, this.ScrollIncrement ));
                list.Add("showSeparator", new ConfigOption("showSeparator", null, true, this.ShowSeparator ));
                list.Add("shadow", new ConfigOption("shadow", new SerializationOptions(typeof(ShadowJsonConverter)), ShadowMode.Sides, this.Shadow ));
                list.Add("subMenuAlign", new ConfigOption("subMenuAlign", null, "", this.SubMenuAlign ));
                list.Add("renderToForm", new ConfigOption("renderToForm", null, false, this.RenderToForm ));
                list.Add("disableMenuNavigationProxy", new ConfigOption("disableMenuNavigationProxy", new SerializationOptions("keyNav", JsonMode.Raw), "", this.DisableMenuNavigationProxy ));

                return list;
            }
        }
    }
}