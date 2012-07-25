/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class DirectEventConfirmation
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
                
                list.Add("confirmRequest", new ConfigOption("confirmRequest", null, false, this.ConfirmRequest ));
                list.Add("title", new ConfigOption("title", null, "Confirmation", this.Title ));
                list.Add("message", new ConfigOption("message", null, "Are you sure?", this.Message ));
                list.Add("beforeConfirmProxy", new ConfigOption("beforeConfirmProxy", new SerializationOptions("beforeConfirm", JsonMode.Raw), "", this.BeforeConfirmProxy ));
                list.Add("cancelProxy", new ConfigOption("cancelProxy", new SerializationOptions("cancel", JsonMode.Raw), "", this.CancelProxy ));

                return list;
            }
        }
    }
}