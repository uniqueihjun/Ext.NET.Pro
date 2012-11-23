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
    public partial class ColumnListeners
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
                
                list.Add("columnMoved", new ConfigOption("columnMoved", new SerializationOptions("columnmoved", typeof(ListenerJsonConverter)), null, this.ColumnMoved ));
                list.Add("configChanged", new ConfigOption("configChanged", new SerializationOptions("configchanged", typeof(ListenerJsonConverter)), null, this.ConfigChanged ));
                list.Add("headerChange", new ConfigOption("headerChange", new SerializationOptions("headerchange", typeof(ListenerJsonConverter)), null, this.HeaderChange ));
                list.Add("hiddenChange", new ConfigOption("hiddenChange", new SerializationOptions("hiddenchange", typeof(ListenerJsonConverter)), null, this.HiddenChange ));
                list.Add("widthChange", new ConfigOption("widthChange", new SerializationOptions("widthchange", typeof(ListenerJsonConverter)), null, this.WidthChange ));

                return list;
            }
        }
    }
}