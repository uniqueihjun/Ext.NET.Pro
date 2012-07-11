/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class RowLayoutConfig : LayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public RowLayoutConfig(bool split, int margin, bool background, bool renderHidden, string extraCls)
            : base(renderHidden, extraCls)
        {
            this.Split = split;
            this.Margin = margin;
            this.Background = background;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public RowLayoutConfig() { }

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
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(false)]
		[Description("")]
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
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(0)]
		[Description("")]
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
    }
}