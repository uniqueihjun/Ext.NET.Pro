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
    public abstract partial class SpinnerFieldBase
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
                
                list.Add("keyNavEnabled", new ConfigOption("keyNavEnabled", null, true, this.KeyNavEnabled ));
                list.Add("mouseWheelEnabled", new ConfigOption("mouseWheelEnabled", null, true, this.MouseWheelEnabled ));
                list.Add("repeatTriggerClick", new ConfigOption("repeatTriggerClick", null, true, this.RepeatTriggerClick ));
                list.Add("spinDownEnabled", new ConfigOption("spinDownEnabled", null, true, this.SpinDownEnabled ));
                list.Add("spinUpEnabled", new ConfigOption("spinUpEnabled", null, true, this.SpinUpEnabled ));

                return list;
            }
        }
    }
}