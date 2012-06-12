/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Web.UI;
using System.Web.UI.Design;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ResourcePlaceHolderDesigner : ExtControlDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string XGetDesignTimeHtml()
        {
            if (this.Control.Parent != this.Control.Page.Header)
            {
                throw new Exception("Please place the &lt;ext:ResourceContainer&gt; into the &lt;head&gt; of this Page.");
            }

            return "";
        }
    }
}