/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class GridHeaderContainerDirectEvents
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
                
                list.Add("columnHide", new ConfigOption("columnHide", new SerializationOptions("columnhide", typeof(DirectEventJsonConverter)), null, this.ColumnHide ));
                list.Add("columnMove", new ConfigOption("columnMove", new SerializationOptions("columnmove", typeof(DirectEventJsonConverter)), null, this.ColumnMove ));
                list.Add("columnResize", new ConfigOption("columnResize", new SerializationOptions("columnresize", typeof(DirectEventJsonConverter)), null, this.ColumnResize ));
                list.Add("columnShow", new ConfigOption("columnShow", new SerializationOptions("columnshow", typeof(DirectEventJsonConverter)), null, this.ColumnShow ));
                list.Add("headerClick", new ConfigOption("headerClick", new SerializationOptions("headerclick", typeof(DirectEventJsonConverter)), null, this.HeaderClick ));
                list.Add("headerTriggerClick", new ConfigOption("headerTriggerClick", new SerializationOptions("headertriggerclick", typeof(DirectEventJsonConverter)), null, this.HeaderTriggerClick ));
                list.Add("menuCreate", new ConfigOption("menuCreate", new SerializationOptions("menucreate", typeof(DirectEventJsonConverter)), null, this.MenuCreate ));
                list.Add("sortChange", new ConfigOption("sortChange", new SerializationOptions("sortchange", typeof(DirectEventJsonConverter)), null, this.SortChange ));

                return list;
            }
        }
    }
}