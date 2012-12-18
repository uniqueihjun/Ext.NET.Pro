/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class RowBody
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
                
                list.Add("fType", new ConfigOption("fType", new SerializationOptions("ftype"), "", this.FType ));
                list.Add("rowBodyHiddenCls", new ConfigOption("rowBodyHiddenCls", null, "", this.RowBodyHiddenCls ));
                list.Add("rowBodyTrCls", new ConfigOption("rowBodyTrCls", null, "", this.RowBodyTrCls ));
                list.Add("rowBodyTdCls", new ConfigOption("rowBodyTdCls", null, "", this.RowBodyTdCls ));
                list.Add("rowBodyDivCls", new ConfigOption("rowBodyDivCls", null, "", this.RowBodyDivCls ));
                list.Add("getAdditionalData", new ConfigOption("getAdditionalData", new SerializationOptions(JsonMode.Raw), null, this.GetAdditionalData ));

                return list;
            }
        }
    }
}