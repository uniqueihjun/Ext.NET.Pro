/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
                
                list.Add("afterBoxLabelTextTpl", new ConfigOption("afterBoxLabelTextTpl", new SerializationOptions("afterBoxLabelTextTpl", typeof(LazyControlJsonConverter)), null, this.AfterBoxLabelTextTpl ));
                list.Add("afterBoxLabelTpl", new ConfigOption("afterBoxLabelTpl", new SerializationOptions("afterBoxLabelTpl", typeof(LazyControlJsonConverter)), null, this.AfterBoxLabelTpl ));
                list.Add("beforeBoxLabelTextTpl", new ConfigOption("beforeBoxLabelTextTpl", new SerializationOptions("beforeBoxLabelTextTpl", typeof(LazyControlJsonConverter)), null, this.BeforeBoxLabelTextTpl ));
                list.Add("beforeBoxLabelTpl", new ConfigOption("beforeBoxLabelTpl", new SerializationOptions("beforeBoxLabelTpl", typeof(LazyControlJsonConverter)), null, this.BeforeBoxLabelTpl ));
                list.Add("boxLabel", new ConfigOption("boxLabel", null, "", this.BoxLabel ));
                list.Add("boxLabelAlign", new ConfigOption("boxLabelAlign", new SerializationOptions(JsonMode.ToLower), BoxLabelAlign.After, this.BoxLabelAlign ));
                list.Add("boxLabelStyle", new ConfigOption("boxLabelStyle", null, "", this.BoxLabelStyle ));
                list.Add("boxLabelAttrTpl", new ConfigOption("boxLabelAttrTpl", new SerializationOptions("boxLabelAttrTpl", typeof(LazyControlJsonConverter)), null, this.BoxLabelAttrTpl ));
                list.Add("boxLabelCls", new ConfigOption("boxLabelCls", new SerializationOptions("boxLabelClsExtra"), "", this.BoxLabelCls ));
                list.Add("checkedCls", new ConfigOption("checkedCls", null, "", this.CheckedCls ));
                list.Add("handler", new ConfigOption("handler", new SerializationOptions(typeof(FunctionJsonConverter)), "", this.Handler ));
                list.Add("inputValue", new ConfigOption("inputValue", null, "", this.InputValue ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), null, this.Scope ));
                list.Add("uncheckedValue", new ConfigOption("uncheckedValue", null, null, this.UncheckedValue ));

                return list;
            }
        }
    }
}