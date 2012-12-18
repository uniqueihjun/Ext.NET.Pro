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
    public partial class HasManyAssociation
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public HasManyAssociation(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit HasManyAssociation.Config Conversion to HasManyAssociation
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HasManyAssociation(HasManyAssociation.Config config)
        {
            return new HasManyAssociation(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractAssociation.Config 
        { 
			/*  Implicit HasManyAssociation.Config Conversion to HasManyAssociation.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator HasManyAssociation.Builder(HasManyAssociation.Config config)
			{
				return new HasManyAssociation.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool autoLoad = false;

			/// <summary>
			/// True to automatically load the related store from a remote source when instantiated. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AutoLoad 
			{ 
				get
				{
					return this.autoLoad;
				}
				set
				{
					this.autoLoad = value;
				}
			}

			private string filterProperty = null;

			/// <summary>
			/// Optionally overrides the default filter that is set up on the associated Store. If this is not set, a filter is automatically created which filters the association based on the configured foreignKey. See intro docs for more details. Defaults to undefined
			/// </summary>
			[DefaultValue(null)]
			public virtual string FilterProperty 
			{ 
				get
				{
					return this.filterProperty;
				}
				set
				{
					this.filterProperty = value;
				}
			}

			private string foreignKey = null;

			/// <summary>
			/// The name of the foreign key on the associated model that links it to the owner model. Defaults to the lowercased name of the owner model plus \"_id\", e.g. an association with a where a model called Group hasMany Users would create 'group_id' as the foreign key.
			/// </summary>
			[DefaultValue(null)]
			public virtual string ForeignKey 
			{ 
				get
				{
					return this.foreignKey;
				}
				set
				{
					this.foreignKey = value;
				}
			}

			private string name = null;

			/// <summary>
			/// The name of the function to create on the owner model to retrieve the child store. If not specified, the pluralized name of the child model is used.
			/// </summary>
			[DefaultValue(null)]
			public virtual string Name 
			{ 
				get
				{
					return this.name;
				}
				set
				{
					this.name = value;
				}
			}
        
			private Store storeConfig = null;

			/// <summary>
			/// Optional configuration object that will be passed to the generated Store. Defaults to undefined.
			/// </summary>
			public Store StoreConfig
			{
				get
				{
					if (this.storeConfig == null)
					{
						this.storeConfig = new Store();
					}
			
					return this.storeConfig;
				}
			}
			
        }
    }
}