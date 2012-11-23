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
    public abstract partial class CheckboxBase
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
                
                list.Add("boxLabel", new ConfigOption("boxLabel", null, "", this.BoxLabel ));
                list.Add("boxLabelStyle", new ConfigOption("boxLabelStyle", null, "", this.BoxLabelStyle ));
                list.Add("boxLabelCls", new ConfigOption("boxLabelCls", null, "", this.BoxLabelCls ));
                list.Add("checkedCls", new ConfigOption("checkedCls", null, "x-form-check-checked", this.CheckedCls ));
                list.Add("focusCls", new ConfigOption("focusCls", null, "x-form-check-focus", this.FocusCls ));
                list.Add("inputValue", new ConfigOption("inputValue", null, "", this.InputValue ));
                list.Add("mouseDownCls", new ConfigOption("mouseDownCls", null, "x-form-check-down", this.MouseDownCls ));
                list.Add("overCls", new ConfigOption("overCls", null, "x-form-check-over", this.OverCls ));
                list.Add("tag", new ConfigOption("tag", null, "", this.Tag ));

                return list;
            }
        }
    }
}