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
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ProxyAttribute : Attribute, IMetadataAware
    {
        public const string KEY = "__ext.net.storeproxy";
        private Type proxyType;
        private string sync = "";
        private string create = "";
        private string read = "";
        private string update = "";
        private string destroy = "";

        public ProxyAttribute()
        {
        }

        public ProxyAttribute(Type proxyType)
        {
            this.proxyType = proxyType;
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        public string Sync
        {
            get
            {
                return this.sync;
            }
            set
            {
                this.sync = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        public string Create
        {
            get
            {
                return this.create;
            }
            set
            {
                this.create = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        public string Read
        {
            get
            {
                return this.read;
            }
            set
            {
                this.read = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        public string Update
        {
            get
            {
                return this.update;
            }
            set
            {
                this.update = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        public string Destroy
        {
            get
            {
                return this.destroy;
            }
            set
            {
                this.destroy = value;
            }
        }       

        public void OnMetadataCreated(ModelMetadata metadata)
        {
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata");
            }

            AbstractProxy proxy = null;

            if (this.proxyType != null)
            {
                proxy = (AbstractProxy)Activator.CreateInstance(this.proxyType);
            }
            else
            {
                proxy = new AjaxProxy
                {
                    API = 
                    { 
                        Sync = this.Sync,
                        Create = this.Create,
                        Read = this.Read,
                        Update = this.Update,
                        Destroy = this.Destroy
                    }
                };
            }

            metadata.AdditionalValues[ProxyAttribute.KEY] = proxy;
        }   
    }
}