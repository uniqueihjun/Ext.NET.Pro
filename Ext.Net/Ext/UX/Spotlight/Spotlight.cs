/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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

                baseList.Add(new ClientScriptItem(typeof(Spotlight), "Ext.Net.Build.Ext.Net.ux.spotlight.Spotlight.js", "/ux/spotlight/Spotlight.js"));

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
                return "Ext.ux.Spotlight";
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
                return this.State.Get<bool>("Animate", true);
            }
            set
            {
                this.State.Set("Animate", value);
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
                return this.State.Get<double>("Duration", 0.25);
            }
            set
            {
                this.State.Set("Duration", value);
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
                return this.State.Get<Easing>("Easing", Easing.EaseNone);
            }
            set
            {
                this.State.Set("Easing", value);
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
        public virtual void Show(BaseControl control)
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

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Description("")]
        public virtual void SyncSize()
        {
            this.Call("syncSize");
        }
    }
}