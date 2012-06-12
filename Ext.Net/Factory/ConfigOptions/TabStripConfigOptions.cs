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
    public partial class TabStrip
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
                
                list.Add("items", new ConfigOption("items", new SerializationOptions(JsonMode.AlwaysArray), null, this.Items ));
                list.Add("actionContainerProxy", new ConfigOption("actionContainerProxy", new SerializationOptions("actionContainer"), "", this.ActionContainerProxy ));
                list.Add("activeTabIndex", new ConfigOption("activeTabIndex", new SerializationOptions("activeTab"), -1, this.ActiveTabIndex ));
                list.Add("animScroll", new ConfigOption("animScroll", null, true, this.AnimScroll ));
                list.Add("enableTabScroll", new ConfigOption("enableTabScroll", null, false, this.EnableTabScroll ));
                list.Add("minTabWidth", new ConfigOption("minTabWidth", null, Unit.Pixel(30), this.MinTabWidth ));
                list.Add("plain", new ConfigOption("plain", null, true, this.Plain ));
                list.Add("resizeTabs", new ConfigOption("resizeTabs", null, false, this.ResizeTabs ));
                list.Add("syncOnTabChange", new ConfigOption("syncOnTabChange", null, false, this.SyncOnTabChange ));
                list.Add("autoGrow", new ConfigOption("autoGrow", null, true, this.AutoGrow ));
                list.Add("scrollDuration", new ConfigOption("scrollDuration", null, 0.35f, this.ScrollDuration ));
                list.Add("scrollIncrement", new ConfigOption("scrollIncrement", null, 100, this.ScrollIncrement ));
                list.Add("scrollRepeatInterval", new ConfigOption("scrollRepeatInterval", null, 400, this.ScrollRepeatInterval ));
                list.Add("tabMargin", new ConfigOption("tabMargin", null, Unit.Pixel(2), this.TabMargin ));
                list.Add("tabCls", new ConfigOption("tabCls", null, "", this.TabCls ));
                list.Add("tabPosition", new ConfigOption("tabPosition", new SerializationOptions(JsonMode.ToLower), TabPosition.Top, this.TabPosition ));
                list.Add("tabWidth", new ConfigOption("tabWidth", null, Unit.Pixel(120), this.TabWidth ));
                list.Add("wheelIncrement", new ConfigOption("wheelIncrement", null, 20, this.WheelIncrement ));
                list.Add("defaultTypeProxy", new ConfigOption("defaultTypeProxy", new SerializationOptions("defaultType"), "box", this.DefaultTypeProxy ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}