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
    public partial class GridHeaderContainerListeners
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
                
                list.Add("columnHide", new ConfigOption("columnHide", new SerializationOptions("columnhide", typeof(ListenerJsonConverter)), null, this.ColumnHide ));
                list.Add("columnMove", new ConfigOption("columnMove", new SerializationOptions("columnmove", typeof(ListenerJsonConverter)), null, this.ColumnMove ));
                list.Add("columnResize", new ConfigOption("columnResize", new SerializationOptions("columnresize", typeof(ListenerJsonConverter)), null, this.ColumnResize ));
                list.Add("columnShow", new ConfigOption("columnShow", new SerializationOptions("columnshow", typeof(ListenerJsonConverter)), null, this.ColumnShow ));
                list.Add("headerClick", new ConfigOption("headerClick", new SerializationOptions("headerclick", typeof(ListenerJsonConverter)), null, this.HeaderClick ));
                list.Add("headerTriggerClick", new ConfigOption("headerTriggerClick", new SerializationOptions("headertriggerclick", typeof(ListenerJsonConverter)), null, this.HeaderTriggerClick ));
                list.Add("menuCreate", new ConfigOption("menuCreate", new SerializationOptions("menucreate", typeof(ListenerJsonConverter)), null, this.MenuCreate ));
                list.Add("sortChange", new ConfigOption("sortChange", new SerializationOptions("sortchange", typeof(ListenerJsonConverter)), null, this.SortChange ));

                return list;
            }
        }
    }
}