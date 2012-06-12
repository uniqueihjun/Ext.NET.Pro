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
    public abstract partial class EventEditWindowBase
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
                
                list.Add("titleTextAdd", new ConfigOption("titleTextAdd", null, "Add Event", this.TitleTextAdd ));
                list.Add("titleTextEdit", new ConfigOption("titleTextEdit", null, "Edit Event", this.TitleTextEdit ));
                list.Add("savingMessage", new ConfigOption("savingMessage", null, "Saving changes...", this.SavingMessage ));
                list.Add("deletingMessage", new ConfigOption("deletingMessage", null, "Deleting event...", this.DeletingMessage ));
                list.Add("groupStoreID", new ConfigOption("groupStoreID", new SerializationOptions("calendarStore", JsonMode.ToClientID), "", this.GroupStoreID ));
                list.Add("width", new ConfigOption("width", null, Unit.Empty, this.Width ));
                list.Add("height", new ConfigOption("height", null, Unit.Empty, this.Height ));

                return list;
            }
        }
    }
}