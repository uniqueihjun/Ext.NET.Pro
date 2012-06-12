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
    public partial class ColumnLayoutConfig : LayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ColumnLayoutConfig(bool fitHeight, bool split, int margin, int scrollOffset, bool background, bool renderHidden, string extraCls)
            : base(renderHidden, extraCls)
        {
            this.FitHeight = fitHeight;
            this.Split = split;
            this.Margin = margin;
            this.ScrollOffset = scrollOffset;
            this.Background = background;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ColumnLayoutConfig()
        {
        }

        /// <summary>
        /// Fit item's height
        /// </summary>
        [ConfigOption]
        [DefaultValue(true)]
        public virtual bool FitHeight
        {
            get
            {
                object obj = this.ViewState["FitHeight"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["FitHeight"] = value;
            }
        }

        /// <summary>
        /// True to fill background by predefined color. Defaults to false.
        /// </summary>
        [ConfigOption]
        [DefaultValue(false)]
        public virtual bool Background
        {
            get
            {
                object obj = this.ViewState["Background"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["Background"] = value;
            }
        }


        /// <summary>
        /// Add splitter to the item
        /// </summary>
        [ConfigOption]
        [DefaultValue(false)]
        public virtual bool Split
        {
            get
            {
                object obj = this.ViewState["Split"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["Split"] = value;
            }
        }
        
        /// <summary>
        /// Item's margin
        /// </summary>
        [ConfigOption]
        [DefaultValue(0)]
        public virtual int Margin
        {
            get
            {
                object obj = this.ViewState["Margin"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["Margin"] = value;
            }
        }

        /// <summary>
        /// The amount of space to reserve for the scrollbar
        /// </summary>
        [ConfigOption]
        [DefaultValue(0)]
        public virtual int ScrollOffset
        {
            get
            {
                object obj = this.ViewState["ScrollOffset"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["ScrollOffset"] = value;
            }
        }
    }
}