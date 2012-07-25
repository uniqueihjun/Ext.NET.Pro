/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class EditorAlignmentConfig : BaseItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public EditorAlignmentConfig() { }

        /// <summary>
        /// Element anchor point
        /// </summary>
        [DefaultValue(AnchorPoint.Center)]
        [NotifyParentProperty(true)]
        [Description("Element anchor point")]
        public AnchorPoint ElementAnchor
        {
            get
            {
                return this.State.Get<AnchorPoint>("ElementAnchor", AnchorPoint.Center);
            }
            set
            {
                this.State.Set("ElementAnchor", value);
            }
        }

        /// <summary>
        /// Target anchor point
        /// </summary>
        [DefaultValue(AnchorPoint.Center)]
        [NotifyParentProperty(true)]
        [Description("Target anchor point")]
        public AnchorPoint TargetAnchor
        {
            get
            {
                return this.State.Get<AnchorPoint>("TargetAnchor", AnchorPoint.Center);
            }
            set
            {
                this.State.Set("TargetAnchor", value);
            }
        }

        /// <summary>
        ///  The editor will attempt to align as specified, but the position will be adjusted to constrain to the viewport if necessary
        /// </summary>
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("The editor will attempt to align as specified, but the position will be adjusted to constrain to the viewport if necessary")]
        public virtual bool ConstrainViewport
        {
            get
            {
                return this.State.Get<bool>("ConstrainViewport", true);
            }
            set
            {
                this.State.Set("ConstrainViewport", value);
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
                return this.ToString() == "c-c?";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            return Fx.AnchorConvert(this.ElementAnchor)
                    .ConcatWith("-")
                    .ConcatWith(Fx.AnchorConvert(this.TargetAnchor))
                    .ConcatWith(this.ConstrainViewport ? "?" : "");
        }
    }
}