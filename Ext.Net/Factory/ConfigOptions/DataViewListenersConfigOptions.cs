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
    public partial class DataViewListeners
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
                
                list.Add("beforeClick", new ConfigOption("beforeClick", new SerializationOptions("beforeclick", typeof(ListenerJsonConverter)), null, this.BeforeClick ));
                list.Add("beforeSelect", new ConfigOption("beforeSelect", new SerializationOptions("beforeselect", typeof(ListenerJsonConverter)), null, this.BeforeSelect ));
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(ListenerJsonConverter)), null, this.Click ));
                list.Add("containerClick", new ConfigOption("containerClick", new SerializationOptions("containerclick", typeof(ListenerJsonConverter)), null, this.ContainerClick ));
                list.Add("contextMenu", new ConfigOption("contextMenu", new SerializationOptions("contextmenu", typeof(ListenerJsonConverter)), null, this.ContextMenu ));
                list.Add("containerContextMenu", new ConfigOption("containerContextMenu", new SerializationOptions("containercontextmenu", typeof(ListenerJsonConverter)), null, this.ContainerContextMenu ));
                list.Add("dblClick", new ConfigOption("dblClick", new SerializationOptions("dblclick", typeof(ListenerJsonConverter)), null, this.DblClick ));
                list.Add("mouseEnter", new ConfigOption("mouseEnter", new SerializationOptions("mouseenter", typeof(ListenerJsonConverter)), null, this.MouseEnter ));
                list.Add("mouseLeave", new ConfigOption("mouseLeave", new SerializationOptions("mouseleave", typeof(ListenerJsonConverter)), null, this.MouseLeave ));
                list.Add("selectionChange", new ConfigOption("selectionChange", new SerializationOptions("selectionchange", typeof(ListenerJsonConverter)), null, this.SelectionChange ));

                return list;
            }
        }
    }
}