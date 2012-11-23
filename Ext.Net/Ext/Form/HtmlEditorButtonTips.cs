/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public partial class HtmlEditorButtonTips : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTips() 
        {
        }
        
        private HtmlEditorButtonTip bold;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption(JsonMode.Object)]
        public virtual HtmlEditorButtonTip Bold
        {
            get
            {
                return this.bold ?? (this.bold = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip italic;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption(JsonMode.Object)]
        public virtual HtmlEditorButtonTip Italic
        {
            get
            {
                return this.italic ?? (this.italic = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip underline;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption(JsonMode.Object)]
        public virtual HtmlEditorButtonTip Underline
        {
            get
            {
                return this.underline ?? (this.underline = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip increasefontsize;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("increasefontsize", JsonMode.Object)]
        public virtual HtmlEditorButtonTip IncreaseFontSize
        {
            get
            {
                return this.increasefontsize ?? (this.increasefontsize = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip decreasefontsize;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("decreasefontsize", JsonMode.Object)]
        public virtual HtmlEditorButtonTip DecreaseFontSize
        {
            get
            {
                return this.decreasefontsize ?? (this.decreasefontsize = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip backcolor;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("backcolor", JsonMode.Object)]
        public virtual HtmlEditorButtonTip BackColor
        {
            get
            {
                return this.backcolor ?? (this.backcolor = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip forecolor;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("forecolor", JsonMode.Object)]
        public virtual HtmlEditorButtonTip ForeColor
        {
            get
            {
                return this.forecolor ?? (this.forecolor = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip justifyleft;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("justifyleft", JsonMode.Object)]
        public virtual HtmlEditorButtonTip JustifyLeft
        {
            get
            {
                return this.justifyleft ?? (this.justifyleft = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip justifycenter;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("justifycenter", JsonMode.Object)]
        public virtual HtmlEditorButtonTip JustifyCenter 
        {
            get
            {
                return this.justifycenter ?? (this.justifycenter = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip justifyright;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("justifyright", JsonMode.Object)]
        public virtual HtmlEditorButtonTip JustifyRight 
        {
            get
            {
                return this.justifyright ?? (this.justifyright = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip insertunorderedlist;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("insertunorderedlist", JsonMode.Object)]
        public virtual HtmlEditorButtonTip InsertUnorderedList
        {
            get
            {
                return this.insertunorderedlist ?? (this.insertunorderedlist = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip insertorderedlist;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("insertorderedlist", JsonMode.Object)]
        public virtual HtmlEditorButtonTip InsertOrderedList
        {
            get
            {
                return this.insertorderedlist ?? (this.insertorderedlist = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip createlink;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("createlink", JsonMode.Object)]
        public virtual HtmlEditorButtonTip CreateLink
        {
            get
            {
                return this.createlink ?? (this.createlink = new HtmlEditorButtonTip());
            }
        }

        private HtmlEditorButtonTip sourceedit;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("sourceedit", JsonMode.Object)]
        public virtual HtmlEditorButtonTip SourceEdit
        {
            get
            {
                return this.sourceedit ?? (this.sourceedit = new HtmlEditorButtonTip());
            }
        }
    }
}
