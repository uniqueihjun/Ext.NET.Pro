/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class BelongsToAssociation
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public BelongsToAssociation(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit BelongsToAssociation.Config Conversion to BelongsToAssociation
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BelongsToAssociation(BelongsToAssociation.Config config)
        {
            return new BelongsToAssociation(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractAssociation.Config 
        { 
			/*  Implicit BelongsToAssociation.Config Conversion to BelongsToAssociation.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator BelongsToAssociation.Builder(BelongsToAssociation.Config config)
			{
				return new BelongsToAssociation.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string foreignKey = null;

			/// <summary>
			/// The name of the foreign key on the owner model that links it to the associated model. Defaults to the lowercased name of the associated model plus \"_id\", e.g. an association with a model called Product would set up a product_id foreign key.
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

			private string getterName = null;

			/// <summary>
			/// The name of the getter function that will be added to the local model's prototype. Defaults to 'get' + the name of the foreign model, e.g. getCategory
			/// </summary>
			[DefaultValue(null)]
			public virtual string GetterName 
			{ 
				get
				{
					return this.getterName;
				}
				set
				{
					this.getterName = value;
				}
			}

			private string setterName = null;

			/// <summary>
			/// The name of the setter function that will be added to the local model's prototype. Defaults to 'set' + the name of the foreign model, e.g. setCategory
			/// </summary>
			[DefaultValue(null)]
			public virtual string SetterName 
			{ 
				get
				{
					return this.setterName;
				}
				set
				{
					this.setterName = value;
				}
			}

        }
    }
}