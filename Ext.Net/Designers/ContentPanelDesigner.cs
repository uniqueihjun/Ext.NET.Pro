/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;
using System.Web.UI;
using System.Web.UI.Design;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ContentPanelDesigner : PanelBaseDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void Initialize(System.ComponentModel.IComponent component)
        {
            base.Initialize(component);

            if (!this.Disabled)
            {
                this.SetViewFlags(ViewFlags.TemplateEditing, true);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override TemplateGroupCollection TemplateGroups
        {
            get
            {
                TemplateGroupCollection templateGroups = new TemplateGroupCollection();
                TemplateGroup group = new TemplateGroup("Body");
                TemplateDefinition template = new TemplateDefinition(this, "Body", this.Control, "Body", false);
                group.AddTemplateDefinition(template);
                templateGroups.Add(group);
                return templateGroups;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region)
        {
            IDesignerHost host = (IDesignerHost)Component.Site.GetService(typeof(IDesignerHost));

            if (host != null)
            {
                ITemplate template = ((Component)this.Control).Content as ITemplate;

                if (template != null)
                {
                    return ControlPersister.PersistTemplate(template, host);
                }
            }

            return "";
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content)
        {
            if (content == null)
            {
                return;
            }

            IDesignerHost host = (IDesignerHost)Component.Site.GetService(typeof(IDesignerHost));

            if (host != null)
            {
                ITemplate template = ControlParser.ParseTemplate(host, content);
                ((IContent)this.Control).Content = template;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected string ContentRegionName
        {
            get
            {
                if (Layout.HasValue)
                {
                    switch (Layout.Value)
                    {
                        case LayoutType.Accordion:
                            break;
                        case LayoutType.Anchor:
                            break;
                        case LayoutType.Border:
                            return "Body_{0}_{1}".FormatWith(BorderRegion.Region, 0);
                        case LayoutType.Card:
                            break;
                        case LayoutType.Column:
                            break;
                        case LayoutType.Container:
                            break;
                        case LayoutType.Fit:
                            return "Body_{0}".FormatWith(0);
                        case LayoutType.Form:
                            break;
                        case LayoutType.Table:
                            break;
                    }
                }

                return "Body";
            }
        }
        
    }
}