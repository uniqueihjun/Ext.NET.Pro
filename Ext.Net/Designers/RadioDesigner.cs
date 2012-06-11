/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class RadioDesigner : ExtControlDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string XGetDesignTimeHtml()
        {
            StringWriter writer = new StringWriter(CultureInfo.CurrentCulture);
            HtmlTextWriter htmlWriter = new HtmlTextWriter(writer);

            Radio c = (Radio)this.Control;

            object[] args = new object[7];
            args[0] = c.ClientID;
            args[1] = c.Checked.ToString().ToLower();
            args[5] = c.StyleSpec;
            args[6] = "x-form-radio x-form-field " + c.Cls;
            
            LiteralControl ctrl = new LiteralControl(string.Format(this.Html, args));
            ctrl.RenderControl(htmlWriter);

            return writer.ToString();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string Html
        {
            get
            {
                /*
                 * 0 - ClientID
                 * 1 - Checked
                 * 2 - Style
                 * 3 - Class
                 */
                return @"<input checked=""{1}"" style=""{2}"" class=""{3}"" type=""radio"">";
            }
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
                    actionLists.Add(new RadioActionList(this.Component));
                }

                return actionLists;
            }
        }
    }
}