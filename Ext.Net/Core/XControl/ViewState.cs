/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class XControl
    {
        /*  ViewState
            -----------------------------------------------------------------------------------------------*/

        private ViewStateProxy viewState;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected new ViewStateProxy ViewState
        {
            get
            {
                if (this.viewState == null)
                {
                    this.viewState = new ViewStateProxy(this, base.ViewState);
                }

                return this.viewState;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void LoadViewState(object state)
        {
            object[] states = state as object[];

            if (states != null)
            {
                foreach (Pair pair in states)
                {
                    switch ((string)pair.First)
                    {
                        case "base":
                            base.LoadViewState(pair.Second);
                            break;
                        case "vsMembers":
                            ViewStateProcessor.LoadViewState(this, pair.Second);
                            break;
                    }
                }
            }
            else
            {
                base.LoadViewState(state);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override object SaveViewState()
        {
            List<Pair> state = new List<Pair>();
            object baseState = base.SaveViewState();

            if (baseState != null)
            {
                state.Add(new Pair("base", baseState));
            }

            object vsMembers = ViewStateProcessor.SaveViewState(this);

            if (vsMembers != null)
            {
                state.Add(new Pair("vsMembers", vsMembers));
            }

            return state.Count == 0 ? null : state.ToArray();
        }
    }
}