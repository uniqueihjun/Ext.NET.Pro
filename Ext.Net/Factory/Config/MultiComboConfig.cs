/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MultiCombo
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public MultiCombo(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit MultiCombo.Config Conversion to MultiCombo
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultiCombo(MultiCombo.Config config)
        {
            return new MultiCombo(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ComboBoxBase.Config 
        { 
			/*  Implicit MultiCombo.Config Conversion to MultiCombo.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator MultiCombo.Builder(MultiCombo.Config config)
			{
				return new MultiCombo.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool sortByDisplayField = false;

			/// <summary>
			/// True to sort selected items by DisplayField. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool SortByDisplayField 
			{ 
				get
				{
					return this.sortByDisplayField;
				}
				set
				{
					this.sortByDisplayField = value;
				}
			}

			private bool wrapBySquareBrackets = false;

			/// <summary>
			/// True to wrap by square brackets.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool WrapBySquareBrackets 
			{ 
				get
				{
					return this.wrapBySquareBrackets;
				}
				set
				{
					this.wrapBySquareBrackets = value;
				}
			}

			private MultiSelectMode selectionMode = MultiSelectMode.Checkbox;

			/// <summary>
			/// Selection UI mode
			/// </summary>
			[DefaultValue(MultiSelectMode.Checkbox)]
			public virtual MultiSelectMode SelectionMode 
			{ 
				get
				{
					return this.selectionMode;
				}
				set
				{
					this.selectionMode = value;
				}
			}
        
			private ComboBoxListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public ComboBoxListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new ComboBoxListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private ComboBoxDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public ComboBoxDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new ComboBoxDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}