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
using Ext.Net.Utilities;

namespace Ext.Net.MVC
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ClientResourceAttribute : Attribute, IMetadataAware
    {
        public const string KEY = "__ext.net.clientresource";

        /// <summary>
        /// 
        /// </summary>
        public Type Type
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PathEmbedded
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Path
        {
            get;
            set;
        }

        public bool IsCss
        {
            get;
            set;
        }

        public void OnMetadataCreated(ModelMetadata metadata)
        {
            ClientResourceItem item;
            if (this.PathEmbedded.IsNotEmpty())
            {
                if(this.Type == null)
                {
                    throw new Exception("Type cannot be null if PathEmbedded is defined");
                }
                item = new ClientResourceItem(this.Type, this.PathEmbedded, this.IsCss);
            }
            else
            {
                item = new ClientResourceItem(this.Path, this.IsCss);                
            }

            if (!metadata.AdditionalValues.ContainsKey(ClientResourceAttribute.KEY))
            {
                metadata.AdditionalValues[ClientResourceAttribute.KEY] = new ResourcesRegistrator();
            }

            var rr = (ResourcesRegistrator)metadata.AdditionalValues[ClientResourceAttribute.KEY];
            rr.ResourceItems.Add(item);
        }
    }
}