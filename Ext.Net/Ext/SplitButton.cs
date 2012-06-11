/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A split button that provides a built-in dropdown arrow that can fire an event separately from the default click event of the button. Typically this would be used to display a dropdown menu that provides additional options to the primary button action, but any custom handler can provide the arrowclick implementation.
    /// </summary>
    [Meta]
    [Description("A split button that provides a built-in dropdown arrow that can fire an event separately from the default click event of the button. Typically this would be used to display a dropdown menu that provides additional options to the primary button action, but any custom handler can provide the arrowclick implementation.")]
    [ToolboxData("<{0}:SplitButton runat=\"server\" Text=\"Split Button\" />")]
    [DefaultEvent("Click")]
    [DefaultProperty("Text")]
    [ToolboxBitmap(typeof(SplitButton), "Build.ToolboxIcons.SplitButton.bmp")]
    [Designer(typeof(EmptyDesigner))]
    public partial class SplitButton : SplitButtonBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public SplitButton() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "splitbutton";
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
                return "Ext.SplitButton";
            }
        }
        
        private SplitButtonListeners listeners;

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
        public SplitButtonListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new SplitButtonListeners();
                }

                return this.listeners;
            }
        }

        private SplitButtonDirectEvents directEvents;

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
        public SplitButtonDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new SplitButtonDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}