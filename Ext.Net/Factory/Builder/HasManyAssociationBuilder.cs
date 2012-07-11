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
    public partial class HasManyAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractAssociation.Builder<HasManyAssociation, HasManyAssociation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HasManyAssociation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HasManyAssociation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HasManyAssociation.Config config) : base(new HasManyAssociation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HasManyAssociation component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to automatically load the related store from a remote source when instantiated. Defaults to false.
			/// </summary>
            public virtual HasManyAssociation.Builder AutoLoad(bool autoLoad)
            {
                this.ToComponent().AutoLoad = autoLoad;
                return this as HasManyAssociation.Builder;
            }
             
 			/// <summary>
			/// Optionally overrides the default filter that is set up on the associated Store. If this is not set, a filter is automatically created which filters the association based on the configured foreignKey. See intro docs for more details. Defaults to undefined
			/// </summary>
            public virtual HasManyAssociation.Builder FilterProperty(string filterProperty)
            {
                this.ToComponent().FilterProperty = filterProperty;
                return this as HasManyAssociation.Builder;
            }
             
 			/// <summary>
			/// The name of the foreign key on the associated model that links it to the owner model. Defaults to the lowercased name of the owner model plus \"_id\", e.g. an association with a where a model called Group hasMany Users would create 'group_id' as the foreign key.
			/// </summary>
            public virtual HasManyAssociation.Builder ForeignKey(string foreignKey)
            {
                this.ToComponent().ForeignKey = foreignKey;
                return this as HasManyAssociation.Builder;
            }
             
 			/// <summary>
			/// The name of the function to create on the owner model to retrieve the child store. If not specified, the pluralized name of the child model is used.
			/// </summary>
            public virtual HasManyAssociation.Builder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as HasManyAssociation.Builder;
            }
             
 			/// <summary>
			/// Optional configuration object that will be passed to the generated Store. Defaults to undefined.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of HasManyAssociation.Builder</returns>
            public virtual HasManyAssociation.Builder StoreConfig(Action<ParameterCollection> action)
            {
                action(this.ToComponent().StoreConfig);
                return this as HasManyAssociation.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public HasManyAssociation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HasManyAssociation(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public HasManyAssociation.Builder HasManyAssociation()
        {
            return this.HasManyAssociation(new HasManyAssociation());
        }

        /// <summary>
        /// 
        /// </summary>
        public HasManyAssociation.Builder HasManyAssociation(HasManyAssociation component)
        {
            return new HasManyAssociation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HasManyAssociation.Builder HasManyAssociation(HasManyAssociation.Config config)
        {
            return new HasManyAssociation.Builder(new HasManyAssociation(config));
        }
    }
}