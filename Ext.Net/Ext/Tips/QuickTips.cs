/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    public partial class QuickTips : ScriptClass
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public QuickTips() { }

        /*  IScriptable
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.tip.QuickTipManager";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToScript()
        {
            return "";
        }


        /*  Public Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Disable quick tips globally.
        /// </summary>
        [Description("Disable quick tips globally.")]
        public virtual void Disable()
        {
            this.Call("disable");
        }

        /// <summary>
        /// Enable quick tips globally.
        /// </summary>
        [Description("Enable quick tips globally.")]
        public virtual void Enable()
        {
            this.Call("enable");
        }

        /// <summary>
        /// Initialize the global QuickTips instance and prepare any quick tips.
        /// </summary>
        /// <returns>QuickTips</returns>
        [Description("Initialize the global QuickTips instance and prepare any quick tips.")]
        public virtual void Init()
        {
            this.Call("init");
        }

        /// <summary>
        /// Initialize the global QuickTips instance and prepare any quick tips.
        /// </summary>
        /// <param name="autoRender">True to render the QuickTips container immediately to preload images. (Defaults to true)</param>
        /// <returns>QuickTips</returns>
        [Description("Initialize the global QuickTips instance and prepare any quick tips.")]
        public virtual void Init(bool autoRender)
        {
            this.Call("init", autoRender);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cfg"></param>
        [Description("")]
        public virtual void Register(QTipCfg cfg)
        {
            this.Call("register", new JRawValue(new ClientConfig().Serialize(cfg, true)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        [Description("")]
        public virtual void Unregister(string target)
        {
            target = "Ext.net.getEl({0})".FormatWith(TokenUtils.ParseAndNormalize(target));
            this.Call("unregister", new JRawValue(target));
        }
    }
}