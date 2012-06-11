/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
    internal class FieldInModel
    {
        private bool inModel;
        private List<ModelField> fields;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public FieldInModel(bool inModel, List<ModelField> fields)
        {
            this.inModel = inModel;
            this.fields = fields;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool InModel
        {
            get { return inModel; }
            set { inModel = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public List<ModelField> Fields
        {
            get { return fields; }
            set { fields = value; }
        }
    }
}
