/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.ComponentModel.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ResourceManagerDesigner : ExtControlDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string XGetDesignTimeHtml()
        {
            if (((ResourceManager)this.Control).HideInDesign)
            {
                return base.XGetDesignTimeHtml();
            }

            return base.XGetDesignTimeHtml() + base.CreatePlaceHolderDesignTimeHtml(this.Message);
        }

        private string Message
        {
            get
            {
                ResourceManager sm = (ResourceManager)this.Control;

                string url = this.GetWebResourceUrl("Ext.Net.Build.Images.logo.gif");
                string template = 
                @"<table style=""margin: 8px;"">
                    <tr>
                        <th style=""font-weight:bold;"" width=""125"">Theme</th>
                        <td width=""100"">{0}</td>
                    </tr>
                    <tr>
                        <th style=""font-weight:bold;"">Adapter</th>
                        <td>{1}</td>
                    </tr>
                    <tr>
                        <th style=""font-weight:bold;"">Script Mode</th>
                        <td>{2}</td>
                    </tr>
                    <tr>
                        <td style=""text-alight:right;"" colspan=""2""><img src=""{3}"" /></td>
                    </tr>
                </table>";

                return string.Format(template, sm.Theme.ToString(), sm.ScriptAdapter.ToString(), sm.ScriptMode.ToString(), url);
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
                    actionLists.Add(new ResourceManagerActionList(this.Component));
                }

                return actionLists;
            }
        }
    }
}