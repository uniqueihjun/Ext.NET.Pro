/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class GridPanelBase
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
                
                list.Add("selectionSubmit", new ConfigOption("selectionSubmit", null, true, this.SelectionSubmit ));
                list.Add("selectionMemory", new ConfigOption("selectionMemory", null, true, this.SelectionMemory ));
                list.Add("selectionMemoryEvents", new ConfigOption("selectionMemoryEvents", null, true, this.SelectionMemoryEvents ));
                list.Add("syncRowHeight", new ConfigOption("syncRowHeight", null, true, this.SyncRowHeight ));
                list.Add("lockText", new ConfigOption("lockText", null, "Lock", this.LockText ));
                list.Add("unlockText", new ConfigOption("unlockText", null, "Unlock", this.UnlockText ));
                list.Add("lockedView", new ConfigOption("lockedView", new SerializationOptions("lockedViewConfig>View"), null, this.LockedView ));
                list.Add("normalView", new ConfigOption("normalView", new SerializationOptions("normalViewConfig>View"), null, this.NormalView ));
                list.Add("view", new ConfigOption("view", new SerializationOptions("viewConfig>View"), null, this.View ));
                list.Add("verticalScroller", new ConfigOption("verticalScroller", new SerializationOptions("verticalScroller>Scroller"), null, this.VerticalScroller ));
                list.Add("store", new ConfigOption("store", new SerializationOptions("store>Primary", 1), null, this.Store ));
                list.Add("features", new ConfigOption("features", new SerializationOptions(typeof(ItemCollectionJsonConverter)), null, this.Features ));

                return list;
            }
        }
    }
}