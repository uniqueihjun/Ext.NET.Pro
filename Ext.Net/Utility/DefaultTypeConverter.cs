/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class DefaultTypeConverter : StringConverter
    {
        private static Dictionary<string, string> xtypesDictionary = new Dictionary<string,string>()
        {
            { "BoxComponent", "box" },
            { "Button", "button" },
            { "ButtonGroup", "buttongroup" },
            { "CalendarPanel", "calendarpanel" },
            { "CheckMenuItem", "menucheckitem" },
            { "Checkbox", "checkbox" },
            { "CheckboxGroup", "checkboxgroup" },
            { "ColorMenu", "colormenu" },
            { "ColorPallete", "colorpalette" },
            { "ColumnTree", "columntree" },
            { "ComboBox", "combo" },
            { "Component", "component" },
            { "ComponentMenuItem", "componentmenuitem" },
            { "CompositeField", "compositefield" },
            { "Container", "container" },
            { "CycleButton", "cycle" },
            { "DataView", "dataview" },
            { "DateField", "datefield" },
            { "DateMenu", "datemenu" },
            { "DatePicker", "datepicker" },
            { "DisplayField", "displayfield" },
            { "DropDownField", "netdropdown" },
            { "FieldSet", "fieldset" },
            { "FileUploadField", "fileuploadfield" },
            { "FlashComponent", "flash" },
            { "FormPanel", "form" },
            { "GridPanel", "netgrid" },
            { "GroupTab", "grouptab" },
            { "GroupTabPanel", "grouptabpanel" },
            { "HiddenField", "hidden" },
            { "HtmlEditor", "htmleditor" },
            { "HyperLink", "nethyperlink" },
            { "Image", "netimage" },
            { "ImageButton", "netimagebutton" },
            { "Label", "label" },
            { "LinkButton", "netlinkbutton" },
            { "ListView", "listview" },
            { "Menu", "menu" },
            { "MenuItem", "menuitem" },
            { "MenuSeparator", "menuseparator" },
            { "MenuTextItem", "menutextitem" },
            { "MultiSelect", "multiselect" },
            { "MenuPanel", "netmenupanel" },
            { "MultiCombo", "netmulticombo" },
            { "NumberFIeld", "numberfield" },
            { "PropertyGrid", "netpropertygrid" },
            { "Panel", "panel" },
            { "Portal", "portal" },
            { "Portlet", "portlet" },
            { "ProgressBar", "progress" },
            { "Radio", "radio" },
            { "RadioGroup", "radiogroup" },
            { "SelectBox", "selectbox" },
            { "Slider", "slider" },
            { "SliderField", "sliderfield" },
            { "SpinnerField", "spinnerfield" },
            { "SplitButton", "splitbutton" },
            { "StatusBar", "statusbar" },
            { "Toolbar.HtmlElement", "nettbhtml" },
            { "Toolbar.Spacer", "nettbspacer" },
            { "TreePanel", "nettreepanel" },
            { "TriggerField", "nettrigger" },
            { "TableGrid", "tablegrid" },
            { "TabPanel", "tabpanel" },
            { "TabStrip", "tabstrip" },
            { "Toolbar.Fill", "tbfill" },
            { "Toolbar.Separator", "tbseparator" },
            { "Toolbar.TextItem", "tbtext" },
            { "TextArea", "textarea" },
            { "TextField", "textfield" },
            { "TimeField", "timefield" },
            { "Toolbar", "toolbar" },
            { "TreeGrid", "treegrid" }
        };

        private TypeConverter.StandardValuesCollection values;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            if (this.values == null)
            {
                this.values = new TypeConverter.StandardValuesCollection(xtypesDictionary.Keys);
            }

            return this.values;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Description("")]
        public static string GetXType(string value)
        {
            string xtype;
            xtypesDictionary.TryGetValue(value, out xtype);
            return xtype ?? value;
        }
    }
}