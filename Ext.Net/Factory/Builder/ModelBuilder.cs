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
    public partial class Model
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TModel, TBuilder> : Observable.Builder<TModel, TBuilder>
            where TModel : Model
            where TBuilder : Builder<TModel, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TModel component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The model name. Required
			/// </summary>
            public virtual TBuilder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// One or more BelongsTo associationa for this model.
			/// </summary>
            public virtual TBuilder BelongsTo(string belongsTo)
            {
                this.ToComponent().BelongsTo = belongsTo;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// One or more HasMany associations for this model.
			/// </summary>
            public virtual TBuilder HasMany(string hasMany)
            {
                this.ToComponent().HasMany = hasMany;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The name of a property that is used for submitting this Model's unique client-side identifier to the server when multiple phantom records are saved
			/// </summary>
            public virtual TBuilder ClientIdProperty(string clientIdProperty)
            {
                this.ToComponent().ClientIdProperty = clientIdProperty;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Extend(string extend)
            {
                this.ToComponent().Extend = extend;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// An array of fields definition objects
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Fields(Action<ModelFieldCollection> action)
            {
                action(this.ToComponent().Fields);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// The name of the field treated as this Model's unique id (defaults to 'id').
			/// </summary>
            public virtual TBuilder IDProperty(string iDProperty)
            {
                this.ToComponent().IDProperty = iDProperty;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The Proxy object which provides access to a data object.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Proxy(Action<ProxyCollection> action)
            {
                action(this.ToComponent().Proxy);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Models associations
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Associations(Action<AssociationCollection> action)
            {
                action(this.ToComponent().Associations);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Models validations
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Validations(Action<ValidationCollection> action)
            {
                action(this.ToComponent().Validations);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// The id generator to use for this model. The default id generator does not generate values for the idProperty.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder IDGen(Action<ModelIdGeneratorCollection> action)
            {
                action(this.ToComponent().IDGen);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : Model.Builder<Model, Model.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public Model.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Model(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.Model(new Model { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.Model(new Model());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public Model.Builder Model(Model component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new Model.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Model.Builder Model(Model.Config config)
        {
#if MVC
			return new Model.Builder(new Model(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new Model.Builder(new Model(config));
#endif			
        }
    }
}