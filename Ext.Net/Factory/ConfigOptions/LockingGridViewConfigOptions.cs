/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class LockingGridView
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
                
                list.Add("lockText", new ConfigOption("lockText", null, "Lock", this.LockText ));
                list.Add("unlockText", new ConfigOption("unlockText", null, "Unlock", this.UnlockText ));
                list.Add("rowBorderWidth", new ConfigOption("rowBorderWidth", null, 1, this.RowBorderWidth ));
                list.Add("lockedBorderWidth", new ConfigOption("lockedBorderWidth", null, 1, this.LockedBorderWidth ));
                list.Add("syncHeights", new ConfigOption("syncHeights", null, false, this.SyncHeights ));

                return list;
            }
        }
    }
}