/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractAssociation.Builder<BelongsToAssociation, BelongsToAssociation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new BelongsToAssociation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BelongsToAssociation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BelongsToAssociation.Config config) : base(new BelongsToAssociation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(BelongsToAssociation component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The name of the foreign key on the owner model that links it to the associated model. Defaults to the lowercased name of the associated model plus \"_id\", e.g. an association with a model called Product would set up a product_id foreign key.
			/// </summary>
            public virtual BelongsToAssociation.Builder ForeignKey(string foreignKey)
            {
                this.ToComponent().ForeignKey = foreignKey;
                return this as BelongsToAssociation.Builder;
            }
             
 			/// <summary>
			/// The name of the getter function that will be added to the local model's prototype. Defaults to 'get' + the name of the foreign model, e.g. getCategory
			/// </summary>
            public virtual BelongsToAssociation.Builder GetterName(string getterName)
            {
                this.ToComponent().GetterName = getterName;
                return this as BelongsToAssociation.Builder;
            }
             
 			/// <summary>
			/// The name of the setter function that will be added to the local model's prototype. Defaults to 'set' + the name of the foreign model, e.g. setCategory
			/// </summary>
            public virtual BelongsToAssociation.Builder SetterName(string setterName)
            {
                this.ToComponent().SetterName = setterName;
                return this as BelongsToAssociation.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public BelongsToAssociation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.BelongsToAssociation(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public BelongsToAssociation.Builder BelongsToAssociation()
        {
            return this.BelongsToAssociation(new BelongsToAssociation());
        }

        /// <summary>
        /// 
        /// </summary>
        public BelongsToAssociation.Builder BelongsToAssociation(BelongsToAssociation component)
        {
            return new BelongsToAssociation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public BelongsToAssociation.Builder BelongsToAssociation(BelongsToAssociation.Config config)
        {
            return new BelongsToAssociation.Builder(new BelongsToAssociation(config));
        }
    }
}