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
using Ext.Net.Utilities;

namespace Ext.Net.MVC
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
    public abstract class AbstractValidationAttribute : Attribute, IMetadataAware
    {
        public const string KEY = "__ext.net.storevalidation";

        public AbstractValidationAttribute()
        {
        }

        /// <summary>
        /// The name of the field to validate
        /// </summary>
        [DefaultValue(null)]
        public virtual string Field
        {
            get;
            set;
        }

        /// <summary>
        /// The error message used when a validation fails
        /// </summary>
        [DefaultValue(null)]
        public virtual string Message
        {
            get;
            set;
        }

        protected abstract AbstractValidation CreateValidation();

        public void OnMetadataCreated(ModelMetadata metadata)
        {
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata");
            }

            var validation = this.CreateValidation();
            validation.Message = this.Message;
            if(this.Field.IsEmpty())
            {
                validation.Field = metadata.PropertyName;
            }

            if (!metadata.AdditionalValues.ContainsKey(AbstractValidationAttribute.KEY))
            {
                metadata.AdditionalValues[AbstractValidationAttribute.KEY] = new ValidationCollection();
            }

            var collection = (ValidationCollection)metadata.AdditionalValues[AbstractValidationAttribute.KEY];
            collection.Add(validation);
        }   
    }
}