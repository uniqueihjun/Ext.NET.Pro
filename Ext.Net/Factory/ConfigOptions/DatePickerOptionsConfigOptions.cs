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
    public partial class DatePickerOptions
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
                
                list.Add("applyTo", new ConfigOption("applyTo", new SerializationOptions(JsonMode.Ignore), null, this.ApplyTo ));
                list.Add("configIDProxy", new ConfigOption("configIDProxy", new SerializationOptions(JsonMode.Ignore), null, this.ConfigIDProxy ));
                list.Add("iD", new ConfigOption("iD", new SerializationOptions(JsonMode.Ignore), null, this.ID ));
                list.Add("renderTo", new ConfigOption("renderTo", new SerializationOptions(JsonMode.Ignore), null, this.RenderTo ));
                list.Add("renderToProxy", new ConfigOption("renderToProxy", new SerializationOptions(JsonMode.Ignore), null, this.RenderToProxy ));

                return list;
            }
        }
    }
}