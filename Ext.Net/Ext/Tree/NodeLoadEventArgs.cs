/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class NodeLoadEventArgs : EventArgs
    {
        private readonly ParameterCollection extraParams;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public NodeLoadEventArgs(ParameterCollection extraParams)
        {
            this.extraParams = extraParams;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ParameterCollection ExtraParams
        {
            get
            {
                return this.extraParams;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string NodeID
        {
            get
            {
                return this.ExtraParams["node"];
            }
        }

        private TreeNodeCollection nodes;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TreeNodeCollection Nodes
        {
            get
            {
                if (this.nodes == null)
                {
                    this.nodes = new TreeNodeCollection(false);
                }

                return this.nodes;
            }
            set
            {
                this.nodes = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Success
        {
            get { return ResourceManager.AjaxSuccess; }
            set { ResourceManager.AjaxSuccess = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ErrorMessage
        {
            get { return ResourceManager.AjaxErrorMessage; }
            set { ResourceManager.AjaxErrorMessage = value; }
        }
    }
}