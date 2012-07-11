/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class HiddenFieldActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public HiddenFieldActionList(IComponent component) : base(component) { }
        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual string Value
        {
            get
            {
                return (string)((Hidden)this.Control).Value;
            }
            set
            {
                this.GetPropertyByName("Value").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool HideInDesign
        {
            get
            {
                return ((Hidden)this.Control).HideInDesign;
            }
            set
            {
                this.GetPropertyByName("HideInDesign").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddPropertyItem(new DesignerActionPropertyItem("Value", "Value", "500", "Set the Value of this Hidden"));
            this.AddPropertyItem(new DesignerActionPropertyItem("HideInDesign", "Hide", "500", "Hide this control at Design Time"));

            return base.GetSortedActionItems();
        }
    }
}