/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Web.UI;
using System.Web.UI.Design;
using System.Web.UI.HtmlControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class FieldSetDesigner : PanelDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string XGetDesignTimeHtml(DesignerRegionCollection regions)
        {
            EditableDesignerRegion region = new EditableDesignerRegion(this, "Body", false);
            regions.Add(region);

            StringWriter writer = new StringWriter(CultureInfo.CurrentCulture);
            HtmlTextWriter htmlWriter = new HtmlTextWriter(writer);

            FieldSet c = (FieldSet)this.Control;

            string width = " width: {0};".FormatWith(c.Width.ToString());
            string height = " height: {0}px;".FormatWith((c.Height.Value - 39).ToString());

            string buttons = "";
            buttons += (c.CheckboxToggle && !c.Collapsible) ? "<input name=\"ext-comp-1002-checkbox\" type=\"checkbox\">" : "";
            buttons += (c.Collapsible && !c.CheckboxToggle) ? "<div class=\"x-tool x-tool-toggle\">&nbsp;</div>" : "";
            
            /*
             * 0 - ClientID
             * 1 - Title
             * 2 - Width
             * 3 - Height
             * 4 - Buttons
             * 5 - BodyStyle
             */

            object[] args = new object[6];
            args[0] = c.ClientID;
            args[1] = c.Title;
            args[2] = width;
            args[3] = height;
            args[4] = buttons;
            args[5] = c.BodyStyle;

            LiteralControl topCtrl = new LiteralControl(string.Format(this.HtmlBegin, args));
            topCtrl.RenderControl(htmlWriter);

            HtmlGenericControl div = (HtmlGenericControl)c.ContentContainer;
            div.Attributes[DesignerRegion.DesignerRegionAttributeName] = "0";
            div.InnerHtml = this.GetEditableDesignerRegionContent(region);
            div.RenderControl(htmlWriter);

            LiteralControl bottomCtrl = new LiteralControl(this.HtmlEnd);
            bottomCtrl.RenderControl(htmlWriter);

            return writer.ToString();
        }

        private DesignerActionListCollection actionLists;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionListCollection XActionLists
        {
            get
            {
                if (actionLists == null)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new FieldSetActionList(this.Component));
                }

                return actionLists;
            }
        }

        /*
         * 0 - ClientID
         * 1 - Title
         * 2 - Width
         * 3 - Height
         * 4 - Buttons
         * 5 - BodyStyle
         */

        /// <summary>
        /// 
        /// </summary>
        public override string HtmlBegin
        {
            get
            {
                return
@"<fieldset style=""{2}"" class=""x-fieldset"">
		<legend style=""-moz-user-select: none;"" class=""x-fieldset-header x-unselectable"">
			{4}
			<span class=""x-fieldset-header-text"">{1}</span>
		</legend>
		<div class=""x-fieldset-bwrap"">
			<div style=""{5}{3}"" class=""x-fieldset-body"">";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string HtmlEnd
        {
            get
            {
                return
@"		</div>
	</div>
</fieldset>";
            }
        }
    }
}