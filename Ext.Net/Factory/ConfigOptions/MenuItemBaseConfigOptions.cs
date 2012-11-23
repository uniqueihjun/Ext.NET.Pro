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
                
                list.Add("canActivate", new ConfigOption("canActivate", null, true, this.CanActivate ));
                list.Add("href", new ConfigOption("href", null, "", this.Href ));
                list.Add("hrefTarget", new ConfigOption("hrefTarget", null, "", this.HrefTarget ));
                list.Add("iconUrlProxy", new ConfigOption("iconUrlProxy", new SerializationOptions("icon"), "", this.IconUrlProxy ));
                list.Add("iconCls", new ConfigOption("iconCls", null, "", this.IconCls ));
                list.Add("itemCls", new ConfigOption("itemCls", null, "", this.ItemCls ));
                list.Add("showDelay", new ConfigOption("showDelay", new SerializationOptions(JsonMode.Raw), 200, this.ShowDelay ));
                list.Add("text", new ConfigOption("text", null, "", this.Text ));
                list.Add("menu", new ConfigOption("menu", new SerializationOptions("menu", typeof(ItemCollectionJsonConverter)), null, this.Menu ));

                return list;
            }
        }
    }
}