/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// An individual column's config object defines the header string, the Record field
    /// the column draws its data from, an optional rendering function to provide customized
    /// data formatting, and the ability to apply a CSS class to all cells in a column
    /// through its id config option.
    /// </summary>
    [Meta]
    [Description("An individual column's config object defines the header string, the Record field the column draws its data from, an optional rendering function to provide customized data formatting, and the ability to apply a CSS class to all cells in a column through its id config option.")]
    public partial class Column : ColumnBase, IIcon
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Column() { }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("xtype")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string XType
        {
            get
            {
                object obj = this.ViewState["XType"];
                return (obj == null) ? "" : (string)obj;
            }
            set
            {
                this.ViewState["XType"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool RightCommandAlign
        {
            get
            {
                object obj = this.ViewState["RightCommandAlign"];
                return obj == null ? true : (bool)obj;
            }
            set
            {
                this.ViewState["RightCommandAlign"] = value;
            }
        }        
        
        private ImageCommandCollection commands;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("commands", JsonMode.AlwaysArray)]
        [Category("2. Column")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [ViewStateMember]
        [Description("")]
        public virtual ImageCommandCollection Commands
        {
            get
            {
                if (this.commands == null)
                {
                    this.commands = new ImageCommandCollection();
                }

                return this.commands;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue(false)]
        [ConfigOption]
		[Description("")]
        protected virtual bool IsCellCommand
        {
            get
            {
                return this.Commands.Count > 0;
            }
        }

        private JFunction prepareCommand;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("2. Column")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("")]
        public virtual JFunction PrepareCommand
        {
            get
            {
                if (this.prepareCommand == null)
                {
                    this.prepareCommand = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.prepareCommand.Args = new string[] {"grid", "command", "record", "row", "col", "value"};
                    }
                }

                return this.prepareCommand;
            }
        }

        private JFunction prepareCommands;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("2. Column")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("")]
        public virtual JFunction PrepareCommands
        {
            get
            {
                if (this.prepareCommands == null)
                {
                    this.prepareCommands = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.prepareCommands.Args = new string[] {"grid", "commands", "record", "row", "col", "value"};
                    }
                }
                return this.prepareCommands;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual System.Collections.Generic.List<Icon> Icons
        {
            get
            {
                List<Icon> icons = new List<Icon>();

                foreach (ImageCommand command in this.Commands)
                {
                    if (command.Icon != Icon.None)
                    {
                        icons.Add(command.Icon);
                    }
                }

                return icons;
            }
        }

    }
}