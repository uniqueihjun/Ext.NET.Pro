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
    public partial class ComboBoxListeners
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
                
                list.Add("beforeQuery", new ConfigOption("beforeQuery", new SerializationOptions("beforequery", typeof(ListenerJsonConverter)), null, this.BeforeQuery ));
                list.Add("beforeSelect", new ConfigOption("beforeSelect", new SerializationOptions("beforeselect", typeof(ListenerJsonConverter)), null, this.BeforeSelect ));
                list.Add("beforeDeselect", new ConfigOption("beforeDeselect", new SerializationOptions("beforedeselect", typeof(ListenerJsonConverter)), null, this.BeforeDeselect ));
                list.Add("select", new ConfigOption("select", new SerializationOptions("select", typeof(ListenerJsonConverter)), null, this.Select ));

                return list;
            }
        }
    }
}