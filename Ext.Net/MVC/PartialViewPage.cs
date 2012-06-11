/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web.Mvc;
using System.Web.UI;

namespace Ext.Net.MVC
{
    /// <summary>
    /// 
    /// </summary>
    public class PartialViewPage : ViewPage, Ext.Net.ISelfRenderingPage
    {
        /// <summary>
        /// 
        /// </summary>
        public PartialViewPage()
        {
            this.EnableEventValidation = false;
            this.EnableViewState = false;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        public override void VerifyRenderingInServerForm(Control control)
        {
        }
    }
}
