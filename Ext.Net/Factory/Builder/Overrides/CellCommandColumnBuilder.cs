/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class CellCommandColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TCellCommandColumn, TBuilder> : ColumnBase.Builder<TCellCommandColumn, TBuilder>
            where TCellCommandColumn : CellCommandColumn
            where TBuilder : Builder<TCellCommandColumn, TBuilder>
        {
 			/// <summary>
 			/// 
 			/// </summary>
 			/// <param name="commands"></param>
 			/// <returns></returns>
            public virtual TBuilder Commands(params ImageCommand[] commands)
            {
                this.ToComponent().Commands.AddRange(commands);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="commands"></param>
            /// <returns></returns>
            public virtual TBuilder Commands(IEnumerable<ImageCommand> commands)
            {
                this.ToComponent().Commands.AddRange(commands);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="handler"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder PrepareCommand(string handler)
            {
                if (JFunction.IsFunctionName(handler))
                {
                    this.ToComponent().PrepareCommand.Fn = handler;
                }
                else
                {
                    this.ToComponent().PrepareCommand.Handler = handler;
                }

                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="handler"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder PrepareCommands(string handler)
            {
                if (JFunction.IsFunctionName(handler))
                {
                    this.ToComponent().PrepareCommands.Fn = handler;
                }
                else
                {
                    this.ToComponent().PrepareCommands.Handler = handler;
                }

                return this as TBuilder;
            }
        }        
    }
}