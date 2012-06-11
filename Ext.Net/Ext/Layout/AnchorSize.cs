/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class AnchorSize : ExtObject
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AnchorSize(Unit width, Unit height)
        {
            this.width = width;
            this.height = height;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AnchorSize(Unit width, Unit height, bool isFormField)
        {
            this.width = width;
            this.height = height;
            this.isFormField = isFormField;
        }

        private readonly bool isFormField;

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(false)]
		[Description("")]
        public bool IsFormField
        {
            get
            {
                return this.isFormField;
            }
        }

        private readonly Unit width;

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(typeof(Unit), "")]
		[Description("")]
        public Unit Width
        {
            get
            {
                return this.width;
            }
        }

        private readonly Unit height;

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(typeof(Unit), "")]
		[Description("")]
        public Unit Height
        {
            get
            {
                return this.height;
            }
        }
    }
}