/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TreeGridDateColumn : TreeGridColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("xtype")]
        public string XType
        {
            get
            {
                return "datecolumn";
            }
        }

        /// <summary>
        /// A formatting string as used by Date.format to format a Date for this Column (defaults to 'd').
        /// </summary>
        [Meta]
        [Category("6. ListView")]
        [DefaultValue("d")]
        [Description("A formatting string as used by Date.format to format a Date for this Column (defaults to 'd').")]
        public virtual string Format
        {
            get
            {
                object obj = this.ViewState["Format"];
                return (obj == null) ? "d" : (string)obj;
            }
            set
            {
                this.ViewState["Format"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("format")]
        [DefaultValue("m/d/Y")]
        protected virtual string FormatProxy
        {
            get
            {
                return DateTimeUtils.ConvertNetToPHP(this.Format);
            }
        }
    }
}
