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
    public partial class PropertyGridListeners
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
                
                list.Add("beforePropertyChange", new ConfigOption("beforePropertyChange", new SerializationOptions("beforepropertychange", typeof(ListenerJsonConverter)), null, this.BeforePropertyChange ));
                list.Add("propertyChange", new ConfigOption("propertyChange", new SerializationOptions("propertychange", typeof(ListenerJsonConverter)), null, this.PropertyChange ));
                list.Add("beforeSave", new ConfigOption("beforeSave", new SerializationOptions("beforesave", typeof(ListenerJsonConverter)), null, this.BeforeSave ));
                list.Add("save", new ConfigOption("save", new SerializationOptions("save", typeof(ListenerJsonConverter)), null, this.Save ));
                list.Add("saveException", new ConfigOption("saveException", new SerializationOptions("saveexception", typeof(ListenerJsonConverter)), null, this.SaveException ));

                return list;
            }
        }
    }
}