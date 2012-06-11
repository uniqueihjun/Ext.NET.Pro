/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class MonthPickerListeners
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
                
                list.Add("cancelClick", new ConfigOption("cancelClick", new SerializationOptions("cancelclick", typeof(ListenerJsonConverter)), null, this.CancelClick ));
                list.Add("monthClick", new ConfigOption("monthClick", new SerializationOptions("monthclick", typeof(ListenerJsonConverter)), null, this.MonthClick ));
                list.Add("monthDblClick", new ConfigOption("monthDblClick", new SerializationOptions("monthdblclick", typeof(ListenerJsonConverter)), null, this.MonthDblClick ));
                list.Add("oKClick", new ConfigOption("oKClick", new SerializationOptions("okclick", typeof(ListenerJsonConverter)), null, this.OKClick ));
                list.Add("select", new ConfigOption("select", new SerializationOptions("select", typeof(ListenerJsonConverter)), null, this.Select ));
                list.Add("yearClick", new ConfigOption("yearClick", new SerializationOptions("yearclick", typeof(ListenerJsonConverter)), null, this.YearClick ));
                list.Add("yearDblClick", new ConfigOption("yearDblClick", new SerializationOptions("yeardblclick", typeof(ListenerJsonConverter)), null, this.YearDblClick ));

                return list;
            }
        }
    }
}