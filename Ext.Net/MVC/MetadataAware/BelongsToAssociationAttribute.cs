/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;

namespace Ext.Net.MVC
{
    public partial class BelongsToAssociationAttribute : AbstractAssociationAttribute
    {
        /// <summary>
        /// The name of the foreign key on the owner model that links it to the associated model. Defaults to the lowercased name of the associated model plus "_id", e.g. an association with a model called Product would set up a product_id foreign key.
        /// </summary>
        [DefaultValue(null)]
        public virtual string ForeignKey
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the getter function that will be added to the local model's prototype. Defaults to 'get' + the name of the foreign model, e.g. getCategory
        /// </summary>
        [DefaultValue(null)]
        public virtual string GetterName
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the setter function that will be added to the local model's prototype. Defaults to 'set' + the name of the foreign model, e.g. setCategory
        /// </summary>
        [DefaultValue(null)]
        public virtual string SetterName
        {
            get;
            set;
        }
        
        protected override AbstractAssociation CreateAssociation()
        {
            return new BelongsToAssociation { ForeignKey = this.ForeignKey, GetterName = this.GetterName, SetterName = this.SetterName };
        }
    }
}