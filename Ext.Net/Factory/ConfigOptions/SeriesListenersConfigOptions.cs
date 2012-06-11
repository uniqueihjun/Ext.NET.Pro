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
    public partial class SeriesListeners
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
                
                list.Add("afterRender", new ConfigOption("afterRender", new SerializationOptions("afterrender", typeof(ListenerJsonConverter)), null, this.AfterRender ));
                list.Add("titleChange", new ConfigOption("titleChange", new SerializationOptions("titlechange", typeof(ListenerJsonConverter)), null, this.TitleChange ));
                list.Add("itemClick", new ConfigOption("itemClick", new SerializationOptions("itemclick", typeof(ListenerJsonConverter)), null, this.ItemClick ));
                list.Add("itemMouseDown", new ConfigOption("itemMouseDown", new SerializationOptions("itemmousedown", typeof(ListenerJsonConverter)), null, this.ItemMouseDown ));
                list.Add("itemMouseUp", new ConfigOption("itemMouseUp", new SerializationOptions("itemmouseup", typeof(ListenerJsonConverter)), null, this.ItemMouseUp ));
                list.Add("itemMouseOut", new ConfigOption("itemMouseOut", new SerializationOptions("itemmouseout", typeof(ListenerJsonConverter)), null, this.ItemMouseOut ));
                list.Add("itemMouseOver", new ConfigOption("itemMouseOver", new SerializationOptions("itemmouseover", typeof(ListenerJsonConverter)), null, this.ItemMouseOver ));

                return list;
            }
        }
    }
}