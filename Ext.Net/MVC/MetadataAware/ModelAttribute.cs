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
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
    public partial class ModelAttribute : Attribute, IMetadataAware
    {
        public const string KEY = "__ext.net.model";

        public void OnMetadataCreated(ModelMetadata metadata)
        {
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata");
            }

            metadata.AdditionalValues[ModelAttribute.KEY] = this;
        }

        public void CopyTo(Model model)
        {
            model.Apply(this);
        }

        /// <summary>
        /// The model name. Required
        /// </summary>
        [DefaultValue(null)]
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// One or more BelongsTo associationa for this model.
        /// </summary>
        [DefaultValue(null)]
        public virtual string BelongsTo
        {
            get;
            set;
        }

        /// <summary>
        /// One or more HasMany associations for this model.
        /// </summary>
        [DefaultValue(null)]
        public virtual string HasMany
        {
            get;
            set;
        }

        /// <summary>
        /// The name of a property that is used for submitting this Model's unique client-side identifier to the server when multiple phantom records are saved as part of the same Operation. In such a case, the server response should include the client id for each record so that the server response data can be used to update the client-side records if necessary.
        /// This property cannot have the same name as any of this Model's fields. 
        /// </summary>
        [DefaultValue(null)]
        public virtual string ClientIdProperty
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        public virtual string Extend
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the field treated as this Model's unique id (defaults to 'id').
        /// </summary>
        [DefaultValue(null)]
        public virtual string IDProperty
        {
            get;
            set;
        }
    }
}