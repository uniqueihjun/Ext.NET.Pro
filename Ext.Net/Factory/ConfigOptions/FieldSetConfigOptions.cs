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
    public partial class FieldSet
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
                
                list.Add("animCollapse", new ConfigOption("animCollapse", null, false, this.AnimCollapse ));
                list.Add("checkboxName", new ConfigOption("checkboxName", null, "", this.CheckboxName ));
                list.Add("checkboxToggle", new ConfigOption("checkboxToggle", null, false, this.CheckboxToggle ));
                list.Add("itemCls", new ConfigOption("itemCls", null, "", this.ItemCls ));
                list.Add("labelWidth", new ConfigOption("labelWidth", null, 75, this.LabelWidth ));

                return list;
            }
        }
    }
}