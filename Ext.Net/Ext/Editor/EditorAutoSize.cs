/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class EditorAutoSize : BaseItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public EditorAutoSize() { }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ToCamelLower)]
        [DefaultValue(EditorAutoSizeDimension.None)]
        [NotifyParentProperty(true)]
        [Description("")]
        public EditorAutoSizeDimension Width
        {
            get
            {
                return this.State.Get<EditorAutoSizeDimension>("Width", EditorAutoSizeDimension.None);
            }
            set
            {
                this.State.Set("Width", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ToCamelLower)]
        [DefaultValue(EditorAutoSizeDimension.None)]
        [NotifyParentProperty(true)]
        [Description("")]
        public EditorAutoSizeDimension Height
        {
            get
            {
                return this.State.Get<EditorAutoSizeDimension>("Height", EditorAutoSizeDimension.None);
            }
            set
            {
                this.State.Set("Height", value);
            }
        }
    }
}