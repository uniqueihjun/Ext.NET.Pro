/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.IO;
using System.Text;

using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class DragDropGroups : BaseItemCollection<DragDropGroup>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool this[string name]
        {
            get
            {
                foreach (DragDropGroup group in this)
                {
                    if (group.Name == name)
                    {
                        return group.Allow;
                    }
                }

                throw new Exception("Group was not found");
            }
            set
            {
                foreach (DragDropGroup group in this)
                {
                    if (group.Name == name)
                    {
                        group.Allow = value;
                        return;
                    }
                }

                this.Add(new DragDropGroup(name, value));
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DragDropGroup GetGroup(string name)
        {
            foreach (DragDropGroup group in this)
            {
                if (group.Name == name)
                {
                    return group;
                }
            }

            return null;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            if (this.Count == 0)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            JsonTextWriter writer = new JsonTextWriter(sw);

            writer.WriteStartObject();

            foreach (DragDropGroup group in this)
            {
                writer.WritePropertyName(group.Name);
                writer.WriteValue(group.Allow);
            }

            writer.WriteEndObject();
            writer.Flush();

            return sw.GetStringBuilder().ToString();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class DragDropGroup : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public DragDropGroup()
        {
        }

        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DragDropGroup(string name, bool allow)
        {
            this.Name = name;
            this.Allow = allow;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [Description("")]
        public string Name
        {
            get
            {
                return this.State.Get<string>("Name", "");
            }
            set
            {
                this.State.Set("Name", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [Description("")]
        public bool Allow
        {
            get
            {
                return this.State.Get<bool>("Allow", true);
            }
            set
            {
                this.State.Set("Allow", value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            return this.Name.ConcatWith(":", JSON.Serialize(this.Allow));
        }
    }
}