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
using Ext.Net.Utilities;

namespace Ext.Net
{
    public partial class MaskSymbolCollection : BaseItemCollection<MaskSymbol>
    {
        public MaskSymbolCollection() { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToJson()
        {
            if (this.Count == 0)
            {
                return "{}";
            }

            StringBuilder sb = new StringBuilder(256);
            sb.Append("{");
            bool removeComma = false;

            foreach (MaskSymbol symbol in this)
            {
                if (symbol.Name.IsEmpty())
                {
                    throw new Exception("Name property is required for MaskSymbol");
                }

                if (symbol.Regex.IsEmpty())
                {
                    throw new Exception("Regex property is required for MaskSymbol");
                }

                if (symbol.Placeholder == char.MinValue)
                {
                    sb.AppendFormat("{0}:{1},", JSON.Serialize(symbol.Name), JSON.Serialize(symbol.Regex));
                }
                else
                {
                    sb.AppendFormat("{0}:{{regex:{1},placeholder:{2}}},", JSON.Serialize(symbol.Name), JSON.Serialize(symbol.Regex), JSON.Serialize(symbol.Placeholder));
                }
                
                removeComma = true;
            }

            if (removeComma)
            {
                sb.Remove(sb.Length - 1, 1);
            }

            sb.Append("}");

            return sb.ToString();
        }
    }
}