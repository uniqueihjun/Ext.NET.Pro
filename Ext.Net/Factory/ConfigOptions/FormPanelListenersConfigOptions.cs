/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class FormPanelListeners
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
                
                list.Add("clientValidation", new ConfigOption("clientValidation", new SerializationOptions("clientvalidation", typeof(ListenerJsonConverter)), null, this.ClientValidation ));
                list.Add("actionComplete", new ConfigOption("actionComplete", new SerializationOptions("actioncomplete", typeof(ListenerJsonConverter)), null, this.ActionComplete ));
                list.Add("actionFailed", new ConfigOption("actionFailed", new SerializationOptions("actionfailed", typeof(ListenerJsonConverter)), null, this.ActionFailed ));
                list.Add("beforeAction", new ConfigOption("beforeAction", new SerializationOptions("beforeaction", typeof(ListenerJsonConverter)), null, this.BeforeAction ));

                return list;
            }
        }
    }
}