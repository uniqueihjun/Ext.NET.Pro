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
    public partial class DataViewDirectEvents
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
                
                list.Add("beforeClick", new ConfigOption("beforeClick", new SerializationOptions("beforeclick", typeof(DirectEventJsonConverter)), null, this.BeforeClick ));
                list.Add("beforeSelect", new ConfigOption("beforeSelect", new SerializationOptions("beforeselect", typeof(DirectEventJsonConverter)), null, this.BeforeSelect ));
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(DirectEventJsonConverter)), null, this.Click ));
                list.Add("containerClick", new ConfigOption("containerClick", new SerializationOptions("containerclick", typeof(DirectEventJsonConverter)), null, this.ContainerClick ));
                list.Add("contextMenu", new ConfigOption("contextMenu", new SerializationOptions("contextmenu", typeof(DirectEventJsonConverter)), null, this.ContextMenu ));
                list.Add("containerContextMenu", new ConfigOption("containerContextMenu", new SerializationOptions("containercontextmenu", typeof(DirectEventJsonConverter)), null, this.ContainerContextMenu ));
                list.Add("dblClick", new ConfigOption("dblClick", new SerializationOptions("dblclick", typeof(DirectEventJsonConverter)), null, this.DblClick ));
                list.Add("mouseEnter", new ConfigOption("mouseEnter", new SerializationOptions("mouseenter", typeof(DirectEventJsonConverter)), null, this.MouseEnter ));
                list.Add("mouseLeave", new ConfigOption("mouseLeave", new SerializationOptions("mouseleave", typeof(DirectEventJsonConverter)), null, this.MouseLeave ));
                list.Add("selectionChange", new ConfigOption("selectionChange", new SerializationOptions("selectionchange", typeof(DirectEventJsonConverter)), null, this.SelectionChange ));

                return list;
            }
        }
    }
}