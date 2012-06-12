/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ListViewBooleanColumn : ListViewColumn
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("xtype")]
		[Description("")]
        public string XType
        {
            get
            {
                return "lvbooleancolumn";
            }
        }
        
        /// <summary>
        /// The string returned by the renderer when the column value is falsey (but not undefined) (defaults to 'false').
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. ListView")]
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
        [Meta]
        [ConfigOption]
        [Category("6. ListView")]
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
        [Meta]
        [ConfigOption]
        [Category("6. ListView")]
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