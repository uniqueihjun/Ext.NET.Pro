/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary><![CDATA[
    /// Data reader class to create an Array of Ext.data.Model objects from an Array. Each element of that Array represents a row of data fields. The fields are pulled into a Record object using as a subscript, the mapping property of the field definition if it exists, or the field's ordinal position in the definition.
    /// 
    /// Example code:
    /// 
    /// var Employee = Ext.regModel('Employee', {
    ///     fields: [
    ///         'id',
    ///         {name: 'name', mapping: 1},         // "mapping" only needed if an "id" field is present which
    ///         {name: 'occupation', mapping: 2}    // precludes using the ordinal position as the index.        
    ///     ]
    /// });
    ///
    /// var myReader = new Ext.data.reader.Array({
    ///     model: 'Employee'
    /// }, Employee);
    /// This would consume an Array like this:
    /// 
    /// [ [1, 'Bill', 'Gardener'], [2, 'Ben', 'Horticulturalist'] ]
    /// ]]></summary>
    [Meta]
    public partial class ArrayReader : JsonReader
    {
        /// <summary>
        /// 
        /// </summary>
        public ArrayReader()
        {
        }

        /// <summary>
        /// Alias
        /// </summary>
        [ConfigOption]
        [DefaultValue(null)]
        protected override string Type
        {
            get
            {
                return "array";
            }
        }

        /// <summary>
        /// Alias
        /// </summary>
        [DefaultValue("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.data.reader.Array";
            }
        }
    }
}
