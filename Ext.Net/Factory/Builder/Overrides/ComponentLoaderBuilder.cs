/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Web.UI;
using System.Web;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class ComponentLoader
    {
        public partial class Builder : ComponentLoader.Builder<ComponentLoader, ComponentLoader.Builder>
        {
            public virtual ComponentLoader.Builder Params(object parameters)
            {
                this.ToComponent().Params.Add(parameters);
                return this as ComponentLoader.Builder;
            }
        }
    }
}