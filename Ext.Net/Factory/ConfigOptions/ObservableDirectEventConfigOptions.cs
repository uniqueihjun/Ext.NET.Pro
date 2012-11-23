/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class ObservableDirectEvent
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
                
                list.Add("after", new ConfigOption("after", new SerializationOptions(typeof(DirectEventHandlerJsonConverter)), "", this.After ));
                list.Add("before", new ConfigOption("before", new SerializationOptions(typeof(DirectEventHandlerJsonConverter)), "", this.Before ));
                list.Add("success", new ConfigOption("success", new SerializationOptions("userSuccess", typeof(DirectEventHandlerJsonConverter)), "", this.Success ));
                list.Add("failure", new ConfigOption("failure", new SerializationOptions("userFailure", typeof(DirectEventHandlerJsonConverter)), "", this.Failure ));
                list.Add("complete", new ConfigOption("complete", new SerializationOptions("userComplete", typeof(DirectEventHandlerJsonConverter)), "", this.Complete ));

                return list;
            }
        }
    }
}