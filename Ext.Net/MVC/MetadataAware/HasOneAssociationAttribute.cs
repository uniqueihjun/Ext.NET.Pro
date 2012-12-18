/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;

namespace Ext.Net.MVC
{
    public partial class HasOneAssociationAttribute : AbstractAssociationAttribute
    {
        /// <summary>
        /// The name of the foreign key on the owner model that links it to the associated model. Defaults to the lowercased name of the associated model plus "_id"
        /// </summary>
        [DefaultValue(null)]
        public virtual string ForeignKey
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the getter function that will be added to the local model's prototype. Defaults to 'get' + the name of the foreign model, e.g. getAddress
        /// </summary>
        [DefaultValue(null)]
        public virtual string GetterName
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the setter function that will be added to the local model's prototype. Defaults to 'set' + the name of the foreign model, e.g. setAddress
        /// </summary>
        [DefaultValue(null)]
        public virtual string SetterName
        {
            get;
            set;
        }       
        
        protected override AbstractAssociation CreateAssociation()
        {
            return new HasOneAssociation { ForeignKey = this.ForeignKey, GetterName = this.GetterName, SetterName = this.SetterName };
        }
    }
}