/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    [Meta]
    public partial class ImageCommand : ImageCommandBase 
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageCommand()
        {
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ImageCommandCollection : BaseItemCollection<ImageCommand> { }
}