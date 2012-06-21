/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A generic Plugin.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [ToolboxData("<{0}:GenericPlugin runat=\"server\" />")]
    [Description("A generic Plugin.")]
    public partial class GenericPlugin : Plugin
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public GenericPlugin() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public GenericPlugin(string instanceName, string path)
        {
            this.InstanceName = instanceName;
            this.Path = path;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return this.InstanceName;
            }
        }

        /// <summary>
        /// The JavaScript class name. Used to create a 'new' instance of the object.
        /// </summary>
        [Meta]
        [Category("3. GenericPlugin")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The JavaScript class name. Used to create a 'new' instance of the object.")]
        public virtual string InstanceName
        {
            get
            {
                return this.State.Get<string>("InstanceName", "");
            }
            set
            {
                this.State.Set("InstanceName", value);
            }
        }

        /// <summary>
        /// The file path to the required JavaScript file.
        /// </summary>
        [Meta]
        [Category("3. GenericPlugin")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The file path to the required JavaScript file.")]
        public virtual string Path
        {
            get
            {
                return this.State.Get<string>("Path", "");
            }
            set
            {
                this.State.Set("Path", value);
            }
        }
    }
}