/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class TreePanelListeners
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
                
                list.Add("afterItemCollapse", new ConfigOption("afterItemCollapse", new SerializationOptions("afteritemcollapse", typeof(ListenerJsonConverter)), null, this.AfterItemCollapse ));
                list.Add("afterItemExpand", new ConfigOption("afterItemExpand", new SerializationOptions("afteritemexpand", typeof(ListenerJsonConverter)), null, this.AfterItemExpand ));
                list.Add("beforeItemAppend", new ConfigOption("beforeItemAppend", new SerializationOptions("beforeitemappend", typeof(ListenerJsonConverter)), null, this.BeforeItemAppend ));
                list.Add("beforeItemCollapse", new ConfigOption("beforeItemCollapse", new SerializationOptions("beforeitemcollapse", typeof(ListenerJsonConverter)), null, this.BeforeItemCollapse ));
                list.Add("beforeItemExpand", new ConfigOption("beforeItemExpand", new SerializationOptions("beforeitemexpand", typeof(ListenerJsonConverter)), null, this.BeforeItemExpand ));
                list.Add("beforeItemInsert", new ConfigOption("beforeItemInsert", new SerializationOptions("beforeiteminsert", typeof(ListenerJsonConverter)), null, this.BeforeItemInsert ));
                list.Add("beforeItemMove", new ConfigOption("beforeItemMove", new SerializationOptions("beforeitemmove", typeof(ListenerJsonConverter)), null, this.BeforeItemMove ));
                list.Add("beforeItemRemove", new ConfigOption("beforeItemRemove", new SerializationOptions("beforeitemremove", typeof(ListenerJsonConverter)), null, this.BeforeItemRemove ));
                list.Add("beforeLoad", new ConfigOption("beforeLoad", new SerializationOptions("beforeload", typeof(ListenerJsonConverter)), null, this.BeforeLoad ));
                list.Add("checkChange", new ConfigOption("checkChange", new SerializationOptions("checkchange", typeof(ListenerJsonConverter)), null, this.CheckChange ));
                list.Add("itemAppend", new ConfigOption("itemAppend", new SerializationOptions("itemappend", typeof(ListenerJsonConverter)), null, this.ItemAppend ));
                list.Add("itemCollapse", new ConfigOption("itemCollapse", new SerializationOptions("itemcollapse", typeof(ListenerJsonConverter)), null, this.ItemCollapse ));
                list.Add("itemExpand", new ConfigOption("itemExpand", new SerializationOptions("itemexpand", typeof(ListenerJsonConverter)), null, this.ItemExpand ));
                list.Add("itemInsert", new ConfigOption("itemInsert", new SerializationOptions("iteminsert", typeof(ListenerJsonConverter)), null, this.ItemInsert ));
                list.Add("itemMove", new ConfigOption("itemMove", new SerializationOptions("itemmove", typeof(ListenerJsonConverter)), null, this.ItemMove ));
                list.Add("itemRemove", new ConfigOption("itemRemove", new SerializationOptions("itemremove", typeof(ListenerJsonConverter)), null, this.ItemRemove ));
                list.Add("load", new ConfigOption("load", new SerializationOptions("load", typeof(ListenerJsonConverter)), null, this.Load ));
                list.Add("submit", new ConfigOption("submit", new SerializationOptions("submit", typeof(ListenerJsonConverter)), null, this.Submit ));
                list.Add("submitException", new ConfigOption("submitException", new SerializationOptions("submitexception", typeof(ListenerJsonConverter)), null, this.SubmitException ));
                list.Add("beforeRemoteAction", new ConfigOption("beforeRemoteAction", new SerializationOptions("beforeremoteaction", typeof(ListenerJsonConverter)), null, this.BeforeRemoteAction ));
                list.Add("remoteActionException", new ConfigOption("remoteActionException", new SerializationOptions("remoteactionexception", typeof(ListenerJsonConverter)), null, this.RemoteActionException ));
                list.Add("remoteActionRefusal", new ConfigOption("remoteActionRefusal", new SerializationOptions("remoteactionrefusal", typeof(ListenerJsonConverter)), null, this.RemoteActionRefusal ));
                list.Add("remoteActionSuccess", new ConfigOption("remoteActionSuccess", new SerializationOptions("remoteactionsuccess", typeof(ListenerJsonConverter)), null, this.RemoteActionSuccess ));
                list.Add("beforeRemoteMove", new ConfigOption("beforeRemoteMove", new SerializationOptions("beforeremotemove", typeof(ListenerJsonConverter)), null, this.BeforeRemoteMove ));
                list.Add("beforeRemoteRename", new ConfigOption("beforeRemoteRename", new SerializationOptions("beforeremoterename", typeof(ListenerJsonConverter)), null, this.BeforeRemoteRename ));
                list.Add("beforeRemoteRemove", new ConfigOption("beforeRemoteRemove", new SerializationOptions("beforeremoteremove", typeof(ListenerJsonConverter)), null, this.BeforeRemoteRemove ));
                list.Add("beforeRemoteAppend", new ConfigOption("beforeRemoteAppend", new SerializationOptions("beforeremoteappend", typeof(ListenerJsonConverter)), null, this.BeforeRemoteAppend ));

                return list;
            }
        }
    }
}