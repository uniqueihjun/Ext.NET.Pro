/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class TabCloseMenu
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
                
                list.Add("closeTabText", new ConfigOption("closeTabText", null, "Close Tab", this.CloseTabText ));
                list.Add("showCloseOthers", new ConfigOption("showCloseOthers", null, true, this.ShowCloseOthers ));
                list.Add("closeOtherTabsText", new ConfigOption("closeOtherTabsText", null, "Close Other Tabs", this.CloseOtherTabsText ));
                list.Add("showCloseAll", new ConfigOption("showCloseAll", null, true, this.ShowCloseAll ));
                list.Add("closeAllTabsText", new ConfigOption("closeAllTabsText", null, "Close All Tabs", this.CloseAllTabsText ));
                list.Add("closeTabIconClsProxy", new ConfigOption("closeTabIconClsProxy", new SerializationOptions("closeTabIconCls"), "", this.CloseTabIconClsProxy ));
                list.Add("closeOtherTabsIconClsProxy", new ConfigOption("closeOtherTabsIconClsProxy", new SerializationOptions("closeOtherTabsIconCls"), "", this.CloseOtherTabsIconClsProxy ));
                list.Add("closeAllTabsIconClsProxy", new ConfigOption("closeAllTabsIconClsProxy", new SerializationOptions("closeAllTabsIconCls"), "", this.CloseAllTabsIconClsProxy ));
                list.Add("extraItemsHead", new ConfigOption("extraItemsHead", new SerializationOptions("extraItemsHead", typeof(ItemCollectionJsonConverter)), null, this.ExtraItemsHead ));
                list.Add("extraItemsTail", new ConfigOption("extraItemsTail", new SerializationOptions("extraItemsTail", typeof(ItemCollectionJsonConverter)), null, this.ExtraItemsTail ));

                return list;
            }
        }
    }
}