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
    public partial class ValidationStatus
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
                
                list.Add("formPanelID", new ConfigOption("formPanelID", new SerializationOptions("form", JsonMode.ToClientID), "", this.FormPanelID ));
                list.Add("errorIconClsProxy", new ConfigOption("errorIconClsProxy", new SerializationOptions("errorIconCls"), "", this.ErrorIconClsProxy ));
                list.Add("errorListCls", new ConfigOption("errorListCls", null, "x-status-error-list", this.ErrorListCls ));
                list.Add("validIconClsProxy", new ConfigOption("validIconClsProxy", new SerializationOptions("validIconCls"), "", this.ValidIconClsProxy ));
                list.Add("showText", new ConfigOption("showText", null, "The form has errors (click for details...)", this.ShowText ));
                list.Add("hideText", new ConfigOption("hideText", null, "Click again to hide the error list", this.HideText ));

                return list;
            }
        }
    }
}