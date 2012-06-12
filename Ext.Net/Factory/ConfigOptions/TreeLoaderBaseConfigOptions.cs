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
    public abstract partial class TreeLoaderBase
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
                
                list.Add("baseAttributes", new ConfigOption("baseAttributes", new SerializationOptions("baseAttrs", JsonMode.ArrayToObject), null, this.BaseAttributes ));
                list.Add("json", new ConfigOption("json", null, false, this.Json ));
                list.Add("clearOnLoad", new ConfigOption("clearOnLoad", null, true, this.ClearOnLoad ));
                list.Add("urlProxy", new ConfigOption("urlProxy", new SerializationOptions("url"), "", this.UrlProxy ));
                list.Add("preloadChildren", new ConfigOption("preloadChildren", null, false, this.PreloadChildren ));
                list.Add("requestMethod", new ConfigOption("requestMethod", null, HttpMethod.Default, this.RequestMethod ));
                list.Add("timeout", new ConfigOption("timeout", null, 30000, this.Timeout ));
                list.Add("uIProvidersProxy", new ConfigOption("uIProvidersProxy", new SerializationOptions("uiProviders", JsonMode.Raw), "{}", this.UIProvidersProxy ));

                return list;
            }
        }
    }
}