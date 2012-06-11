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
    [Meta]
    public abstract partial class CellCommandColumn : ColumnBase, IIcon
    {
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
                return this.State.Get<bool>("RightCommandAlign", true);
            }
            set
            {
                this.State.Set("RightCommandAlign", value);
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
                        this.prepareCommand.Args = new string[] { "grid", "command", "record", "row", "col", "value" };
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
                        this.prepareCommands.Args = new string[] { "grid", "commands", "record", "row", "col", "value" };
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
