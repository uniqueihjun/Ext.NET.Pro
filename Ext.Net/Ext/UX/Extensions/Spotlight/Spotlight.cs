/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// This control allows you to restrict input to a particular element by masking all other page content.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:Spotlight runat=\"server\"></{0}:Spotlight>")]
    [ToolboxBitmap(typeof(Spotlight), "Build.ToolboxIcons.Spotlight.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("This control allows you to restrict input to a particular element by masking all other page content.")]
    public partial class Spotlight : Observable, IVirtual
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Spotlight() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                baseList.Add(new ClientScriptItem(typeof(Spotlight), "Ext.Net.Build.Ext.Net.ux.extensions.spotlight.spotlight.js", "/ux/extensions/spotlight/spotlight.js"));

                return baseList;
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
                return "Ext.Spotlight";
            }
        }

        /// <summary>
        /// True to animate the spot (defaults to true).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. Spotlight")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to animate the spot (defaults to true).")]
        public virtual bool Animate
        {
            get
            {
                object obj = this.ViewState["Animate"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["Animate"] = value;
            }
        }

        /// <summary>
        /// Animation duration if animate = true (defaults to .25)
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. Spotlight")]
        [DefaultValue(0.25)]
        [Description("Animation duration if animate = true (defaults to .25)")]
        public virtual double Duration
        {
            get
            {
                object obj = this.ViewState["Duration"];
                return (obj == null) ? 0.25 : (double)obj;
            }
            set
            {
                this.ViewState["Duration"] = value;
            }
        }

        /// <summary>
        /// Animation easing if animate = true (defaults to 'easeNone')
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.ToCamelLower)]
        [Category("3. Spotlight")]
        [DefaultValue(Easing.EaseNone)]
        [Description("Animation easing if animate = true (defaults to 'easeNone')")]
        public virtual Easing Easing
        {
            get
            {
                object obj = this.ViewState["Easing"];
                return (obj == null) ? Easing.EaseNone : (Easing)obj;
            }
            set
            {
                this.ViewState["Easing"] = value;
            }
        }


        /*  Public Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [Meta]
        [Description("")]
        public virtual void Show(string id)
        {
            this.Call("show");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        [Meta]
        [Description("")]
        public virtual void Show(XControl control)
        {
            this.Call("show", new JRawValue(control.ClientID));
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Description("")]
        public virtual void Hide()
        {
            this.Call("hide");
        }
    }
}