/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public abstract partial class CheckboxGroupBase
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
                
                list.Add("itemCls", new ConfigOption("itemCls", new SerializationOptions(JsonMode.Ignore), "", this.ItemCls ));
                list.Add("itemClsProxy", new ConfigOption("itemClsProxy", new SerializationOptions("itemCls"), "", this.ItemClsProxy ));
                list.Add("allowBlank", new ConfigOption("allowBlank", null, true, this.AllowBlank ));
                list.Add("blankText", new ConfigOption("blankText", null, "", this.BlankText ));
                list.Add("columnsNumber", new ConfigOption("columnsNumber", new SerializationOptions("columns"), 0, this.ColumnsNumber ));
                list.Add("columnsWidths", new ConfigOption("columnsWidths", new SerializationOptions("columns", typeof(StringArrayJsonConverter)), null, this.ColumnsWidths ));
                list.Add("fireChangeOnLoad", new ConfigOption("fireChangeOnLoad", null, false, this.FireChangeOnLoad ));
                list.Add("vertical", new ConfigOption("vertical", null, false, this.Vertical ));

                return list;
            }
        }
    }
}