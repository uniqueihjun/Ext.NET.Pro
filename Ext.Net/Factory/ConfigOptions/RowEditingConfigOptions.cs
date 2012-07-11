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
    public partial class RowEditing
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
                
                list.Add("pType", new ConfigOption("pType", new SerializationOptions("ptype"), "", this.PType ));
                list.Add("autoCancel", new ConfigOption("autoCancel", null, true, this.AutoCancel ));
                list.Add("clicksToMoveEditor", new ConfigOption("clicksToMoveEditor", null, 0, this.ClicksToMoveEditor ));
                list.Add("errorSummary", new ConfigOption("errorSummary", null, true, this.ErrorSummary ));
                list.Add("saveBtnText", new ConfigOption("saveBtnText", null, "Update", this.SaveBtnText ));
                list.Add("cancelBtnText", new ConfigOption("cancelBtnText", null, "Cancel", this.CancelBtnText ));
                list.Add("errorsText", new ConfigOption("errorsText", null, "Errors", this.ErrorsText ));
                list.Add("dirtyText", new ConfigOption("dirtyText", null, "You need to commit or cancel your changes", this.DirtyText ));
                list.Add("saveHandler", new ConfigOption("saveHandler", new SerializationOptions(JsonMode.Raw), "", this.SaveHandler ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}