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
    public abstract partial class TreeStoreBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTreeStoreBase, TBuilder> : AbstractStore.Builder<TTreeStoreBase, TBuilder>
            where TTreeStoreBase : TreeStoreBase
            where TBuilder : Builder<TTreeStoreBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTreeStoreBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Remove previously existing child nodes before loading. Default to true.
			/// </summary>
            public virtual TBuilder ClearOnLoad(bool clearOnLoad)
            {
                this.ToComponent().ClearOnLoad = clearOnLoad;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The default root id. Defaults to 'root'
			/// </summary>
            public virtual TBuilder DefaultRootId(string defaultRootId)
            {
                this.ToComponent().DefaultRootId = defaultRootId;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The default root text (if not specified). Defaults to: \"Root\"
			/// </summary>
            public virtual TBuilder DefaultRootText(string defaultRootText)
            {
                this.ToComponent().DefaultRootText = defaultRootText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The root property to specify on the reader if one is not explicitly defined.
			/// </summary>
            public virtual TBuilder DefaultRootProperty(string defaultRootProperty)
            {
                this.ToComponent().DefaultRootProperty = defaultRootProperty;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The root property to specify on the reader if one is not explicitly defined.
			/// </summary>
            public virtual TBuilder FolderSort(bool? folderSort)
            {
                this.ToComponent().FolderSort = folderSort;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The name of the parameter sent to the server which contains the identifier of the node. Defaults to 'node'.
			/// </summary>
            public virtual TBuilder NodeParam(string nodeParam)
            {
                this.ToComponent().NodeParam = nodeParam;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The root node for the tree.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Root(Action<NodeCollection> action)
            {
                action(this.ToComponent().Root);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DataSource(object dataSource)
            {
                this.ToComponent().DataSource = dataSource;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DataSourceID(string dataSourceID)
            {
                this.ToComponent().DataSourceID = dataSourceID;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DataBindings(Action<NodeBindingCollection> action)
            {
                action(this.ToComponent().DataBindings);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}