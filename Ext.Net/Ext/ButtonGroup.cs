/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Container for a group of buttons.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:ButtonGroup runat=\"server\" Title=\"Title\" Height=\"300\"><Items></Items></{0}:ButtonGroup>")]
    [ToolboxBitmap(typeof(Panel), "Build.ToolboxIcons.ButtonGroup.bmp")]
    [Designer(typeof(PanelDesigner))]
    [Description("Container for a group of buttons.")]
    public partial class ButtonGroup : Panel
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ButtonGroup() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "buttongroup";
            }
        }

        /// <summary>
        /// The default type of content Container represented by this object as registered in Ext.ComponentMgr. Defaults to 'button' in ButtonGroup).
        /// </summary>
        [Meta]
        [Category("5. Container")]
        [DefaultValue("Button")]
        [NotifyParentProperty(true)]
        [Description("The default type of content Container represented by this object as registered in Ext.ComponentMgr. Defaults to 'button' in ButtonGroup")]
        public override string DefaultType
        {
            get
            {
                return (string)this.ViewState["DefaultType"] ?? "Button";
            }
            set
            {
                this.ViewState["DefaultType"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("defaultType")]
        [DefaultValue("button")]
        [Description("")]
        protected override string DefaultTypeProxy
        {
            get
            {
                return base.DefaultTypeProxy;
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
                return "Ext.ButtonGroup";
            }
        }

        /// <summary>
        /// True to render the panel with custom rounded borders, false to render with plain 1px square borders (defaults to true).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. ButtonGroup")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to render the panel with custom rounded borders, false to render with plain 1px square borders (defaults to true).")]
        public override bool Frame
        {
            get
            {
                object obj = this.ViewState["Frame"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["Frame"] = value;
            }
        }

        /// <summary>
        /// The columns configuration property passed to the configured layout manager. See Ext.layout.TableLayout.columns.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. ButtonGroup")]
        [DefaultValue(-1)]
        [NotifyParentProperty(true)]
        [Description("The columns configuration property passed to the configured layout manager. See Ext.layout.TableLayout.columns.")]
        public virtual int Columns
        {
            get
            {
                object obj = this.ViewState["Columns"];
                return (obj == null) ? -1 : (int)obj;
            }
            set
            {
                this.ViewState["Columns"] = value;
            }
        }

        /// <summary>
        /// The layout type to be used in this container.
        /// </summary>
        [Meta]
        [Category("5. Container")]
        [DefaultValue("table")]
        [TypeConverter(typeof(LayoutConverter))]
        [Description("The layout type to be used in this container.")]
        public override string Layout
        {
            get
            {
                return (string)this.ViewState["Layout"] ?? "table";
            }
            set
            {
                this.ViewState["Layout"] = value;
            }
        }
    }
}