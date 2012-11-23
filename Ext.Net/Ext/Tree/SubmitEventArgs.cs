/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class SubmitEventArgs : EventArgs
    {
        private readonly ParameterCollection extraParams;
        private readonly SubmittedNode rootNode;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SubmitEventArgs(ParameterCollection extraParams, SubmittedNode rootNode)
        {
            this.extraParams = extraParams;
            this.rootNode = rootNode;
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
        public SubmittedNode RootNode
        {
            get
            {
                return this.rootNode;
            }
        }
    }
}