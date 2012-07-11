/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class DropDownFieldBase
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
                
                list.Add("valueHiddenName", new ConfigOption("valueHiddenName", null, "", this.ValueHiddenName ));
                list.Add("text", new ConfigOption("text", null, "", this.Text ));
                list.Add("mode", new ConfigOption("mode", new SerializationOptions(JsonMode.ToLower), DropDownMode.Text, this.Mode ));
                list.Add("allowBlur", new ConfigOption("allowBlur", null, false, this.AllowBlur ));
                list.Add("component", new ConfigOption("component", new SerializationOptions("component", typeof(SingleItemCollectionJsonConverter)), null, this.Component ));
                list.Add("componentRenderTo", new ConfigOption("componentRenderTo", null, "", this.ComponentRenderTo ));
                list.Add("syncValue", new ConfigOption("syncValue", new SerializationOptions(JsonMode.Raw), null, this.SyncValue ));

                return list;
            }
        }
    }
}