/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A simple class that provides the basic implementation needed to make any element draggable.
    /// </summary>
    [Meta]
    [ToolboxItem(true)]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxData("<{0}:DragSource runat=\"server\"></{0}:DragSource>")]
    [ToolboxBitmap(typeof(DragSource), "Build.ToolboxIcons.DragDrop.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("A simple class that provides the basic implementation needed to make any element draggable.")]
    public partial class DragSource : DDProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public DragSource()
        {
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
                return "Ext.dd.DragSource";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToScript(Control owner)
        {
            string script = "new Ext.net.ProxyDDCreator({{target:{0},config:{1},type:{2}}}){3}".FormatWith(
                      this.ParsedTarget,
                      new ClientConfig().Serialize(this, true),
                      this.InstanceOf,
                      this.IsLazy ? "" : ";");

            return this.IsIdRequired ? string.Concat("window.", this.ClientID, "=", script) : script;
        }

        /// <summary>
        /// A named drag drop group to which this object belongs. If a group is specified, then this object will only interact with other drag drop objects in the same group (defaults to undefined).
        /// </summary>
        [Meta]
        [ConfigOption("ddGroup")]
        [Category("6. DragSource")]
        [DefaultValue("")]
        [Description("A named drag drop group to which this object belongs. If a group is specified, then this object will only interact with other drag drop objects in the same group (defaults to undefined).")]
        public override string Group
        {
            get
            {
                return this.State.Get<string>("Group", "");
            }
            set
            {
                this.State.Set("Group", value);
            }
        }

        private object dragData;
        
        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Category("6. DragSource")]
        [DefaultValue(null)]
        [Description("")]
        public virtual object DragData
        {
            get
            {
                return this.dragData;
            }
            set
            {
                this.dragData = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("dragData", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected virtual string DragDataProxy
        {
            get
            {
                if (this.DragData == null)
                {
                    return "";
                }

                return JSON.Serialize(this.DragData);
            }
        }

        /// <summary>
        /// If true, animates the proxy element back to the position of the handle element used to trigger the drag. Defaults to: true
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DragSource")]
        [DefaultValue(true)]
        [Description("If true, animates the proxy element back to the position of the handle element used to trigger the drag. Defaults to: true")]
        public virtual bool AnimRepair
        {
            get
            {
                return this.State.Get<bool>("AnimRepair", true);
            }
            set
            {
                this.State.Set("AnimRepair", value);
            }
        }

        /// <summary>
        /// The CSS class returned to the drag source when drop is allowed (defaults to "x-dd-drop-ok").
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DragSource")]
        [DefaultValue("x-dd-drop-ok")]
        [Description("The CSS class returned to the drag source when drop is allowed (defaults to \"x-dd-drop-ok\").")]
        public virtual string DropAllowed
        {
            get
            {
                return this.State.Get<string>("DropAllowed", "x-dd-drop-ok");
            }
            set
            {
                this.State.Set("DropAllowed", value);
            }
        }

        /// <summary>
        /// The CSS class returned to the drag source when drop is not allowed (defaults to "x-dd-drop-nodrop").
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DragSource")]
        [DefaultValue("x-dd-drop-nodrop")]
        [Description("The CSS class returned to the drag source when drop is not allowed (defaults to \"x-dd-drop-nodrop\").")]
        public virtual string DropNotAllowed
        {
            get
            {
                return this.State.Get<string>("DropNotAllowed", "x-dd-drop-nodrop");
            }
            set
            {
                this.State.Set("DropNotAllowed", value);
            }
        }

        /// <summary>
        /// The color to use when visually highlighting the drag source in the afterRepair method after a failed drop (defaults to light blue). The color must be a 6 digit hex value, without a preceding '#'. Defaults to: "c3daf9"
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DragSource")]
        [DefaultValue("c3daf9")]
        [Description("The color to use when visually highlighting the drag source in the afterRepair method after a failed drop (defaults to light blue). The color must be a 6 digit hex value, without a preceding '#'. Defaults to: \"c3daf9\"")]
        public virtual string RepairHighlightColor
        {
            get
            {
                return this.State.Get<string>("RepairHighlightColor", "c3daf9");
            }
            set
            {
                this.State.Set("RepairHighlightColor", value);
            }
        }

        private JFunction afterDragDrop;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action after a valid drag drop has occurred by providing an implementation.
        /// Parameters:
        ///     target : The drop target
        ///     e      : The mouseup event
        ///     id     : The id of the dropped element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action after a valid drag drop has occurred by providing an implementation.")]
        public virtual JFunction AfterDragDrop
        {
            get
            {
                if (this.afterDragDrop == null)
                {
                    this.afterDragDrop = new JFunction();
                 
                    if (!this.DesignMode)
                    {
                        this.afterDragDrop.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.afterDragDrop;
            }
        }

        private JFunction afterDragEnter;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action when the dragged item enters the drop target by providing an implementation.
        /// Parameters:
        ///     target : The drop target
        ///     e      : The mouseup event
        ///     id     : The id of the dragged element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action when the dragged item enters the drop target by providing an implementation.")]
        public virtual JFunction AfterDragEnter
        {
            get
            {
                if (this.afterDragEnter == null)
                {
                    this.afterDragEnter = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.afterDragEnter.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.afterDragEnter;
            }
        }

        private JFunction afterDragOut;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action after the dragged item is dragged out of the target without dropping.
        /// Parameters:
        ///     target : The drop target
        ///     e      : The mouseup event
        ///     id     : The id of the dragged element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action after the dragged item is dragged out of the target without dropping.")]
        public virtual JFunction AfterDragOut
        {
            get
            {
                if (this.afterDragOut == null)
                {
                    this.afterDragOut = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.afterDragOut.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.afterDragOut;
            }
        }

        private JFunction afterDragOver;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action while the dragged item is over the drop target by providing an implementation.
        /// Parameters:
        ///     target : The drop target
        ///     e      : The mouseup event
        ///     id     : The id of the dragged element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action while the dragged item is over the drop target by providing an implementation.")]
        public virtual JFunction AfterDragOver
        {
            get
            {
                if (this.afterDragOver == null)
                {
                    this.afterDragOver = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.afterDragOver.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.afterDragOver;
            }
        }

        private JFunction afterInvalidDrop;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action after an invalid drop has occurred by providing an implementation.
        /// Parameters:
        ///     e      : The mouseup event
        ///     id     : The id of the dropped element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action after an invalid drop has occurred by providing an implementation.")]
        public virtual JFunction AfterInvalidDrop
        {
            get
            {
                if (this.afterInvalidDrop == null)
                {
                    this.afterInvalidDrop = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.afterInvalidDrop.Args = new string[] { "e", "id" };
                    }
                }

                return this.afterInvalidDrop;
            }
        }

        private JFunction afterValidDrop;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action after a valid drop has occurred by providing an implementation.
        /// 
        /// Parameters
        /// target : Object
        ///     The target DD
        /// e : Event
        ///     The event object
        /// id : String
        ///     The id of the dropped element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action after an invalid drop has occurred by providing an implementation.")]
        public virtual JFunction AfterValidDrop
        {
            get
            {
                if (this.afterValidDrop == null)
                {
                    this.afterValidDrop = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.afterValidDrop.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.afterValidDrop;
            }
        }

        private JFunction beforeDragDrop;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the dragged item is dropped onto the target and optionally cancel the onDragDrop.
        /// Parameters:
        ///     target : The drop target
        ///     e      : The mouseup event
        ///     id     : The id of the dragged element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action before the dragged item is dropped onto the target and optionally cancel the onDragDrop.")]
        public virtual JFunction BeforeDragDrop
        {
            get
            {
                if (this.beforeDragDrop == null)
                {
                    this.beforeDragDrop = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.beforeDragDrop.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.beforeDragDrop;
            }
        }

        private JFunction beforeDragEnter;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the dragged item enters the drop target and optionally cancel the onDragEnter.
        /// Parameters:
        ///     target : The drop target
        ///     e      : The mouseup event
        ///     id     : The id of the dragged element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action before the dragged item enters the drop target and optionally cancel the onDragEnter.")]
        public virtual JFunction BeforeDragEnter
        {
            get
            {
                if (this.beforeDragEnter == null)
                {
                    this.beforeDragEnter = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.beforeDragEnter.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.beforeDragEnter;
            }
        }

        private JFunction beforeDragOut;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the dragged item is dragged out of the target without dropping, and optionally cancel the onDragOut.
        /// Parameters:
        ///     target : The drop target
        ///     e      : The mouseup event
        ///     id     : The id of the dragged element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action before the dragged item is dragged out of the target without dropping, and optionally cancel the onDragOut.")]
        public virtual JFunction BeforeDragOut
        {
            get
            {
                if (this.beforeDragOut == null)
                {
                    this.beforeDragOut = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.beforeDragOut.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.beforeDragOut;
            }
        }

        private JFunction beforeDragOver;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action while the dragged item is over the drop target and optionally cancel the onDragOver.
        /// Parameters:
        ///     target : The drop target
        ///     e      : The mouseup event
        ///     id     : The id of the dragged element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action while the dragged item is over the drop target and optionally cancel the onDragOver.")]
        public virtual JFunction BeforeDragOver
        {
            get
            {
                if (this.beforeDragOver == null)
                {
                    this.beforeDragOver = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.beforeDragOver.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.beforeDragOver;
            }
        }

        private JFunction beforeInvalidDrop;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action after an invalid drop has occurred.
        /// Parameters:
        ///     target : The drop target
        ///     e      : The mouseup event
        ///     id     : The id of the dropped element
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action after an invalid drop has occurred.")]
        public virtual JFunction BeforeInvalidDrop
        {
            get
            {
                if (this.beforeInvalidDrop == null)
                {
                    this.beforeInvalidDrop = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.beforeInvalidDrop.Args = new string[] { "target", "e", "id" };
                    }
                }

                return this.beforeInvalidDrop;
            }
        }

        private JFunction onBeforeDrag;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the initial drag event begins and optionally cancel it.
        /// Parameters:
        ///     data   : An object containing arbitrary data to be shared with drop targets
        ///     e      : The event object
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action before the initial drag event begins and optionally cancel it.")]
        public virtual JFunction OnBeforeDrag
        {
            get
            {
                if (this.onBeforeDrag == null)
                {
                    this.onBeforeDrag = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.onBeforeDrag.Args = new string[] { "data", "e" };
                    }
                }

                return this.onBeforeDrag;
            }
        }

        private JFunction onStartDrag;

        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action once the initial drag event has begun. The drag cannot be canceled from this function.
        /// Parameters:
        ///     x   : The x position of the click on the dragged object
        ///     y   : The y position of the click on the dragged object
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("An empty function by default, but provided so that you can perform a custom action once the initial drag event has begun. The drag cannot be canceled from this function.")]
        public virtual JFunction OnStartDrag
        {
            get
            {
                if (this.onStartDrag == null)
                {
                    this.onStartDrag = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.onStartDrag.Args = new string[] { "x", "y" };
                    }
                }

                return this.onStartDrag;
            }
        }

        private JFunction getDragData;

        /// <summary>
        /// Returns the data object associated with this drag source
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [Category("6. DragSource")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("Returns the data object associated with this drag source.")]
        public virtual JFunction GetDragData
        {
            get
            {
                if (this.getDragData == null)
                {
                    this.getDragData = new JFunction();
                    if (!this.DesignMode)
                    {
                        this.getDragData.Args = new string[] { "e" };
                    }
                }

                return this.getDragData;
            }
        }
    }
}