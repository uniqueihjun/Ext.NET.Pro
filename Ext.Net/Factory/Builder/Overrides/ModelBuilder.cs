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

namespace Ext.Net
{
    public partial class Model
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Model.Builder<Model, Model.Builder>
        {
            public virtual Model.Builder Fields(params ModelField[] fields)
            {
                this.ToComponent().Fields.AddRange(fields);
                return this as Model.Builder;
            }

            public virtual Model.Builder Fields(IEnumerable<ModelField> fields)
            {
                this.ToComponent().Fields.AddRange(fields);
                return this as Model.Builder;
            }

            public virtual Model.Builder Fields(params string[] fieldNames)
            {
                this.ToComponent().Fields.Add(fieldNames);
                return this as Model.Builder;
            }

            public virtual Model.Builder Fields(string fieldName, ModelFieldType type)
            {
                this.ToComponent().Fields.Add(fieldName, type);
                return this as Model.Builder;
            }

            public virtual Model.Builder Fields(string fieldName, ModelFieldType type, string dateFormat)
            {
                this.ToComponent().Fields.Add(fieldName, type, dateFormat);
                return this as Model.Builder;
            }
        }
    }
}