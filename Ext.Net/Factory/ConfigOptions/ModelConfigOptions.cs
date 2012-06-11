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
    public partial class Model
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
                
                list.Add("configIDProxy", new ConfigOption("configIDProxy", new SerializationOptions(JsonMode.Ignore), null, this.ConfigIDProxy ));
                list.Add("belongsToProxy", new ConfigOption("belongsToProxy", new SerializationOptions("belongsTo", JsonMode.Raw), "", this.BelongsToProxy ));
                list.Add("hasManyProxy", new ConfigOption("hasManyProxy", new SerializationOptions("hasMany", JsonMode.Raw), "", this.HasManyProxy ));
                list.Add("clientIdProperty", new ConfigOption("clientIdProperty", null, "clientId", this.ClientIdProperty ));
                list.Add("fields", new ConfigOption("fields", new SerializationOptions(JsonMode.AlwaysArray), null, this.Fields ));
                list.Add("iDProperty", new ConfigOption("iDProperty", new SerializationOptions("idProperty"), "", this.IDProperty ));
                list.Add("proxy", new ConfigOption("proxy", new SerializationOptions("proxy>Primary"), null, this.Proxy ));
                list.Add("associations", new ConfigOption("associations", new SerializationOptions(JsonMode.AlwaysArray), null, this.Associations ));
                list.Add("validations", new ConfigOption("validations", new SerializationOptions(JsonMode.Array), null, this.Validations ));
                list.Add("iDGen", new ConfigOption("iDGen", new SerializationOptions("idgen>Primary"), null, this.IDGen ));

                return list;
            }
        }
    }
}