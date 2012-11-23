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
        new public abstract partial class Config : AbstractStore.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool clearOnLoad = true;

			/// <summary>
			/// Remove previously existing child nodes before loading. Default to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ClearOnLoad 
			{ 
				get
				{
					return this.clearOnLoad;
				}
				set
				{
					this.clearOnLoad = value;
				}
			}

			private string defaultRootId = "root";

			/// <summary>
			/// The default root id. Defaults to 'root'
			/// </summary>
			[DefaultValue("root")]
			public virtual string DefaultRootId 
			{ 
				get
				{
					return this.defaultRootId;
				}
				set
				{
					this.defaultRootId = value;
				}
			}

			private string defaultRootText = "Root";

			/// <summary>
			/// The default root text (if not specified). Defaults to: \"Root\"
			/// </summary>
			[DefaultValue("Root")]
			public virtual string DefaultRootText 
			{ 
				get
				{
					return this.defaultRootText;
				}
				set
				{
					this.defaultRootText = value;
				}
			}

			private string defaultRootProperty = "";

			/// <summary>
			/// The root property to specify on the reader if one is not explicitly defined.
			/// </summary>
			[DefaultValue("")]
			public virtual string DefaultRootProperty 
			{ 
				get
				{
					return this.defaultRootProperty;
				}
				set
				{
					this.defaultRootProperty = value;
				}
			}

			private bool? folderSort = null;

			/// <summary>
			/// The root property to specify on the reader if one is not explicitly defined.
			/// </summary>
			[DefaultValue(null)]
			public virtual bool? FolderSort 
			{ 
				get
				{
					return this.folderSort;
				}
				set
				{
					this.folderSort = value;
				}
			}

			private string nodeParam = "node";

			/// <summary>
			/// The name of the parameter sent to the server which contains the identifier of the node. Defaults to 'node'.
			/// </summary>
			[DefaultValue("node")]
			public virtual string NodeParam 
			{ 
				get
				{
					return this.nodeParam;
				}
				set
				{
					this.nodeParam = value;
				}
			}
        
			private NodeCollection root = null;

			/// <summary>
			/// The root node for the tree.
			/// </summary>
			public NodeCollection Root
			{
				get
				{
					if (this.root == null)
					{
						this.root = new NodeCollection();
					}
			
					return this.root;
				}
			}
			
			private object dataSource = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual object DataSource 
			{ 
				get
				{
					return this.dataSource;
				}
				set
				{
					this.dataSource = value;
				}
			}

			private string dataSourceID = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string DataSourceID 
			{ 
				get
				{
					return this.dataSourceID;
				}
				set
				{
					this.dataSourceID = value;
				}
			}
        
			private NodeBindingCollection dataBindings = null;

			/// <summary>
			/// 
			/// </summary>
			public NodeBindingCollection DataBindings
			{
				get
				{
					if (this.dataBindings == null)
					{
						this.dataBindings = new NodeBindingCollection();
					}
			
					return this.dataBindings;
				}
			}
			
        }
    }
}