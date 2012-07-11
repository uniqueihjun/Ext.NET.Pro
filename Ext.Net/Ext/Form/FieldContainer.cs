/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// FieldContainer is a derivation of Container that implements the Labelable mixin. This allows it to be configured so that it is rendered with a field label and optional error message around its sub-items. This is useful for arranging a group of fields or other components within a single item in a form, so that it lines up nicely with other fields. A common use is for grouping a set of related fields under a single label in a form.
    /// The container's configured items will be layed out within the field body area according to the configured layout type. The default layout is 'autocontainer'.
    /// 
    /// Like regular fields, FieldContainer can inherit its decoration configuration from the fieldDefaults of an enclosing FormPanel. In addition, FieldContainer itself can pass fieldDefaults to any fields it may itself contain.
    ///
    /// If you are grouping a set of Checkbox or Radio fields in a single labeled container, consider using a Ext.form.CheckboxGroup or Ext.form.RadioGroup instead as they are specialized for handling those types.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:FieldContainer runat=\"server\"><Items></Items></{0}:FieldContainer>")]
    [ToolboxBitmap(typeof(FieldContainer), "Build.ToolboxIcons.Container.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("FieldContainer is a derivation of Container that implements the Labelable mixin.")]
    public partial class FieldContainer : FieldContainerBase
    {
        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public FieldContainer() { }


        /*  Properties
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "fieldcontainer";
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
                return "Ext.form.FieldContainer";
            }
        }

        private FieldContainerListeners listeners;

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
        public FieldContainerListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new FieldContainerListeners();
                }

                return this.listeners;
            }
        }

        private FieldContainerDirectEvents directEvents;

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
        public FieldContainerDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new FieldContainerDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}