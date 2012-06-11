/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class StartMenuConfig
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
                
                list.Add("iconClsProxy", new ConfigOption("iconClsProxy", new SerializationOptions("iconCls"), "", this.IconClsProxy ));
                list.Add("width", new ConfigOption("width", null, 300, this.Width ));
                list.Add("toolsWidth", new ConfigOption("toolsWidth", null, 100, this.ToolsWidth ));
                list.Add("height", new ConfigOption("height", null, 300, this.Height ));
                list.Add("title", new ConfigOption("title", null, "", this.Title ));
                list.Add("shadow", new ConfigOption("shadow", null, true, this.Shadow ));
                list.Add("toolItems", new ConfigOption("toolItems", new SerializationOptions("toolItems", typeof(ItemCollectionJsonConverter)), null, this.ToolItems ));
                list.Add("items", new ConfigOption("items", new SerializationOptions("items", typeof(ItemCollectionJsonConverter)), null, this.Items ));

                return list;
            }
        }
    }
}