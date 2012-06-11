/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class NodeBindingCollection : BaseItemCollection<NodeBinding> 
    { 
        private NodeBinding defaultBinding;
 
        /// <summary>
        /// 
        /// </summary>
        public NodeBindingCollection() 
        {
            this.AfterItemAdd += this.ResetDefaultBinding;
            this.AfterItemRemove += this.ResetDefaultBinding;
        }

        private void ResetDefaultBinding(NodeBinding item)
        {
            this.defaultBinding = null;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual NodeBinding DefaultBinding
        {
            get
            {
                if (this.defaultBinding != null)
                {
                    return this.defaultBinding;
                }

                foreach (NodeBinding binding in this)
                {
                    if (binding.Depth == -1 && binding.DataMember.Length == 0)
                    {
                        this.defaultBinding = binding;
                        break;
                    }
                }

                return this.defaultBinding;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataMember"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public virtual NodeBinding GetBinding(string dataMember, int depth) {
            NodeBinding matchBinding = null; 
            int match = 0;
            if ((dataMember != null) && (dataMember.Length == 0)) {
                dataMember = null;
            } 

            foreach (NodeBinding binding in this) { 
                if ((binding.Depth == depth)) { 
                    if (String.Equals(binding.DataMember, dataMember, StringComparison.CurrentCultureIgnoreCase)) {
                        return binding; 
                    }
                    else if ((match < 1) && (binding.DataMember.Length == 0)) {
                        matchBinding = binding;
                        match = 1; 
                    }
                } 
                else if (String.Equals(binding.DataMember, dataMember, StringComparison.CurrentCultureIgnoreCase) && 
                         (match < 2) &&
                         (binding.Depth == -1)) {

                    matchBinding = binding;
                    match = 2;
                } 
            }

            return matchBinding != null ? matchBinding : this.DefaultBinding; 
        }
    }
} 

