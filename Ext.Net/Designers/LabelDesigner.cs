/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class LabelDesigner : ExtControlDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string XGetDesignTimeHtml()
        {
            Label l = (Label) this.Control;
            
            if (l.Text.IsNotEmpty())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<span");

                if (l.Cls.IsNotEmpty())
                {
                    sb.Append(" class=\"").Append(l.Cls).Append("\"");
                }

                if (l.StyleSpec.IsNotEmpty())
                {
                    sb.Append(" style=\"").Append(l.StyleSpec).Append("\"");
                }

                sb.Append(">");
                sb.Append(l.Text);
                sb.Append("</span>");

                return sb.ToString();
            }
            
            return l.Html.IsNotEmpty() ? l.Html : "[No Text]";
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
                    actionLists.Add(new LabelActionList(this.Component));
                }

                return actionLists;
            }
        }
    }
}
