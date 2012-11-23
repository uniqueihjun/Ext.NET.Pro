/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public abstract partial class TriggerFieldBase
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
                
                list.Add("triggers", new ConfigOption("triggers", new SerializationOptions("triggersConfig", JsonMode.AlwaysArray), null, this.Triggers ));
                list.Add("hideTrigger", new ConfigOption("hideTrigger", null, false, this.HideTrigger ));
                list.Add("editable", new ConfigOption("editable", null, true, this.Editable ));
                list.Add("firstBaseTrigger", new ConfigOption("firstBaseTrigger", null, false, this.FirstBaseTrigger ));
                list.Add("triggerIconClsProxy", new ConfigOption("triggerIconClsProxy", new SerializationOptions("triggerClass"), "", this.TriggerIconClsProxy ));

                return list;
            }
        }
    }
}