/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [DefaultProperty("ScriptBlock")]
    [ParseChildren(true, "ScriptBlock")]
    [ToolboxBitmap(typeof(XScript), "Build.ToolboxIcons.XScript.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("")]
    public partial class XScript : XControl
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public XScript() { }

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

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerDefaultProperty)]
        [DefaultValue("")]
        [Description("Script text")]
        public string ScriptBlock
        {
            get
            {
                return (string)this.ViewState["ScriptBlock"] ?? "";
            }
            set
            {
                this.ViewState["ScriptBlock"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        [Description("")]
        protected override void OnPreRender(EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.Controls.Add(new LiteralControl(TokenUtils.ReplaceRawToken(TokenUtils.ParseTokens(this.ScriptBlock, this))));
            }

            base.OnPreRender(e);
        }
    }
}