/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// A Column definition class which renders boolean data fields. 
    /// </summary>
    [Meta]
    public partial class BooleanColumn : CellCommandColumn
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BooleanColumn() { }

		/// <summary>
		/// 
		/// </summary>
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
        [Meta]
        [ConfigOption]
        [Category("3. BooleanColumn")]
        [DefaultValue("false")]
        [Description("The string returned by the renderer when the column value is falsey (but not undefined) (defaults to 'false').")]
        public virtual string FalseText
        {
            get
            {
                return this.State.Get<string>("FalseText", "false");
            }
            set
            {
                this.State.Set("FalseText", value);
            }
        }

        /// <summary>
        /// The string returned by the renderer when the column value is not falsey (defaults to 'true').
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. BooleanColumn")]
        [DefaultValue("true")]
        [Description("The string returned by the renderer when the column value is not falsey (defaults to 'true').")]
        public virtual string TrueText
        {
            get
            {
                return this.State.Get<string>("TrueText", "true");
            }
            set
            {
                this.State.Set("TrueText", value);
            }
        }

        /// <summary>
        /// The string returned by the renderer when the column value is undefined (defaults to ' ').
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. BooleanColumn")]
        [DefaultValue("&#160;")]
        [Description("The string returned by the renderer when the column value is undefined (defaults to ' ').")]
        public virtual string UndefinedText
        {
            get
            {
                return this.State.Get<string>("UndefinedText", "&#160;");
            }
            set
            {
                this.State.Set("UndefinedText", value);
            }
        }
    }
}