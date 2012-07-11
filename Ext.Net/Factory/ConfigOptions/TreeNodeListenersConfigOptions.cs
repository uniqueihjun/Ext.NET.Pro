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
    public partial class TreeNodeListeners
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
                
                list.Add("beforeChildrenRendered", new ConfigOption("beforeChildrenRendered", new SerializationOptions("beforechildrenrendered", typeof(ListenerJsonConverter)), null, this.BeforeChildrenRendered ));
                list.Add("beforeClick", new ConfigOption("beforeClick", new SerializationOptions("beforeclick", typeof(ListenerJsonConverter)), null, this.BeforeClick ));
                list.Add("beforeCollapse", new ConfigOption("beforeCollapse", new SerializationOptions("beforecollapse", typeof(ListenerJsonConverter)), null, this.BeforeCollapse ));
                list.Add("beforeExpand", new ConfigOption("beforeExpand", new SerializationOptions("beforeexpand", typeof(ListenerJsonConverter)), null, this.BeforeExpand ));
                list.Add("checkChange", new ConfigOption("checkChange", new SerializationOptions("checkchange", typeof(ListenerJsonConverter)), null, this.CheckChange ));
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(ListenerJsonConverter)), null, this.Click ));
                list.Add("collapse", new ConfigOption("collapse", new SerializationOptions("collapse", typeof(ListenerJsonConverter)), null, this.Collapse ));
                list.Add("contextMenu", new ConfigOption("contextMenu", new SerializationOptions("contextmenu", typeof(ListenerJsonConverter)), null, this.ContextMenu ));
                list.Add("dblClick", new ConfigOption("dblClick", new SerializationOptions("dblclick", typeof(ListenerJsonConverter)), null, this.DblClick ));
                list.Add("disabledChange", new ConfigOption("disabledChange", new SerializationOptions("disabledchange", typeof(ListenerJsonConverter)), null, this.DisabledChange ));
                list.Add("expand", new ConfigOption("expand", new SerializationOptions("expand", typeof(ListenerJsonConverter)), null, this.Expand ));
                list.Add("textChange", new ConfigOption("textChange", new SerializationOptions("textchange", typeof(ListenerJsonConverter)), null, this.TextChange ));

                return list;
            }
        }
    }
}