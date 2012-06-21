/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A specialized container representing the viewable application area (the browser viewport).
    /// </summary>
    [Meta]
    [Description("A specialized container representing the viewable application area (the browser viewport).")]
    public abstract partial class ViewportBase : AbstractContainer
    {
        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return this.ClientForm.IsNotEmpty() ? "netviewport" : "viewport";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return this.ClientForm.IsNotEmpty() ? "Ext.net.Viewport" : "Ext.Viewport";
            }
        }

        /// <summary>
        /// The id of the node, a DOM node or an existing Element that will be the content Container to render this component into.
        /// </summary>
        [DefaultValue("")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The id of the node, a DOM node or an existing Element that will be the content Container to render this component into.")]
        public override string RenderTo
        {
            get
            {
                string formId = this.ClientForm;

                return formId.IsNotEmpty() ? "={Ext.get(\"".ConcatWith(formId, "\")}") : "={Ext.getBody()}";
            }
            set
            {
                base.RenderTo = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override bool RemoveContainer
        {
            get
            {
                return true;
            }
        }
    }
}