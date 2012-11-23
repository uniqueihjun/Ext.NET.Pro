/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Text;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class TreeNodeUIProvider : StateManagedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Description("")]
        public virtual string Alias
        {
            get
            {
                return (string)this.ViewState["Alias"] ?? "";
            }
            set
            {
                this.ViewState["Alias"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [Meta]
        [Description("")]
        public virtual string ClassName
        {
            get
            {
                return (string)this.ViewState["ClassName"] ?? "";
            }
            set
            {
                this.ViewState["ClassName"] = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class TreeNodeUIProviders : StateManagedCollection<TreeNodeUIProvider>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ToScript()
        {
            if (this.Count == 0)
            {
                return "{}";
            }

            StringBuilder sb = new StringBuilder(256);
            
            sb.Append("{");
            
            bool removeComma = false;

            foreach (TreeNodeUIProvider uiProvider in this)
            {
                sb.AppendFormat("{0}:{1},", uiProvider.Alias, uiProvider.ClassName);
                removeComma = true;
            }
            
            if (removeComma)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            
            sb.Append("}");

            return sb.ToString();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            return this.ToScript();
        }
    }
}