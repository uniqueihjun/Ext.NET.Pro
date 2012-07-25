/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public class RemoteMoveEventArgs : RemoteActionEventArgs
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public RemoteMoveEventArgs(string serviceParams, ParameterCollection extraParams) : base(serviceParams, extraParams) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DropPoint Point
        {
            get
            {
                string point = this.GetValue<string>("point");
                return (DropPoint)Enum.Parse(typeof(DropPoint), point, true);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string TargetNodeID
        {
            get
            {
                return this.GetValue<string>("targetId");
            }
        }

        public List<string> Nodes
        {
            get
            {
                if (this.ServiceParams == null)
                {
                    return new List<string>(0);
                }

                JProperty p = this.ServiceParams.Property("ids");

                if (p == null || p.Value == null)
                {
                    return new List<string>(0);
                }

                var nodes = (JArray)p.Value;
                var list = new List<string>(nodes.Count);
                for (int i = 0; i < nodes.Count; i++)
			    {
                    list.Add(nodes[i].Value<string>());
			    }

                return list;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override string NodeID
        {
            get
            {
                return this.GetValue<string>("id");
            }
        }
    }
}