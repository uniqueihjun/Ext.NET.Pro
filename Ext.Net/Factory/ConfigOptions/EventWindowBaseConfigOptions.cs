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
    public abstract partial class EventWindowBase
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
                list.Add("width", new ConfigOption("width", null, Unit.Pixel(600), this.Width ));
                list.Add("deletingMessage", new ConfigOption("deletingMessage", null, "Deleting event...", this.DeletingMessage ));
                list.Add("savingMessage", new ConfigOption("savingMessage", null, "Saving changes...", this.SavingMessage ));
                list.Add("resizable", new ConfigOption("resizable", null, false, this.Resizable ));
                list.Add("buttonAlign", new ConfigOption("buttonAlign", new SerializationOptions(JsonMode.ToLower), Alignment.Left, this.ButtonAlign ));
                list.Add("calendarStoreID", new ConfigOption("calendarStoreID", new SerializationOptions("calendarStore", JsonMode.ToClientID), "", this.CalendarStoreID ));
                list.Add("height", new ConfigOption("height", null, Unit.Empty, this.Height ));

                return list;
            }
        }
    }
}