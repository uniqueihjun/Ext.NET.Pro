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
    public partial class RowSelectionModelListeners
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
                
                list.Add("beforeRowSelect", new ConfigOption("beforeRowSelect", new SerializationOptions("beforerowselect", typeof(ListenerJsonConverter)), null, this.BeforeRowSelect ));
                list.Add("rowDeselect", new ConfigOption("rowDeselect", new SerializationOptions("rowdeselect", typeof(ListenerJsonConverter)), null, this.RowDeselect ));
                list.Add("rowSelect", new ConfigOption("rowSelect", new SerializationOptions("rowselect", typeof(ListenerJsonConverter)), null, this.RowSelect ));
                list.Add("selectionChange", new ConfigOption("selectionChange", new SerializationOptions("selectionchange", typeof(ListenerJsonConverter)), null, this.SelectionChange ));
                list.Add("beforeCheckAllClick", new ConfigOption("beforeCheckAllClick", new SerializationOptions("beforecheckallclick", typeof(ListenerJsonConverter)), null, this.BeforeCheckAllClick ));
                list.Add("afterCheckAllClick", new ConfigOption("afterCheckAllClick", new SerializationOptions("aftercheckallclick", typeof(ListenerJsonConverter)), null, this.AfterCheckAllClick ));

                return list;
            }
        }
    }
}