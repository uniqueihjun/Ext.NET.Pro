/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class CommandSpacer : GridCommandBase
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("xtype")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        protected internal virtual string XType
        {
            get
            {
                return "nettbspacer";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CommandSpacer() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CommandSpacer(Unit width)
        {
            this.Width = width;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CommandSpacer(int width)
        {
            this.Width = Unit.Pixel(width);
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(typeof(Unit), "")]
        [NotifyParentProperty(true)]
        [Description("")]
        public Unit Width
        {
            get
            {
                return this.UnitPixelTypeCheck(ViewState["Width"], Unit.Empty, "Width");
            }
            set
            {
                this.ViewState["Width"] = value;
            }
        }

        internal Unit UnitPixelTypeCheck(object obj, Unit defaultValue, string propertyName)
        {
            Unit temp = (obj == null) ? defaultValue : (Unit)obj;

            if (temp.Type != UnitType.Pixel)
            {
                throw new InvalidCastException("The Unit Type for the toolbar spacer {0} property must be of Type 'Pixel'. Example: Unit.Pixel(150) or '150px'.".FormatWith(propertyName));
            }

            return temp;
        }
    }
}