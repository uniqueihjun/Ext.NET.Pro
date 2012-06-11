/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Text;
using System.Web.UI;
using System.Web.UI.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ExtControlDesigner : System.Web.UI.Design.ControlDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void Initialize(IComponent component)
        {
            base.Initialize(component); 
            this.control = (BaseControl)component;
        }

        BaseControl control;
        internal BaseControl Control
        {
            get
            {
                return this.control;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual DesignMode DesignMode
        {
            get
            {
                return DesignMode.ActionsOnly;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual bool Disabled
        {
            get
            {
                DesignMode mode = this.DesignMode;
                return mode == DesignMode.Disabled || mode == DesignMode.ActionsOnly;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual bool ActionsDisabled
        {
            get
            {
                DesignMode mode = this.DesignMode;
                return mode == DesignMode.Disabled;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual string EmptyDesignerText
        {
            get
            {
                return base.CreatePlaceHolderDesignTimeHtml(this.Message);    
            }
        }

        private string Message
        {
            get
            {
                return @"<table style=""margin: 8px;"">
                    <tr>
                        <td style=""white-space: nowrap;padding-right:8px;"">Please configure in Source View.</td>
                    </tr>
                </table>";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string XGetDesignTimeHtml(DesignerRegionCollection regions)
        {
            return base.GetDesignTimeHtml(regions);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string XGetDesignTimeHtml()
        {
            return base.GetDesignTimeHtml();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string GetDesignTimeHtml(DesignerRegionCollection regions)
        {
            if (this.Disabled)
            {
                return this.EmptyDesignerText;
            }
            return this.XGetDesignTimeHtml(regions);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string GetDesignTimeHtml()
        {
            if (this.Disabled)
            {
                return this.EmptyDesignerText;
            }
            return this.XGetDesignTimeHtml();
        }

        private DesignerActionListCollection actionLists;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual DesignerActionListCollection XActionLists
        {
            get
            {
                if (this.actionLists == null)
                {
                    this.actionLists = new DesignerActionListCollection();
                    this.actionLists.Add(new ExtControlActionList(this.Component));
                }

                return this.actionLists;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (this.ActionsDisabled)
                {
                    return base.ActionLists;
                }

                return this.XActionLists;
            }
        }

        /*  Properties
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public override bool AllowResize
        {
            get
            {
                return !this.Disabled;
            }
        }

        private ExtControlDesigner currentDesigner;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ExtControlDesigner CurrentDesigner
        {
            get
            {
                return currentDesigner??this;
            }
            set 
            {
                currentDesigner = value; 
            }
        }

        /*  HTML
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public virtual string HtmlBegin { get { return ""; } }

        /// <summary>
        /// 
        /// </summary>
        public virtual string HtmlEnd { get { return ""; } }


        /*  Error Handeling
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        protected override string GetErrorDesignTimeHtml(Exception e)
        {
            return base.GetDesignTimeHtml() + string.Format(ErrorMessageTemplate, e.Message, e.StackTrace);
        }

        private static string ErrorMessageTemplate
        {
            get
            {
return @"<br /><div class=""x-tip x-form-invalid-tip"" style=""position: autstarttop: auto; left:auto; visibility: visible; z-index: auto; border:0 none;display: block;"">
  <div class=""x-tip-tl"">
    <div class=""x-tip-tr"">
      <div class=""x-tip-tc"">
        <div class=""x-tip-header x-unselectable""><span class=""x-tip-header-text""></span></div>
      </div>
    </div>
  </div>
    <div class=""x-tip-bwrap"">
        <div class=""x-tip-ml"">
            <div class=""x-tip-mr"">
                <div class=""x-tip-mc"">
                    <div style=""height: auto; width: auto;"" class=""x-tip-body"">Oops! A <b>Ext.Net</b> Desgin-Time Error has occured.<br />Error Message: {0}<br /><br />Stack Trace: <br /><pre>{1}</pre><br /></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""x-tip-bl x-panel-nofooter"">
      <div class=""x-tip-br"">
        <div class=""x-tip-bc""></div>
      </div>
    </div>
  </div>
</div>";
            }
        }
    }
}