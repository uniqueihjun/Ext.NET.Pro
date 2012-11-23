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
	[Description("")]
    public abstract partial class BoxLayoutConfig : LayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BoxLayoutConfig(string defaultMargins, string padding, BoxPack pack, int scrollOffset, bool renderHidden, string extraCls)
            : base(renderHidden, extraCls)
        {
            this.DefaultMargins = defaultMargins;
            this.Padding = padding;
            this.ScrollOffset = scrollOffset;
            this.Pack = pack;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected BoxLayoutConfig() { }

        /// <summary>
        /// If the individual contained items do not have a margins property specified, the default margins from this property will be applied to each item.
        /// The order of the sides associated with each value matches the way CSS processes margin values:
        ///    If there is only one value, it applies to all sides.
        ///    If there are two values, the top and bottom borders are set to the first value and the right and left are set to the second.
        ///    If there are three values, the top is set to the first value, the left and right are set to the second, and the bottom is set to the third.
        ///    If there are four values, they apply to the top, right, bottom, and left, respectively.
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        public string DefaultMargins
        {
            get
            {
                return (string)this.ViewState["DefaultMargins"] ?? "";
            }
            set
            {
                this.ViewState["DefaultMargins"] = value;
            }
        }

        /// <summary>
        /// Defaults to '0'. Sets the padding to be applied to all child items managed by this container's layout.
        /// </summary>
        [ConfigOption]
        [DefaultValue("0")]
        public string Padding
        {
            get
            {
                return (string)this.ViewState["Padding"] ?? "0";
            }
            set
            {
                this.ViewState["Padding"] = value;
            }
        }

        /// <summary>
        /// Controls how the child items of the container are packed together.
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [DefaultValue(BoxPack.Start)]
        public BoxPack Pack
        {
            get
            {
                object obj = this.ViewState["Pack"];
                return obj == null ? BoxPack.Start : (BoxPack) obj;
            }
            set
            {
                this.ViewState["Pack"] = value;
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