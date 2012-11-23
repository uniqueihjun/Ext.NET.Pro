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
    public abstract partial class TabPanelBase
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
                
                list.Add("visibleIndex", new ConfigOption("visibleIndex", new SerializationOptions("activeTab"), -1, this.VisibleIndex ));
                list.Add("animScroll", new ConfigOption("animScroll", null, true, this.AnimScroll ));
                list.Add("autoTabSelector", new ConfigOption("autoTabSelector", null, "div.x-tab", this.AutoTabSelector ));
                list.Add("autoTabs", new ConfigOption("autoTabs", null, false, this.AutoTabs ));
                list.Add("baseCls", new ConfigOption("baseCls", null, "x-tab-panel", this.BaseCls ));
                list.Add("deferredRender", new ConfigOption("deferredRender", null, true, this.DeferredRender ));
                list.Add("enableTabScroll", new ConfigOption("enableTabScroll", null, false, this.EnableTabScroll ));
                list.Add("layoutOnTabChange", new ConfigOption("layoutOnTabChange", null, false, this.LayoutOnTabChange ));
                list.Add("minTabWidth", new ConfigOption("minTabWidth", null, Unit.Pixel(30), this.MinTabWidth ));
                list.Add("plain", new ConfigOption("plain", null, false, this.Plain ));
                list.Add("resizeTabs", new ConfigOption("resizeTabs", null, false, this.ResizeTabs ));
                list.Add("scrollDuration", new ConfigOption("scrollDuration", null, 0.35f, this.ScrollDuration ));
                list.Add("scrollIncrement", new ConfigOption("scrollIncrement", null, 100, this.ScrollIncrement ));
                list.Add("scrollRepeatInterval", new ConfigOption("scrollRepeatInterval", null, 400, this.ScrollRepeatInterval ));
                list.Add("tabMargin", new ConfigOption("tabMargin", null, Unit.Pixel(2), this.TabMargin ));
                list.Add("tabAlignProxy", new ConfigOption("tabAlignProxy", new SerializationOptions("tabAlign", JsonMode.ToLower), TabAlign.Left, this.TabAlignProxy ));
                list.Add("tabCls", new ConfigOption("tabCls", null, "", this.TabCls ));
                list.Add("tabPosition", new ConfigOption("tabPosition", new SerializationOptions(JsonMode.ToLower), TabPosition.Top, this.TabPosition ));
                list.Add("tabWidth", new ConfigOption("tabWidth", null, Unit.Pixel(120), this.TabWidth ));
                list.Add("wheelIncrement", new ConfigOption("wheelIncrement", null, 20, this.WheelIncrement ));
                list.Add("defaultTabMenu", new ConfigOption("defaultTabMenu", new SerializationOptions("defaultTabMenu", typeof(ItemCollectionJsonConverter)), null, this.DefaultTabMenu ));

                return list;
            }
        }
    }
}