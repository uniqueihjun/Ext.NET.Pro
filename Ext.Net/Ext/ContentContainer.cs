/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI.HtmlControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Browsable(false)]
    [ToolboxItem(false)]
    public partial class ContentContainer : HtmlGenericControl
    {
        /// <summary>
        /// 
        /// </summary>
        public ContentContainer() : base("div")            
        {              
        }
    }
}