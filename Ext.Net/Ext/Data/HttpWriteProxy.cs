/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("")]
    public partial class HttpWriteProxy : HttpProxy
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public HttpWriteProxy() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.net.HttpWriteProxy";
            }
        }

        /// <summary>
        /// If save handler is web service then response will be xml. This option specifies how to handle response.
        /// If false then the response is handled as json
        /// If true then the response is handled as xml
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("If save handler is web service then response will be xml. This option specifies how to handle response.")]
        public bool HandleSaveResponseAsXml
        {
            get
            {
                object obj = this.ViewState["HandleSaveResponseAsXml"];
                return obj == null ? false : (bool)obj;
            }
            set
            {
                this.ViewState["HandleSaveResponseAsXml"] = value;
            }
        }
    }
}
