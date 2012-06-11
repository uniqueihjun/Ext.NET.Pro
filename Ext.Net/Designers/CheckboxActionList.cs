/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class CheckboxActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CheckboxActionList(IComponent component) : base(component) { }
        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual bool Checked
        {
            get
            {
                return ((Checkbox)this.Control).Checked;
            }
            set
            {
                this.GetPropertyByName("Checked").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddPropertyItem(new DesignerActionPropertyItem("Checked", "Checked", "500", "Change the Checkbox to Checked"));
    
            return base.GetSortedActionItems();
        }
    }
}