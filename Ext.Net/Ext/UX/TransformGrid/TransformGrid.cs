/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A Grid which creates itself from an existing HTML table element.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:TransformGrid runat=\"server\"></{0}:TransformGrid>")]
    [ToolboxBitmap(typeof(TransformGrid), "Build.ToolboxIcons.TableGrid.bmp")]
    [Description("A Grid which creates itself from an existing HTML table element.")]
    public partial class TransformGrid : GridPanel
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TransformGrid() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "transformgrid";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.ux.grid.TransformGrid";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 2;

                baseList.Add(new ClientScriptItem(typeof(TabMenu), "Ext.Net.Build.Ext.Net.ux.transformgrid.transformgrid.js", "/ux/transformgrid/transformgrid.js"));

                return baseList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Ignore)]
        [Description("")]
        protected internal override string RenderToProxy
        {
            get
            {
                return "";
            }
        }
               /// <summary>
        /// 
        /// </summary>
        [ConfigOption("table", JsonMode.Raw)]
        [Description("")]
        protected string TableProxy
        {
            get
            {
                string parsedTable = TokenUtils.ParseTokens(this.Table, this);

                if (TokenUtils.IsRawToken(parsedTable))
                {
                    return TokenUtils.ReplaceRawToken(parsedTable);
                }

                return "\"".ConcatWith(parsedTable, "\"");
            }
        }

        /// <summary>
        /// The table element from which this grid will be created.
        /// </summary>
        [Meta]
        [Category("8. TableGrid")]
        [DefaultValue("")]
        [Description("The table element from which this grid will be created.")]
        public virtual string Table
        {
            get
            {
                return this.State.Get<string>("Table", "");
            }
            set
            {
                this.State.Set("Table", value);
            }
        }
    }
}
