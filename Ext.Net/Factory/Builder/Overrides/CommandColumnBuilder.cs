/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CommandColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCommandColumn, TBuilder> : ColumnBase.Builder<TCommandColumn, TBuilder>
            where TCommandColumn : CommandColumn
            where TBuilder : Builder<TCommandColumn, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="commands"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Commands(params GridCommandBase[] commands)
            {
                this.ToComponent().Commands.AddRange(commands);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="commands"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Commands(IEnumerable<GridCommandBase> commands)
            {
                this.ToComponent().Commands.AddRange(commands);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="commands"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GroupCommands(params GridCommandBase[] commands)
            {
                this.ToComponent().GroupCommands.AddRange(commands);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="commands"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GroupCommands(IEnumerable<GridCommandBase> commands)
            {
                this.ToComponent().GroupCommands.AddRange(commands);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="handler"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder PrepareToolbar(string handler)
            {
                if(JFunction.IsFunctionName(handler))
                {
                    this.ToComponent().PrepareToolbar.Fn = handler;
                }
                else
                {
                    this.ToComponent().PrepareToolbar.Handler = handler;
                }
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="handler"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder PrepareGroupToolbar(string handler)
            {
                if(JFunction.IsFunctionName(handler))
                {
                    this.ToComponent().PrepareGroupToolbar.Fn = handler;
                }
                else
                {
                    this.ToComponent().PrepareGroupToolbar.Handler = handler;
                }
                return this as TBuilder;
            }
        }
    }
}