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
    public partial class FieldTrigger
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
                
                list.Add("tag", new ConfigOption("tag", null, "", this.Tag ));
                list.Add("hideTrigger", new ConfigOption("hideTrigger", null, false, this.HideTrigger ));
                list.Add("triggerCls", new ConfigOption("triggerCls", null, "", this.TriggerCls ));
                list.Add("iconClsProxy", new ConfigOption("iconClsProxy", new SerializationOptions("iconCls", JsonMode.Raw), "", this.IconClsProxy ));
                list.Add("qtip", new ConfigOption("qtip", null, "", this.Qtip ));

                return list;
            }
        }
    }
}