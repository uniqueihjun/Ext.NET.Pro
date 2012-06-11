/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    [Meta]
    [Description("")]
    public partial class ImageCommandColumn : CellCommandColumn
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ImageCommandColumn() { }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "imagecommandcolumn";
            }
        }

        /// <summary>
        /// (optional) Specify as false to prevent the user from hiding this column. Defaults to false.
        /// </summary>
        [ConfigOption]
        [Category("3. ImageCommandColumn")]
        [DefaultValue(false)]
        [Description("(optional) Specify as false to prevent the user from hiding this column. Defaults to true.")]
        public override bool Hideable
        {
            get
            {
                return this.State.Get<bool>("Hideable", false);
            }
            set
            {
                this.State.Set("Hideable", value);
            }
        }

        /// <summary>
        /// True to disabled the column header menu containing sort/hide options. Defaults to false.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(true)]
        [Description("True to disabled the column header menu containing sort/hide options. Defaults to false.")]
        public override bool MenuDisabled
        {
            get
            {
                return this.State.Get<bool>("MenuDisabled", true);
            }
            set
            {
                this.State.Set("MenuDisabled", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Ignore)]
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Description("")]
        public override bool RightCommandAlign
        {
            get
            {
                return false;
            }
            set
            {
            }
        }
        
        private GroupImageCommandCollection groupCommands;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("groupCommands", JsonMode.AlwaysArray)]
        [Category("3. ImageCommandColumn")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]        
        [Description("")]
        public virtual GroupImageCommandCollection GroupCommands
        {
            get
            {
                if (this.groupCommands == null)
                {
                    this.groupCommands = new GroupImageCommandCollection();
                }

                return this.groupCommands;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue(false)]
        [ConfigOption(JsonMode.Ignore)]
		[Description("")]
        protected override bool IsCellCommand
        {
            get
            {
                return false;
            }
        }

        private JFunction prepareGroupCommand;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("3. ImageCommandColumn")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("")]
        public virtual JFunction PrepareGroupCommand
        {
            get
            {
                if (this.prepareGroupCommand == null)
                {
                    this.prepareGroupCommand = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.prepareGroupCommand.Args = new string[] {"grid", "command", "groupId", "group"};
                    }
                }

                return this.prepareGroupCommand;
            }
        }

        private JFunction prepareGroupCommands;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("3. ImageCommandColumn")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("")]
        public virtual JFunction PrepareGroupCommands
        {
            get
            {
                if (this.prepareGroupCommands == null)
                {
                    this.prepareGroupCommands = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.prepareGroupCommands.Args = new string[] {"grid", "commands", "groupId", "group"};
                    }
                }
                return this.prepareGroupCommands;
            }
        }

        private JFunction prepareCommand;

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("3. ImageCommandColumn")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("")]
        public override JFunction PrepareCommand
        {
            get
            {
                if (this.prepareCommand == null)
                {
                    this.prepareCommand = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.prepareCommand.Args = new string[] {"grid", "command", "record", "row"};
                    }
                }

                return this.prepareCommand;
            }
        }

        private JFunction prepareCommands;

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("3. ImageCommandColumn")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("")]
        public override JFunction PrepareCommands
        {
            get
            {
                if (this.prepareCommands == null)
                {
                    this.prepareCommands = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.prepareCommands.Args = new string[] {"grid", "commands", "record", "row"};
                    }
                }
                return this.prepareCommands;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override System.Collections.Generic.List<Icon> Icons
        {
            get
            {
                List<Icon> icons = base.Icons;

                foreach (GroupImageCommand command in this.GroupCommands)
                {
                    if (command.Icon != Icon.None)
                    {
                        icons.Add(command.Icon);
                    }
                }

                return icons;
            }
        }

        private ImageCommandColumnListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]        
        [Description("Client-side JavaScript Event Handlers")]
        public ImageCommandColumnListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new ImageCommandColumnListeners();
                }

                return this.listeners;
            }
        }

        private ImageCommandColumnDirectEvents directEvents;

        /// <summary>
        /// Server-side Ajax Event Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]        
        [Description("Server-side Ajax Event Handlers")]
        public ImageCommandColumnDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new ImageCommandColumnDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}