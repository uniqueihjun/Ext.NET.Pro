/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class SpinnerField
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
                
                list.Add("deferHeight", new ConfigOption("deferHeight", null, true, this.DeferHeight ));
                list.Add("incrementValue", new ConfigOption("incrementValue", null, 1.0, this.IncrementValue ));
                list.Add("alternateIncrementValue", new ConfigOption("alternateIncrementValue", null, 5.0, this.AlternateIncrementValue ));
                list.Add("triggerClass", new ConfigOption("triggerClass", null, "x-form-spinner-trigger", this.TriggerClass ));
                list.Add("splitterClass", new ConfigOption("splitterClass", null, "x-form-spinner-splitter", this.SplitterClass ));
                list.Add("defaultValue", new ConfigOption("defaultValue", null, 0.0, this.DefaultValue ));
                list.Add("accelerate", new ConfigOption("accelerate", null, false, this.Accelerate ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}