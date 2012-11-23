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
    public partial class ImageCommandColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TImageCommandColumn, TBuilder> : CellCommandColumn.Builder<TImageCommandColumn, TBuilder>
            where TImageCommandColumn : ImageCommandColumn
            where TBuilder : Builder<TImageCommandColumn, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="commands"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GroupCommands(params GroupImageCommand[] commands)
            {
                this.ToComponent().GroupCommands.AddRange(commands);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="commands"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GroupCommands(IEnumerable<GroupImageCommand> commands)
            {
                this.ToComponent().GroupCommands.AddRange(commands);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="handler"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder PrepareGroupCommand(string handler)
            {
                if (JFunction.IsFunctionName(handler))
                {
                    this.ToComponent().PrepareGroupCommand.Fn = handler;
                }
                else
                {
                    this.ToComponent().PrepareGroupCommand.Handler = handler;
                }

                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="handler"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder PrepareGroupCommands(string handler)
            {
                if (JFunction.IsFunctionName(handler))
                {
                    this.ToComponent().PrepareGroupCommands.Fn = handler;
                }
                else
                {
                    this.ToComponent().PrepareGroupCommands.Handler = handler;
                }

                return this as TBuilder;
            }
        }
    }
}