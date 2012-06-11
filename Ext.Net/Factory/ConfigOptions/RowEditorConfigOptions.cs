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
    public partial class RowEditor
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
                
                list.Add("configIDProxy", new ConfigOption("configIDProxy", new SerializationOptions("proxyId"), null, this.ConfigIDProxy ));
                list.Add("clicksToEdit", new ConfigOption("clicksToEdit", null, 0, this.ClicksToEdit ));
                list.Add("frameWidth", new ConfigOption("frameWidth", null, 5, this.FrameWidth ));
                list.Add("focusDelay", new ConfigOption("focusDelay", null, 250, this.FocusDelay ));
                list.Add("buttonPad", new ConfigOption("buttonPad", null, 3, this.ButtonPad ));
                list.Add("errorSummary", new ConfigOption("errorSummary", null, true, this.ErrorSummary ));
                list.Add("monitorValid", new ConfigOption("monitorValid", null, true, this.MonitorValid ));
                list.Add("minButtonWidth", new ConfigOption("minButtonWidth", null, Unit.Pixel(75), this.MinButtonWidth ));
                list.Add("saveText", new ConfigOption("saveText", null, "Save", this.SaveText ));
                list.Add("cancelText", new ConfigOption("cancelText", null, "Cancel", this.CancelText ));
                list.Add("commitChangesText", new ConfigOption("commitChangesText", null, "You need to commit or cancel your changes", this.CommitChangesText ));
                list.Add("errorText", new ConfigOption("errorText", null, "Errors", this.ErrorText ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}