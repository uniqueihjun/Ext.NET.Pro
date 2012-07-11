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
    public abstract partial class AbstractAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TAbstractAssociation, TBuilder> : BaseItem.Builder<TAbstractAssociation, TBuilder>
            where TAbstractAssociation : AbstractAssociation
            where TBuilder : Builder<TAbstractAssociation, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAbstractAssociation component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The name of the property in the data to read the association from. Defaults to the name of the associated model.
			/// </summary>
            public virtual TBuilder AssociationKey(string associationKey)
            {
                this.ToComponent().AssociationKey = associationKey;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The name of the primary key on the associated model.  In general this will be the Ext.data.Model.idProperty of the Model. Defaults to 'id'
			/// </summary>
            public virtual TBuilder PrimaryKey(string primaryKey)
            {
                this.ToComponent().PrimaryKey = primaryKey;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The string name of the model that is being associated with. Required
			/// </summary>
            public virtual TBuilder Model(string model)
            {
                this.ToComponent().Model = model;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A special reader to read associated data
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Reader(Action<ReaderCollection> action)
            {
                action(this.ToComponent().Reader);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}