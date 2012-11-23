/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Text;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class PanelBaseDesigner : ContainerDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected string BuildFooter
        {
            get
            {
                StringBuilder footer = new StringBuilder(256);

                PanelBase panel = (PanelBase) this.Control;
                
                footer.AppendFormat(footerTemplateBegin, FooterClass, panel.ButtonAlign.ToString().ToLower());

                foreach (ButtonBase button in panel.Buttons)
                {
                    ButtonDesigner designer = new ButtonDesigner();
                    footer.AppendFormat(buttonWraper, designer.BuildButton(button));
                }

                footer.Append(footerTemplateEnd);
                return footer.ToString();
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual string FooterClass
        {
            get
            {
                return "x-panel-footer";
            }
        }

        //0 - FooterClass
        //1 - buttons align
        private const string footerTemplateBegin = "<div class=\"{0}\"><div class=\"x-panel-btns-ct\"><div class=\"x-panel-btns x-panel-btns-{1}\"><table cellSpacing=\"0\"><tbody><tr>";

        private const string footerTemplateEnd = "</tr></tbody></table><div class=\"x-clear\"/></div></div></div>";

        //0 - button(buttonTemplate)
        private const string buttonWraper = "<td class=\"x-panel-btn-td\">{0}</td>";

        private LayoutType? layout;
        internal LayoutType? Layout
        {
            get { return layout; }
            set { layout = value; }
        }

        private BorderLayoutRegion borderRegion;
        internal BorderLayoutRegion BorderRegion
        {
            get { return borderRegion; }
            set { borderRegion = value; }
        }

        private Unit width;
        internal Unit Width
        {
            get { return width; }
            set { width = value; }
        }

        private Unit height;
        internal Unit Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}