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
    public partial class Model
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<Model, Model.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Model()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Model component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Model.Config config) : base(new Model(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Model component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The model name. Required
			/// </summary>
            public virtual Model.Builder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as Model.Builder;
            }
             
 			/// <summary>
			/// One or more BelongsTo associationa for this model.
			/// </summary>
            public virtual Model.Builder BelongsTo(string belongsTo)
            {
                this.ToComponent().BelongsTo = belongsTo;
                return this as Model.Builder;
            }
             
 			/// <summary>
			/// One or more HasMany associations for this model.
			/// </summary>
            public virtual Model.Builder HasMany(string hasMany)
            {
                this.ToComponent().HasMany = hasMany;
                return this as Model.Builder;
            }
             
 			/// <summary>
			/// The name of a property that is used for submitting this Model's unique client-side identifier to the server when multiple phantom records are saved
			/// </summary>
            public virtual Model.Builder ClientIdProperty(string clientIdProperty)
            {
                this.ToComponent().ClientIdProperty = clientIdProperty;
                return this as Model.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Model.Builder Extend(string extend)
            {
                this.ToComponent().Extend = extend;
                return this as Model.Builder;
            }
             
 			/// <summary>
			/// An array of fields definition objects
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Model.Builder</returns>
            public virtual Model.Builder Fields(Action<ModelFieldCollection> action)
            {
                action(this.ToComponent().Fields);
                return this as Model.Builder;
            }
			 
 			/// <summary>
			/// The name of the field treated as this Model's unique id (defaults to 'id').
			/// </summary>
            public virtual Model.Builder IDProperty(string iDProperty)
            {
                this.ToComponent().IDProperty = iDProperty;
                return this as Model.Builder;
            }
             
 			/// <summary>
			/// The Proxy object which provides access to a data object.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Model.Builder</returns>
            public virtual Model.Builder Proxy(Action<ProxyCollection> action)
            {
                action(this.ToComponent().Proxy);
                return this as Model.Builder;
            }
			 
 			/// <summary>
			/// Models associations
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Model.Builder</returns>
            public virtual Model.Builder Associations(Action<AssociationCollection> action)
            {
                action(this.ToComponent().Associations);
                return this as Model.Builder;
            }
			 
 			/// <summary>
			/// Models validations
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Model.Builder</returns>
            public virtual Model.Builder Validations(Action<ValidationCollection> action)
            {
                action(this.ToComponent().Validations);
                return this as Model.Builder;
            }
			 
 			/// <summary>
			/// The id generator to use for this model. The default id generator does not generate values for the idProperty.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Model.Builder</returns>
            public virtual Model.Builder IDGen(Action<ModelIdGeneratorCollection> action)
            {
                action(this.ToComponent().IDGen);
                return this as Model.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Model.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Model(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Model.Builder Model()
        {
            return this.Model(new Model());
        }

        /// <summary>
        /// 
        /// </summary>
        public Model.Builder Model(Model component)
        {
            return new Model.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Model.Builder Model(Model.Config config)
        {
            return new Model.Builder(new Model(config));
        }
    }
}