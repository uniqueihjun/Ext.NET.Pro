/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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

        private List<string> nodesList;
        public List<string> Nodes
        {
            get
            {
                if (this.nodesList != null)
                {
                    return this.nodesList;
                }
                
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
                nodesList = new List<string>(nodes.Count);
                for (int i = 0; i < nodes.Count; i++)
			    {
                    nodesList.Add(nodes[i].Value<string>());
			    }

                return nodesList;
            }
        }

        private List<string> parentNodesList;
        public List<string> ParentNodes
        {
            get
            {
                if (this.parentNodesList != null)
                {
                    return this.parentNodesList;
                }

                if (this.ServiceParams == null)
                {
                    return new List<string>(0);
                }

                JProperty p = this.ServiceParams.Property("parentIds");

                if (p == null || p.Value == null)
                {
                    return new List<string>(0);
                }

                var nodes = (JArray)p.Value;
                this.parentNodesList = new List<string>(nodes.Count);
                for (int i = 0; i < nodes.Count; i++)
                {
                    this.parentNodesList.Add(nodes[i].Value<string>());
                }

                return this.parentNodesList;
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
                return this.Nodes.Count > 0 ? this.Nodes[0] : null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual string ParentNodeID
        {
            get
            {
                return this.ParentNodes.Count > 0 ? this.ParentNodes[0] : null;
            }
        }
    }
}