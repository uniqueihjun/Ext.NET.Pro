/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Standard form container.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:FormPanel runat=\"server\" Title=\"Title\" Padding=\"5\" ButtonAlign=\"Right\" Height=\"185\" Width=\"300\"><Items><{0}:TextField runat=\"server\" FieldLabel=\"Label\" AnchorHorizontal=\"100%\" /></Items><Buttons><{0}:Button runat=\"server\" Icon=\"Disk\" Text=\"Submit\" /></Buttons></ext:FormPanel>")]
    [ToolboxBitmap(typeof(FormPanel), "Build.ToolboxIcons.FormPanel.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("Standard form container.")]
    public partial class FormPanel : FormPanelBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public FormPanel() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "form";
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
                return "Ext.form.FormPanel";
            }
        }

        private bool initBaseParams;
        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

            if (this.BaseParams.Count > 0 && !this.initBaseParams)
            {
                this.initBaseParams = true;
                if (this.Listeners.BeforeAction.IsDefault)
                {
                    this.Listeners.BeforeAction.Fn = this.BuildParams(this.BaseParams, null, true);
                }
                else
                {
                    if (this.Listeners.BeforeAction.Fn.IsNotEmpty())
                    {
                        this.Listeners.BeforeAction.Fn = this.BuildParams(this.BaseParams, this.Listeners.BeforeAction.Fn, true);
                    }
                    else
                    {
                        this.Listeners.BeforeAction.Fn = this.BuildParams(this.BaseParams, this.Listeners.BeforeAction.Handler, false);
                    }
                }
            }
        }

        private string BuildParams(ParameterCollection parameters, string userHandler, bool isFn)
        {
            StringBuilder sb = new StringBuilder("function(form,action){if (!form.baseParams){form.baseParams={};};");

            sb.AppendFormat("Ext.apply(form.baseParams,{0});", parameters.ToJson(0));

            if (userHandler.IsNotEmpty())
            {
                sb.Append(userHandler);

                if (isFn)
                {
                    sb.Append("(form,action);");
                }
            }
            sb.Append("}");

            return sb.ToString();
        }

        private FormPanelListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ViewStateMember]
        [Description("Client-side JavaScript Event Handlers")]
        public FormPanelListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new FormPanelListeners();
                }

                return this.listeners;
            }
        }

        private FormPanelDirectEvents directEvents;

        /// <summary>
        /// Server-side Ajax Event Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [ViewStateMember]
        [Description("Server-side Ajax Event Handlers")]
        public FormPanelDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new FormPanelDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}