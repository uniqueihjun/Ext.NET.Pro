/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    [Description("")]
    public partial class SaveMask : LoadMask
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SaveMask() { }

        /// <summary>
        /// The text to display in a centered saving message box (defaults to 'Saving...').
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue("Saving...")]
        [Description("The text to display in a centered saving message box (defaults to 'Saving...').")]
        public override string Msg
        {
            get
            {
                return (string)this.ViewState["Msg"] ?? "Saving...";
            }
            set
            {
                this.ViewState["Msg"] = value;
            }
        }
    }
}