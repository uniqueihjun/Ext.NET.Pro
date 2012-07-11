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
    public partial class TreeSubmitConfig
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
                
                list.Add("withChildren", new ConfigOption("withChildren", null, false, this.WithChildren ));
                list.Add("disableAutomaticSubmit", new ConfigOption("disableAutomaticSubmit", null, false, this.DisableAutomaticSubmit ));
                list.Add("encode", new ConfigOption("encode", null, false, this.Encode ));
                list.Add("pathAttribute", new ConfigOption("pathAttribute", null, "id", this.PathAttribute ));
                list.Add("nodeFilter", new ConfigOption("nodeFilter", new SerializationOptions(JsonMode.Raw), null, this.NodeFilter ));
                list.Add("attributeFilter", new ConfigOption("attributeFilter", new SerializationOptions(JsonMode.Raw), null, this.AttributeFilter ));

                return list;
            }
        }
    }
}