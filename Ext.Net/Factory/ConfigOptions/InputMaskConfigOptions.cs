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
    public partial class InputMask
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
                
                list.Add("alwaysShow", new ConfigOption("alwaysShow", null, false, this.AlwaysShow ));
                list.Add("clearWhenInvalid", new ConfigOption("clearWhenInvalid", null, true, this.ClearWhenInvalid ));
                list.Add("allowInvalid", new ConfigOption("allowInvalid", null, false, this.AllowInvalid ));
                list.Add("invalidMaskText", new ConfigOption("invalidMaskText", null, "", this.InvalidMaskText ));
                list.Add("mask", new ConfigOption("mask", null, "", this.Mask ));
                list.Add("maskSymbolsProxy", new ConfigOption("maskSymbolsProxy", new SerializationOptions("maskSymbols", JsonMode.Raw), "", this.MaskSymbolsProxy ));
                list.Add("placeholder", new ConfigOption("placeholder", null, '_', this.Placeholder ));
                list.Add("unmaskOnBlur", new ConfigOption("unmaskOnBlur", null, false, this.UnmaskOnBlur ));

                return list;
            }
        }
    }
}