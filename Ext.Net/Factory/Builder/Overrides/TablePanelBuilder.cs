/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public abstract partial class TablePanel
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTablePanel, TBuilder> : AbstractPanel.Builder<TTablePanel, TBuilder>
            where TTablePanel : TablePanel
            where TBuilder : Builder<TTablePanel, TBuilder>
        {
            /// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ColumnModel(IEnumerable<ColumnBase> columns)
            {
                this.ToComponent().ColumnModel.Columns.AddRange(columns);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder ColumnModel(params ColumnBase[] columns)
            {
                this.ToComponent().ColumnModel.Columns.AddRange(columns);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder ColumnModel(ColumnBase column)
            {
                this.ToComponent().ColumnModel.Columns.Add(column);
                return this as TBuilder;
            }

            /// <summary>
            /// Any subclass of AbstractSelectionModel that will provide the selection model for the grid (defaults to Ext.grid.RowSelectionModel if not specified).
            /// </summary>
            /// <param name="sm">sm</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder SelectionModel(AbstractSelectionModel sm)
            {
                this.ToComponent().SelectionModel.Add(sm);
                return this as TBuilder;
            }

            /// <summary>
            /// (optional) The Ext.form.Field to use when editing values in columns if editing is supported by the grid.
            /// </summary>
            /// <param name="editors"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Editor(params Field[] editors)
            {
                this.ToComponent().Editor.AddRange(editors);
                return this as TBuilder;
            }

            /// <summary>
            /// (optional) The Ext.form.Field to use when editing values in columns if editing is supported by the grid.
            /// </summary>
            /// <param name="editors"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Editor(IEnumerable<Field> editors)
            {
                this.ToComponent().Editor.AddRange(editors);
                return this as TBuilder;
            }
        }        
    }
}