/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// This is a utility class that can be passed into a Ext.grid.column.Column as a column config that provides an automatic row numbering column.
    /// </summary>
    [Meta]
    [Description("")]
    public partial class RowNumbererColumn : ColumnBase, INoneEditable
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public RowNumbererColumn() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string XType
        {
            get
            {
                return "rownumberer";
            }
        }

        /// <summary>
        /// True to enable drag-drop reordering of this column.
        /// </summary>
        [DefaultValue(false)]
        [Description("True to enable drag-drop reordering of this column.")]
        public override bool Draggable
        {
            get
            {
                return this.State.Get<bool>("Draggable", false);
            }
            set
            {
                this.State.Set("Draggable", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        [ConfigOption("draggable")]
        protected override bool DraggableProxy
        {
            get
            {
                return !this.Draggable && this.DraggableConfig == null ? false : true;
            }
        }

        /// <summary>
        /// The default width in pixels of the row number column. Defaults to: 23
        /// </summary>
        [ConfigOption]
        [Category("2. ColumnBase")]
        [DefaultValue(typeof(Unit), "23")]
        [Description("The default width in pixels of the row number column. Defaults to: 23")]
        public override Unit Width
        {
            get
            {
                return this.State.Get<Unit>("Width", Unit.Pixel(23));
            }
            set
            {
                this.State.Set("Width", value);
            }
        }

        /// <summary>
        /// RowSpan attribute for the checkbox table cell
        /// </summary>
        [Meta]
        [ConfigOption("rowspan")]
        [Category("Config Options")]
        [DefaultValue(1)]
        [Description("RowSpan attribute for the checkbox table cell")]
        public override int RowSpan
        {
            get
            {
                return this.State.Get<int>("RowSpan", 1);
            }
            set
            {
                this.State.Set("RowSpan", value);
            }
        }
    }
}
