/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class DirectResponse
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
                
                list.Add("success", new ConfigOption("success", null, true, this.Success ));
                list.Add("errorMessage", new ConfigOption("errorMessage", null, null, this.ErrorMessage ));
                list.Add("script", new ConfigOption("script", null, null, this.Script ));
                list.Add("viewState", new ConfigOption("viewState", null, null, this.ViewState ));
                list.Add("viewStateEncrypted", new ConfigOption("viewStateEncrypted", null, null, this.ViewStateEncrypted ));
                list.Add("eventValidation", new ConfigOption("eventValidation", null, null, this.EventValidation ));
                list.Add("serviceResponse", new ConfigOption("serviceResponse", new SerializationOptions(JsonMode.Raw), null, this.ServiceResponse ));
                list.Add("extraParamsResponse", new ConfigOption("extraParamsResponse", new SerializationOptions(JsonMode.Raw), null, this.ExtraParamsResponse ));
                list.Add("resultProxy", new ConfigOption("resultProxy", new SerializationOptions("result", JsonMode.Raw), null, this.ResultProxy ));

                return list;
            }
        }
    }
}