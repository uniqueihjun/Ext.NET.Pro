/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
                list.Add("dirtyChange", new ConfigOption("dirtyChange", new SerializationOptions("dirtychange", typeof(DirectEventJsonConverter)), null, this.DirtyChange ));
                list.Add("validityChange", new ConfigOption("validityChange", new SerializationOptions("validitychange", typeof(DirectEventJsonConverter)), null, this.ValidityChange ));
                list.Add("errorChange", new ConfigOption("errorChange", new SerializationOptions("errorchange", typeof(DirectEventJsonConverter)), null, this.ErrorChange ));
                list.Add("focus", new ConfigOption("focus", new SerializationOptions("focus", typeof(DirectEventJsonConverter)), null, this.Focus ));
                list.Add("specialKey", new ConfigOption("specialKey", new SerializationOptions("specialkey", typeof(DirectEventJsonConverter)), null, this.SpecialKey ));
                list.Add("remoteValidationFailure", new ConfigOption("remoteValidationFailure", new SerializationOptions("remotevalidationfailure", typeof(DirectEventJsonConverter)), null, this.RemoteValidationFailure ));
                list.Add("remoteValidationValid", new ConfigOption("remoteValidationValid", new SerializationOptions("remotevalidationvalid", typeof(DirectEventJsonConverter)), null, this.RemoteValidationValid ));
                list.Add("remoteValidationInvalid", new ConfigOption("remoteValidationInvalid", new SerializationOptions("remotevalidationinvalid", typeof(DirectEventJsonConverter)), null, this.RemoteValidationInvalid ));
                list.Add("beforeRemoteValidation", new ConfigOption("beforeRemoteValidation", new SerializationOptions("beforeremotevalidation", typeof(DirectEventJsonConverter)), null, this.BeforeRemoteValidation ));
                list.Add("indicatorIconClick", new ConfigOption("indicatorIconClick", new SerializationOptions("indicatoriconclick", typeof(DirectEventJsonConverter)), null, this.IndicatorIconClick ));
                list.Add("writeableChange", new ConfigOption("writeableChange", new SerializationOptions("writeablechange", typeof(DirectEventJsonConverter)), null, this.WriteableChange ));

                return list;
            }
        }
    }
}