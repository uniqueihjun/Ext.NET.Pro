/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    public partial class GridCommand
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TGridCommand, TBuilder> : GridCommandBase.Builder<TGridCommand, TBuilder>
            where TGridCommand : GridCommand
            where TBuilder : Builder<TGridCommand, TBuilder>
        {
            public virtual TBuilder MenuItem(params MenuCommand[] items)
            {
                this.ToComponent().Menu.Items.AddRange(items);

                return this as TBuilder;
            }

            public virtual TBuilder MenuItem(IEnumerable<MenuCommand> items)
            {
                this.ToComponent().Menu.Items.AddRange(items);
                return this as TBuilder;
            }		 
        }
    }
}