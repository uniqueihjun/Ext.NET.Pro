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
    /// A config object in the format: {field: 'fieldName', direction: 'ASC|DESC'}. The direction property is case-sensitive.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [DefaultProperty("Field")]
    [Description("A config object in the format: {field: 'fieldName', direction: 'ASC|DESC'}. The direction property is case-sensitive.")]
    public partial class SortInfo : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SortInfo() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SortInfo(string field, SortDirection direction)
        {
            this.Field = field;
            this.Direction = direction;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool IsDefault
        {
            get
            {
                return string.IsNullOrEmpty(this.Field);
            }
        }

        private string field = "";

        /// <summary>
        /// Internal UI Event. Fired before the view is refreshed.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Internal UI Event. Fired before the view is refreshed.")]
        public string Field
        {
            get
            {
                return this.field;
            }
            set
            {
                this.field = value;
            }
        }

        private SortDirection direction = SortDirection.Default;

        /// <summary>
        /// The direction to sort ("asc" or "desc")
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.ToLower)]
        [DefaultValue(SortDirection.Default)]
        [NotifyParentProperty(true)]
        [Description("The direction to sort (\"asc\" or \"desc\")")]
        public SortDirection Direction
        {
            get
            {
                return this.direction;
            }
            set
            {
                this.direction = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string ToExtConfigString()
        {
            return "";
        }
    }
}
