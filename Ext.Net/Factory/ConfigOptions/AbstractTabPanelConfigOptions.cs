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
    public abstract partial class AbstractTabPanel
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
                list.Add("deferredRender", new ConfigOption("deferredRender", null, true, this.DeferredRender ));
                list.Add("minTabWidth", new ConfigOption("minTabWidth", null, 0, this.MinTabWidth ));
                list.Add("maxTabWidth", new ConfigOption("maxTabWidth", null, int.MaxValue, this.MaxTabWidth ));
                list.Add("plain", new ConfigOption("plain", null, false, this.Plain ));
                list.Add("tabAlign", new ConfigOption("tabAlign", new SerializationOptions("tabAlign", JsonMode.ToLower), TabAlign.Left, this.TabAlign ));
                list.Add("tabBar", new ConfigOption("tabBar", new SerializationOptions("tabBarItems", typeof(ItemCollectionJsonConverter)), null, this.TabBar ));
                list.Add("itemCls", new ConfigOption("itemCls", null, "", this.ItemCls ));
                list.Add("removePanelHeader", new ConfigOption("removePanelHeader", null, true, this.RemovePanelHeader ));
                list.Add("tabPosition", new ConfigOption("tabPosition", new SerializationOptions(JsonMode.ToLower), TabPosition.Top, this.TabPosition ));
                list.Add("defaultTabMenu", new ConfigOption("defaultTabMenu", new SerializationOptions("defaultTabMenu", typeof(SingleItemCollectionJsonConverter)), null, this.DefaultTabMenu ));

                return list;
            }
        }
    }
}