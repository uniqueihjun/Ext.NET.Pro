/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class TreeEditorFilter : StateManagedItem
    {
        /// <summary>
        /// Attribute name to retrieve the value
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Attribute name to retrieve the value")]
        public virtual string Attribute
        {
            get
            {
                return (string)this.ViewState["Attribute"] ?? "";
            }
            set
            {
                this.ViewState["Attribute"] = value;
            }
        }

        /// <summary>
        /// Value of attribute, the editor will be shown if a node has attribute with the same value
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Value of attribute, the editor will be shown if a node has attribute with the same value")]
        public virtual string Value
        {
            get
            {
                return (string)this.ViewState["Value"] ?? "";
            }
            set
            {
                this.ViewState["Value"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool IsDefault
        {
            get
            {
                return this.Attribute.IsEmpty() || this.Value.IsEmpty();
            }
        }
    }
}