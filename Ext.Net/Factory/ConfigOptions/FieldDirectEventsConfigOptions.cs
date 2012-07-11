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
    public partial class FieldDirectEvents
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
                
                list.Add("blur", new ConfigOption("blur", new SerializationOptions("blur", typeof(DirectEventJsonConverter)), null, this.Blur ));
                list.Add("change", new ConfigOption("change", new SerializationOptions("change", typeof(DirectEventJsonConverter)), null, this.Change ));
                list.Add("focus", new ConfigOption("focus", new SerializationOptions("focus", typeof(DirectEventJsonConverter)), null, this.Focus ));
                list.Add("invalid", new ConfigOption("invalid", new SerializationOptions("invalid", typeof(DirectEventJsonConverter)), null, this.Invalid ));
                list.Add("specialKey", new ConfigOption("specialKey", new SerializationOptions("specialkey", typeof(DirectEventJsonConverter)), null, this.SpecialKey ));
                list.Add("valid", new ConfigOption("valid", new SerializationOptions("valid", typeof(DirectEventJsonConverter)), null, this.Valid ));
                list.Add("remoteValidationFailure", new ConfigOption("remoteValidationFailure", new SerializationOptions("remotevalidationfailure", typeof(DirectEventJsonConverter)), null, this.RemoteValidationFailure ));
                list.Add("remoteValidationValid", new ConfigOption("remoteValidationValid", new SerializationOptions("remotevalidationvalid", typeof(DirectEventJsonConverter)), null, this.RemoteValidationValid ));
                list.Add("remoteValidationInvalid", new ConfigOption("remoteValidationInvalid", new SerializationOptions("remotevalidationinvalid", typeof(DirectEventJsonConverter)), null, this.RemoteValidationInvalid ));
                list.Add("indicatorIconClick", new ConfigOption("indicatorIconClick", new SerializationOptions("indicatoriconclick", typeof(DirectEventJsonConverter)), null, this.IndicatorIconClick ));

                return list;
            }
        }
    }
}