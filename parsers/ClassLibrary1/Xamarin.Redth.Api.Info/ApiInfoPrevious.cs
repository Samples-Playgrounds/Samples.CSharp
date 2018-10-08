using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Xamarin.Redth.Api.InfoPrevious
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class assemblies
    {

        private assembliesAssembly assemblyField;

        /// <remarks/>
        public assembliesAssembly assembly
        {
            get
            {
                return this.assemblyField;
            }
            set
            {
                this.assemblyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssembly
    {

        private assembliesAssemblyAttribute[] attributesField;

        private assembliesAssemblyNamespace[] namespacesField;

        private string nameField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("attribute", IsNullable = false)]
        public assembliesAssemblyAttribute[] attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("namespace", IsNullable = false)]
        public assembliesAssemblyNamespace[] namespaces
        {
            get
            {
                return this.namespacesField;
            }
            set
            {
                this.namespacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyAttribute
    {

        private assembliesAssemblyAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespace
    {

        private assembliesAssemblyNamespaceClass[] classesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("class", IsNullable = false)]
        public assembliesAssemblyNamespaceClass[] classes
        {
            get
            {
                return this.classesField;
            }
            set
            {
                this.classesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClass
    {

        private assembliesAssemblyNamespaceClassAttribute[] attributesField;

        private assembliesAssemblyNamespaceClassInterface[] interfacesField;

        private assembliesAssemblyNamespaceClassField[] fieldsField;

        private assembliesAssemblyNamespaceClassConstructor[] constructorsField;

        private assembliesAssemblyNamespaceClassProperty[] propertiesField;

        private assembliesAssemblyNamespaceClassEvent[] eventsField;

        private assembliesAssemblyNamespaceClassMethod[] methodsField;

        private assembliesAssemblyNamespaceClassClass[] classesField;

        private string nameField;

        private string typeField;

        private string baseField;

        private bool sealedField;

        private bool sealedFieldSpecified;

        private string charsetField;

        private string layoutField;

        private bool abstractField;

        private bool abstractFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("attribute", IsNullable = false)]
        public assembliesAssemblyNamespaceClassAttribute[] attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("interface", IsNullable = false)]
        public assembliesAssemblyNamespaceClassInterface[] interfaces
        {
            get
            {
                return this.interfacesField;
            }
            set
            {
                this.interfacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("field", IsNullable = false)]
        public assembliesAssemblyNamespaceClassField[] fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("constructor", IsNullable = false)]
        public assembliesAssemblyNamespaceClassConstructor[] constructors
        {
            get
            {
                return this.constructorsField;
            }
            set
            {
                this.constructorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("event", IsNullable = false)]
        public assembliesAssemblyNamespaceClassEvent[] events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("method", IsNullable = false)]
        public assembliesAssemblyNamespaceClassMethod[] methods
        {
            get
            {
                return this.methodsField;
            }
            set
            {
                this.methodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("class", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClass[] classes
        {
            get
            {
                return this.classesField;
            }
            set
            {
                this.classesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @sealed
        {
            get
            {
                return this.sealedField;
            }
            set
            {
                this.sealedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sealedSpecified
        {
            get
            {
                return this.sealedFieldSpecified;
            }
            set
            {
                this.sealedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string charset
        {
            get
            {
                return this.charsetField;
            }
            set
            {
                this.charsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string layout
        {
            get
            {
                return this.layoutField;
            }
            set
            {
                this.layoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abstractSpecified
        {
            get
            {
                return this.abstractFieldSpecified;
            }
            set
            {
                this.abstractFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassAttribute
    {

        private assembliesAssemblyNamespaceClassAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassInterface
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassField
    {

        private assembliesAssemblyNamespaceClassFieldAttribute[] attributesField;

        private string nameField;

        private ushort attribField;

        private string fieldtypeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("attribute", IsNullable = false)]
        public assembliesAssemblyNamespaceClassFieldAttribute[] attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fieldtype
        {
            get
            {
                return this.fieldtypeField;
            }
            set
            {
                this.fieldtypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassFieldAttribute
    {

        private assembliesAssemblyNamespaceClassFieldAttributeProperties propertiesField;

        private string nameField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassFieldAttributeProperties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassFieldAttributeProperties
    {

        private assembliesAssemblyNamespaceClassFieldAttributePropertiesProperty propertyField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassFieldAttributePropertiesProperty property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassFieldAttributePropertiesProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassConstructor
    {

        private assembliesAssemblyNamespaceClassConstructorAttributes attributesField;

        private assembliesAssemblyNamespaceClassConstructorParameter[] parametersField;

        private string nameField;

        private ushort attribField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassConstructorAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public assembliesAssemblyNamespaceClassConstructorParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassConstructorAttributes
    {

        private assembliesAssemblyNamespaceClassConstructorAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassConstructorAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassConstructorAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassConstructorAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassConstructorAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassConstructorAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassConstructorParameter
    {

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassProperty
    {

        private assembliesAssemblyNamespaceClassPropertyAttributes attributesField;

        private assembliesAssemblyNamespaceClassPropertyMethod[] methodsField;

        private string nameField;

        private byte attribField;

        private string ptypeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("method", IsNullable = false)]
        public assembliesAssemblyNamespaceClassPropertyMethod[] methods
        {
            get
            {
                return this.methodsField;
            }
            set
            {
                this.methodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ptype
        {
            get
            {
                return this.ptypeField;
            }
            set
            {
                this.ptypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyAttributes
    {

        private assembliesAssemblyNamespaceClassPropertyAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassPropertyAttributesAttributeProperties propertiesField;

        private string nameField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyAttributesAttributeProperties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyAttributesAttributeProperties
    {

        private assembliesAssemblyNamespaceClassPropertyAttributesAttributePropertiesProperty propertyField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyAttributesAttributePropertiesProperty property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyAttributesAttributePropertiesProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethod
    {

        private assembliesAssemblyNamespaceClassPropertyMethodAttributes attributesField;

        private assembliesAssemblyNamespaceClassPropertyMethodParameters parametersField;

        private string nameField;

        private ushort attribField;

        private bool virtualField;

        private bool virtualFieldSpecified;

        private string returntypeField;

        private bool staticField;

        private bool staticFieldSpecified;

        private bool abstractField;

        private bool abstractFieldSpecified;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyMethodAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyMethodParameters parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @virtual
        {
            get
            {
                return this.virtualField;
            }
            set
            {
                this.virtualField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool virtualSpecified
        {
            get
            {
                return this.virtualFieldSpecified;
            }
            set
            {
                this.virtualFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returntype
        {
            get
            {
                return this.returntypeField;
            }
            set
            {
                this.returntypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @static
        {
            get
            {
                return this.staticField;
            }
            set
            {
                this.staticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staticSpecified
        {
            get
            {
                return this.staticFieldSpecified;
            }
            set
            {
                this.staticFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abstractSpecified
        {
            get
            {
                return this.abstractFieldSpecified;
            }
            set
            {
                this.abstractFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethodAttributes
    {

        private assembliesAssemblyNamespaceClassPropertyMethodAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyMethodAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethodAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassPropertyMethodAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassPropertyMethodAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethodAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethodParameters
    {

        private assembliesAssemblyNamespaceClassPropertyMethodParametersParameter parameterField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyMethodParametersParameter parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethodParametersParameter
    {

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassEvent
    {

        private string nameField;

        private byte attribField;

        private string eventtypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string eventtype
        {
            get
            {
                return this.eventtypeField;
            }
            set
            {
                this.eventtypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethod
    {

        private assembliesAssemblyNamespaceClassMethodAttribute[] attributesField;

        private assembliesAssemblyNamespaceClassMethodParameter[] parametersField;

        private string nameField;

        private ushort attribField;

        private bool virtualField;

        private bool virtualFieldSpecified;

        private string returntypeField;

        private bool abstractField;

        private bool abstractFieldSpecified;

        private bool staticField;

        private bool staticFieldSpecified;

        private bool sealedField;

        private bool sealedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("attribute", IsNullable = false)]
        public assembliesAssemblyNamespaceClassMethodAttribute[] attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public assembliesAssemblyNamespaceClassMethodParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @virtual
        {
            get
            {
                return this.virtualField;
            }
            set
            {
                this.virtualField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool virtualSpecified
        {
            get
            {
                return this.virtualFieldSpecified;
            }
            set
            {
                this.virtualFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returntype
        {
            get
            {
                return this.returntypeField;
            }
            set
            {
                this.returntypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abstractSpecified
        {
            get
            {
                return this.abstractFieldSpecified;
            }
            set
            {
                this.abstractFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @static
        {
            get
            {
                return this.staticField;
            }
            set
            {
                this.staticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staticSpecified
        {
            get
            {
                return this.staticFieldSpecified;
            }
            set
            {
                this.staticFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @sealed
        {
            get
            {
                return this.sealedField;
            }
            set
            {
                this.sealedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sealedSpecified
        {
            get
            {
                return this.sealedFieldSpecified;
            }
            set
            {
                this.sealedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodAttribute
    {

        private assembliesAssemblyNamespaceClassMethodAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassMethodAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodParameter
    {

        private assembliesAssemblyNamespaceClassMethodParameterAttributes attributesField;

        private string nameField;

        private byte positionField;

        private ushort attribField;

        private string typeField;

        private bool optionalField;

        private bool optionalFieldSpecified;

        private string defaultValueField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassMethodParameterAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool optional
        {
            get
            {
                return this.optionalField;
            }
            set
            {
                this.optionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool optionalSpecified
        {
            get
            {
                return this.optionalFieldSpecified;
            }
            set
            {
                this.optionalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string defaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodParameterAttributes
    {

        private assembliesAssemblyNamespaceClassMethodParameterAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassMethodParameterAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodParameterAttributesAttribute
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClass
    {

        private assembliesAssemblyNamespaceClassClassAttribute[] attributesField;

        private assembliesAssemblyNamespaceClassClassInterface[] interfacesField;

        private assembliesAssemblyNamespaceClassClassField[] fieldsField;

        private assembliesAssemblyNamespaceClassClassConstructor[] constructorsField;

        private assembliesAssemblyNamespaceClassClassProperty[] propertiesField;

        private assembliesAssemblyNamespaceClassClassEvent[] eventsField;

        private assembliesAssemblyNamespaceClassClassMethod[] methodsField;

        private assembliesAssemblyNamespaceClassClassClass[] classesField;

        private string nameField;

        private string typeField;

        private string baseField;

        private string charsetField;

        private string layoutField;

        private bool abstractField;

        private bool abstractFieldSpecified;

        private bool sealedField;

        private bool sealedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("attribute", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassAttribute[] attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("interface", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassInterface[] interfaces
        {
            get
            {
                return this.interfacesField;
            }
            set
            {
                this.interfacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("field", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassField[] fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("constructor", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassConstructor[] constructors
        {
            get
            {
                return this.constructorsField;
            }
            set
            {
                this.constructorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("event", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassEvent[] events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("method", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassMethod[] methods
        {
            get
            {
                return this.methodsField;
            }
            set
            {
                this.methodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("class", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClass[] classes
        {
            get
            {
                return this.classesField;
            }
            set
            {
                this.classesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string charset
        {
            get
            {
                return this.charsetField;
            }
            set
            {
                this.charsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string layout
        {
            get
            {
                return this.layoutField;
            }
            set
            {
                this.layoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abstractSpecified
        {
            get
            {
                return this.abstractFieldSpecified;
            }
            set
            {
                this.abstractFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @sealed
        {
            get
            {
                return this.sealedField;
            }
            set
            {
                this.sealedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sealedSpecified
        {
            get
            {
                return this.sealedFieldSpecified;
            }
            set
            {
                this.sealedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassAttribute
    {

        private assembliesAssemblyNamespaceClassClassAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassInterface
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassField
    {

        private assembliesAssemblyNamespaceClassClassFieldAttribute[] attributesField;

        private string nameField;

        private ushort attribField;

        private string fieldtypeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("attribute", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassFieldAttribute[] attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fieldtype
        {
            get
            {
                return this.fieldtypeField;
            }
            set
            {
                this.fieldtypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassFieldAttribute
    {

        private assembliesAssemblyNamespaceClassClassFieldAttributeProperties propertiesField;

        private string nameField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassFieldAttributeProperties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassFieldAttributeProperties
    {

        private assembliesAssemblyNamespaceClassClassFieldAttributePropertiesProperty propertyField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassFieldAttributePropertiesProperty property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassFieldAttributePropertiesProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassConstructor
    {

        private assembliesAssemblyNamespaceClassClassConstructorAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassConstructorParameter[] parametersField;

        private string nameField;

        private ushort attribField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassConstructorAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassConstructorParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassConstructorAttributes
    {

        private assembliesAssemblyNamespaceClassClassConstructorAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassConstructorAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassConstructorAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassConstructorAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassConstructorAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassConstructorAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassConstructorParameter
    {

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassProperty
    {

        private assembliesAssemblyNamespaceClassClassPropertyAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassPropertyMethod[] methodsField;

        private string nameField;

        private byte attribField;

        private string ptypeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassPropertyAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("method", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassPropertyMethod[] methods
        {
            get
            {
                return this.methodsField;
            }
            set
            {
                this.methodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ptype
        {
            get
            {
                return this.ptypeField;
            }
            set
            {
                this.ptypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyAttributes
    {

        private assembliesAssemblyNamespaceClassClassPropertyAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassPropertyAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassPropertyAttributesAttributeProperties propertiesField;

        private string nameField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassPropertyAttributesAttributeProperties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyAttributesAttributeProperties
    {

        private assembliesAssemblyNamespaceClassClassPropertyAttributesAttributePropertiesProperty propertyField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassPropertyAttributesAttributePropertiesProperty property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyAttributesAttributePropertiesProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyMethod
    {

        private assembliesAssemblyNamespaceClassClassPropertyMethodAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassPropertyMethodParameters parametersField;

        private string nameField;

        private ushort attribField;

        private bool virtualField;

        private bool virtualFieldSpecified;

        private string returntypeField;

        private bool staticField;

        private bool staticFieldSpecified;

        private bool abstractField;

        private bool abstractFieldSpecified;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassPropertyMethodAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassPropertyMethodParameters parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @virtual
        {
            get
            {
                return this.virtualField;
            }
            set
            {
                this.virtualField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool virtualSpecified
        {
            get
            {
                return this.virtualFieldSpecified;
            }
            set
            {
                this.virtualFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returntype
        {
            get
            {
                return this.returntypeField;
            }
            set
            {
                this.returntypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @static
        {
            get
            {
                return this.staticField;
            }
            set
            {
                this.staticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staticSpecified
        {
            get
            {
                return this.staticFieldSpecified;
            }
            set
            {
                this.staticFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abstractSpecified
        {
            get
            {
                return this.abstractFieldSpecified;
            }
            set
            {
                this.abstractFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyMethodAttributes
    {

        private assembliesAssemblyNamespaceClassClassPropertyMethodAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassPropertyMethodAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyMethodAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassPropertyMethodAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassPropertyMethodAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyMethodAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyMethodParameters
    {

        private assembliesAssemblyNamespaceClassClassPropertyMethodParametersParameter parameterField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassPropertyMethodParametersParameter parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyMethodParametersParameter
    {

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassEvent
    {

        private string nameField;

        private byte attribField;

        private string eventtypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string eventtype
        {
            get
            {
                return this.eventtypeField;
            }
            set
            {
                this.eventtypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethod
    {

        private assembliesAssemblyNamespaceClassClassMethodAttribute[] attributesField;

        private assembliesAssemblyNamespaceClassClassMethodParameter[] parametersField;

        private string nameField;

        private ushort attribField;

        private bool virtualField;

        private bool virtualFieldSpecified;

        private string returntypeField;

        private bool staticField;

        private bool staticFieldSpecified;

        private bool abstractField;

        private bool abstractFieldSpecified;

        private bool sealedField;

        private bool sealedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("attribute", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassMethodAttribute[] attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassMethodParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @virtual
        {
            get
            {
                return this.virtualField;
            }
            set
            {
                this.virtualField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool virtualSpecified
        {
            get
            {
                return this.virtualFieldSpecified;
            }
            set
            {
                this.virtualFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returntype
        {
            get
            {
                return this.returntypeField;
            }
            set
            {
                this.returntypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @static
        {
            get
            {
                return this.staticField;
            }
            set
            {
                this.staticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staticSpecified
        {
            get
            {
                return this.staticFieldSpecified;
            }
            set
            {
                this.staticFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abstractSpecified
        {
            get
            {
                return this.abstractFieldSpecified;
            }
            set
            {
                this.abstractFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @sealed
        {
            get
            {
                return this.sealedField;
            }
            set
            {
                this.sealedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sealedSpecified
        {
            get
            {
                return this.sealedFieldSpecified;
            }
            set
            {
                this.sealedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethodAttribute
    {

        private assembliesAssemblyNamespaceClassClassMethodAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassMethodAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethodAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethodParameter
    {

        private assembliesAssemblyNamespaceClassClassMethodParameterAttributes attributesField;

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassMethodParameterAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethodParameterAttributes
    {

        private assembliesAssemblyNamespaceClassClassMethodParameterAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassMethodParameterAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethodParameterAttributesAttribute
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClass
    {

        private object[] itemsField;

        private string nameField;

        private string typeField;

        private string baseField;

        private string charsetField;

        private string layoutField;

        private bool abstractField;

        private bool abstractFieldSpecified;

        private bool sealedField;

        private bool sealedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(assembliesAssemblyNamespaceClassClassClassAttributes))]
        [System.Xml.Serialization.XmlElementAttribute("classes", typeof(assembliesAssemblyNamespaceClassClassClassClasses))]
        [System.Xml.Serialization.XmlElementAttribute("constructors", typeof(assembliesAssemblyNamespaceClassClassClassConstructors))]
        [System.Xml.Serialization.XmlElementAttribute("fields", typeof(assembliesAssemblyNamespaceClassClassClassFields))]
        [System.Xml.Serialization.XmlElementAttribute("interfaces", typeof(assembliesAssemblyNamespaceClassClassClassInterfaces))]
        [System.Xml.Serialization.XmlElementAttribute("methods", typeof(assembliesAssemblyNamespaceClassClassClassMethods))]
        [System.Xml.Serialization.XmlElementAttribute("properties", typeof(assembliesAssemblyNamespaceClassClassClassProperties))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string charset
        {
            get
            {
                return this.charsetField;
            }
            set
            {
                this.charsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string layout
        {
            get
            {
                return this.layoutField;
            }
            set
            {
                this.layoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abstractSpecified
        {
            get
            {
                return this.abstractFieldSpecified;
            }
            set
            {
                this.abstractFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @sealed
        {
            get
            {
                return this.sealedField;
            }
            set
            {
                this.sealedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sealedSpecified
        {
            get
            {
                return this.sealedFieldSpecified;
            }
            set
            {
                this.sealedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassAttributesAttribute[] attributeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attribute")]
        public assembliesAssemblyNamespaceClassClassClassAttributesAttribute[] attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassClassAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClasses
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClass classField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassClassesClass @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClass
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassClassClassesClassInterface[] interfacesField;

        private assembliesAssemblyNamespaceClassClassClassClassesClassConstructor[] constructorsField;

        private assembliesAssemblyNamespaceClassClassClassClassesClassProperty[] propertiesField;

        private assembliesAssemblyNamespaceClassClassClassClassesClassMethod[] methodsField;

        private string nameField;

        private string typeField;

        private bool abstractField;

        private bool abstractFieldSpecified;

        private string charsetField;

        private string layoutField;

        private string baseField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassClassesClassAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("interface", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassClassesClassInterface[] interfaces
        {
            get
            {
                return this.interfacesField;
            }
            set
            {
                this.interfacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("constructor", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassClassesClassConstructor[] constructors
        {
            get
            {
                return this.constructorsField;
            }
            set
            {
                this.constructorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassClassesClassProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("method", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassClassesClassMethod[] methods
        {
            get
            {
                return this.methodsField;
            }
            set
            {
                this.methodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abstractSpecified
        {
            get
            {
                return this.abstractFieldSpecified;
            }
            set
            {
                this.abstractFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string charset
        {
            get
            {
                return this.charsetField;
            }
            set
            {
                this.charsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string layout
        {
            get
            {
                return this.layoutField;
            }
            set
            {
                this.layoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassClassesClassAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassClassesClassAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassInterface
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassConstructor
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassConstructorAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassClassClassesClassConstructorParameter[] parametersField;

        private string nameField;

        private ushort attribField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassClassesClassConstructorAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassClassesClassConstructorParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassConstructorAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassConstructorAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassClassesClassConstructorAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassConstructorAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassConstructorAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassClassesClassConstructorAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassConstructorAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassConstructorParameter
    {

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassProperty
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassPropertyMethods methodsField;

        private string nameField;

        private byte attribField;

        private string ptypeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassClassesClassPropertyMethods methods
        {
            get
            {
                return this.methodsField;
            }
            set
            {
                this.methodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ptype
        {
            get
            {
                return this.ptypeField;
            }
            set
            {
                this.ptypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassPropertyMethods
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassPropertyMethodsMethod methodField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassClassesClassPropertyMethodsMethod method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassPropertyMethodsMethod
    {

        private object parametersField;

        private string nameField;

        private ushort attribField;

        private bool virtualField;

        private string returntypeField;

        /// <remarks/>
        public object parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @virtual
        {
            get
            {
                return this.virtualField;
            }
            set
            {
                this.virtualField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returntype
        {
            get
            {
                return this.returntypeField;
            }
            set
            {
                this.returntypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassMethod
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassClassClassesClassMethodParameter[] parametersField;

        private string nameField;

        private ushort attribField;

        private bool virtualField;

        private string returntypeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassClassesClassMethodParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @virtual
        {
            get
            {
                return this.virtualField;
            }
            set
            {
                this.virtualField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returntype
        {
            get
            {
                return this.returntypeField;
            }
            set
            {
                this.returntypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassMethodParameter
    {

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassConstructors
    {

        private assembliesAssemblyNamespaceClassClassClassConstructorsConstructor[] constructorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("constructor")]
        public assembliesAssemblyNamespaceClassClassClassConstructorsConstructor[] constructor
        {
            get
            {
                return this.constructorField;
            }
            set
            {
                this.constructorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassConstructorsConstructor
    {

        private assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassClassConstructorsConstructorParameter[] parametersField;

        private string nameField;

        private ushort attribField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassConstructorsConstructorParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassConstructorsConstructorParameter
    {

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassFields
    {

        private assembliesAssemblyNamespaceClassClassClassFieldsField[] fieldField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("field")]
        public assembliesAssemblyNamespaceClassClassClassFieldsField[] field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassFieldsField
    {

        private assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributes attributesField;

        private string nameField;

        private ushort attribField;

        private string fieldtypeField;

        private string valueField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fieldtype
        {
            get
            {
                return this.fieldtypeField;
            }
            set
            {
                this.fieldtypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributesAttributeProperties propertiesField;

        private string nameField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributesAttributeProperties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributesAttributeProperties
    {

        private assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributesAttributePropertiesProperty propertyField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributesAttributePropertiesProperty property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassFieldsFieldAttributesAttributePropertiesProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassInterfaces
    {

        private assembliesAssemblyNamespaceClassClassClassInterfacesInterface[] interfaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interface")]
        public assembliesAssemblyNamespaceClassClassClassInterfacesInterface[] @interface
        {
            get
            {
                return this.interfaceField;
            }
            set
            {
                this.interfaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassInterfacesInterface
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassMethods
    {

        private assembliesAssemblyNamespaceClassClassClassMethodsMethod[] methodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("method")]
        public assembliesAssemblyNamespaceClassClassClassMethodsMethod[] method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassMethodsMethod
    {

        private assembliesAssemblyNamespaceClassClassClassMethodsMethodAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassClassMethodsMethodParameter[] parametersField;

        private string nameField;

        private ushort attribField;

        private bool abstractField;

        private bool abstractFieldSpecified;

        private bool virtualField;

        private bool virtualFieldSpecified;

        private string returntypeField;

        private bool staticField;

        private bool staticFieldSpecified;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassMethodsMethodAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassMethodsMethodParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool abstractSpecified
        {
            get
            {
                return this.abstractFieldSpecified;
            }
            set
            {
                this.abstractFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @virtual
        {
            get
            {
                return this.virtualField;
            }
            set
            {
                this.virtualField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool virtualSpecified
        {
            get
            {
                return this.virtualFieldSpecified;
            }
            set
            {
                this.virtualFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returntype
        {
            get
            {
                return this.returntypeField;
            }
            set
            {
                this.returntypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @static
        {
            get
            {
                return this.staticField;
            }
            set
            {
                this.staticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staticSpecified
        {
            get
            {
                return this.staticFieldSpecified;
            }
            set
            {
                this.staticFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassMethodsMethodAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassMethodsMethodAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassMethodsMethodAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassMethodsMethodAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassClassMethodsMethodAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassMethodsMethodAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassMethodsMethodAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassMethodsMethodParameter
    {

        private assembliesAssemblyNamespaceClassClassClassMethodsMethodParameterAttributes attributesField;

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassMethodsMethodParameterAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassMethodsMethodParameterAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassMethodsMethodParameterAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassMethodsMethodParameterAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassMethodsMethodParameterAttributesAttribute
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassProperties
    {

        private assembliesAssemblyNamespaceClassClassClassPropertiesProperty[] propertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public assembliesAssemblyNamespaceClassClassClassPropertiesProperty[] property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesProperty
    {

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethod[] methodsField;

        private string nameField;

        private byte attribField;

        private string ptypeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("method", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethod[] methods
        {
            get
            {
                return this.methodsField;
            }
            set
            {
                this.methodsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ptype
        {
            get
            {
                return this.ptypeField;
            }
            set
            {
                this.ptypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributesAttributeProperties propertiesField;

        private string nameField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributesAttributeProperties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributesAttributeProperties
    {

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributesAttributePropertiesProperty propertyField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributesAttributePropertiesProperty property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributesAttributePropertiesProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethod
    {

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodParameters parametersField;

        private string nameField;

        private ushort attribField;

        private bool virtualField;

        private bool virtualFieldSpecified;

        private string returntypeField;

        private bool staticField;

        private bool staticFieldSpecified;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodAttributes attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodParameters parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @virtual
        {
            get
            {
                return this.virtualField;
            }
            set
            {
                this.virtualField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool virtualSpecified
        {
            get
            {
                return this.virtualFieldSpecified;
            }
            set
            {
                this.virtualFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returntype
        {
            get
            {
                return this.returntypeField;
            }
            set
            {
                this.returntypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @static
        {
            get
            {
                return this.staticField;
            }
            set
            {
                this.staticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staticSpecified
        {
            get
            {
                return this.staticFieldSpecified;
            }
            set
            {
                this.staticFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodAttributesAttribute attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodAttributesAttribute
    {

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodAttributesAttributeProperty[] propertiesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodAttributesAttributeProperty[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodAttributesAttributeProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodParameters
    {

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodParametersParameter parameterField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodParametersParameter parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethodParametersParameter
    {

        private string nameField;

        private byte positionField;

        private byte attribField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attrib
        {
            get
            {
                return this.attribField;
            }
            set
            {
                this.attribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }


}
