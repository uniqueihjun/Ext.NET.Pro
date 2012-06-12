/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    [Meta]
    public partial class BooleanColumn : Column
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BooleanColumn() { }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("xtype")]
        [DefaultValue("")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "booleancolumn";
            }
        }

        /// <summary>
        /// The string returned by the renderer when the column value is falsey (but not undefined) (defaults to 'false').
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanColumn")]
        [DefaultValue("false")]
        [Description("The string returned by the renderer when the column value is falsey (but not undefined) (defaults to 'false').")]
        public virtual string FalseText
        {
            get
            {
                object obj = this.ViewState["FalseText"];
                return (obj == null) ? "false" : (string)obj;
            }
            set
            {
                this.ViewState["FalseText"] = value;
            }
        }

        /// <summary>
        /// The string returned by the renderer when the column value is not falsey (defaults to 'true').
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanColumn")]
        [DefaultValue("true")]
        [Description("The string returned by the renderer when the column value is not falsey (defaults to 'true').")]
        public virtual string TrueText
        {
            get
            {
                object obj = this.ViewState["TrueText"];
                return (obj == null) ? "true" : (string)obj;
            }
            set
            {
                this.ViewState["TrueText"] = value;
            }
        }

        /// <summary>
        /// The string returned by the renderer when the column value is undefined (defaults to ' ').
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanColumn")]
        [DefaultValue("&#160;")]
        [Description("The string returned by the renderer when the column value is undefined (defaults to ' ').")]
        public virtual string UndefinedText
        {
            get
            {
                object obj = this.ViewState["UndefinedText"];
                return (obj == null) ? "&#160;" : (string)obj;
            }
            set
            {
                this.ViewState["UndefinedText"] = value;
            }
        }
    }
}