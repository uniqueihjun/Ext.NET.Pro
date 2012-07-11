/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ToolsCollectionBuilder<TParent, TParentBuilder>
         : ComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : PanelBase
        where TParentBuilder : PanelBase.Builder<TParent, TParentBuilder>
    {
        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        public ToolsCollectionBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        //public virtual ToolsCollectionBuilder<TParent, TParentBuilder> Add(Tool.Builder builder)
        //{
        //    this.Owner.Buttons.Add(builder.ToControl());
        //    return this;
        //}

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual ToolsCollectionBuilder<TParent, TParentBuilder> Add(Tool tool)
        {
            this.Owner.Tools.Add(tool);
            return this;
        }
    }
}