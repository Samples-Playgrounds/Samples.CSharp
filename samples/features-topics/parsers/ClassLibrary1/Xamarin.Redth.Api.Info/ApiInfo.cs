using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Xamarin.Redth.Api.Info
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

        private byte missingField;

        private byte presentField;

        private byte extraField;

        private byte okField;

        private byte completeField;

        private ushort missing_totalField;

        private ushort present_totalField;

        private byte extra_totalField;

        private ushort ok_totalField;

        private byte complete_totalField;

        private ushort warning_totalField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte missing
        {
            get
            {
                return this.missingField;
            }
            set
            {
                this.missingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra
        {
            get
            {
                return this.extraField;
            }
            set
            {
                this.extraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort missing_total
        {
            get
            {
                return this.missing_totalField;
            }
            set
            {
                this.missing_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra_total
        {
            get
            {
                return this.extra_totalField;
            }
            set
            {
                this.extra_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort warning_total
        {
            get
            {
                return this.warning_totalField;
            }
            set
            {
                this.warning_totalField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyAttribute
    {

        private string nameField;

        private string presenceField;

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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespace
    {

        private assembliesAssemblyNamespaceClass[] classesField;

        private string nameField;

        private byte missingField;

        private bool missingFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte warningField;

        private bool warningFieldSpecified;

        private byte missing_totalField;

        private bool missing_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private byte warning_totalField;

        private bool warning_totalFieldSpecified;

        private ushort presentField;

        private bool presentFieldSpecified;

        private ushort okField;

        private bool okFieldSpecified;

        private ushort present_totalField;

        private bool present_totalFieldSpecified;

        private ushort ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte extraField;

        private bool extraFieldSpecified;

        private byte extra_totalField;

        private bool extra_totalFieldSpecified;

        private string presenceField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte missing
        {
            get
            {
                return this.missingField;
            }
            set
            {
                this.missingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool missingSpecified
        {
            get
            {
                return this.missingFieldSpecified;
            }
            set
            {
                this.missingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warningSpecified
        {
            get
            {
                return this.warningFieldSpecified;
            }
            set
            {
                this.warningFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte missing_total
        {
            get
            {
                return this.missing_totalField;
            }
            set
            {
                this.missing_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool missing_totalSpecified
        {
            get
            {
                return this.missing_totalFieldSpecified;
            }
            set
            {
                this.missing_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning_total
        {
            get
            {
                return this.warning_totalField;
            }
            set
            {
                this.warning_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warning_totalSpecified
        {
            get
            {
                return this.warning_totalFieldSpecified;
            }
            set
            {
                this.warning_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra
        {
            get
            {
                return this.extraField;
            }
            set
            {
                this.extraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extraSpecified
        {
            get
            {
                return this.extraFieldSpecified;
            }
            set
            {
                this.extraFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra_total
        {
            get
            {
                return this.extra_totalField;
            }
            set
            {
                this.extra_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extra_totalSpecified
        {
            get
            {
                return this.extra_totalFieldSpecified;
            }
            set
            {
                this.extra_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClass
    {

        private assembliesAssemblyNamespaceClassAttribute[] attributesField;

        private assembliesAssemblyNamespaceClassWarning[] warningsField;

        private assembliesAssemblyNamespaceClassInterface[] interfacesField;

        private assembliesAssemblyNamespaceClassField[] fieldsField;

        private assembliesAssemblyNamespaceClassConstructor[] constructorsField;

        private assembliesAssemblyNamespaceClassProperty[] propertiesField;

        private assembliesAssemblyNamespaceClassEvent[] eventsField;

        private assembliesAssemblyNamespaceClassMethod[] methodsField;

        private assembliesAssemblyNamespaceClassClass[] classesField;

        private string nameField;

        private string typeField;

        private string errorField;

        private byte missingField;

        private bool missingFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte warningField;

        private bool warningFieldSpecified;

        private byte missing_totalField;

        private bool missing_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private ushort presentField;

        private bool presentFieldSpecified;

        private ushort okField;

        private bool okFieldSpecified;

        private ushort present_totalField;

        private bool present_totalFieldSpecified;

        private ushort ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte warning_totalField;

        private bool warning_totalFieldSpecified;

        private byte extraField;

        private bool extraFieldSpecified;

        private byte extra_totalField;

        private bool extra_totalFieldSpecified;

        private string presenceField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("warning", IsNullable = false)]
        public assembliesAssemblyNamespaceClassWarning[] warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
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
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte missing
        {
            get
            {
                return this.missingField;
            }
            set
            {
                this.missingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool missingSpecified
        {
            get
            {
                return this.missingFieldSpecified;
            }
            set
            {
                this.missingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warningSpecified
        {
            get
            {
                return this.warningFieldSpecified;
            }
            set
            {
                this.warningFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte missing_total
        {
            get
            {
                return this.missing_totalField;
            }
            set
            {
                this.missing_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool missing_totalSpecified
        {
            get
            {
                return this.missing_totalFieldSpecified;
            }
            set
            {
                this.missing_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning_total
        {
            get
            {
                return this.warning_totalField;
            }
            set
            {
                this.warning_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warning_totalSpecified
        {
            get
            {
                return this.warning_totalFieldSpecified;
            }
            set
            {
                this.warning_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra
        {
            get
            {
                return this.extraField;
            }
            set
            {
                this.extraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extraSpecified
        {
            get
            {
                return this.extraFieldSpecified;
            }
            set
            {
                this.extraFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra_total
        {
            get
            {
                return this.extra_totalField;
            }
            set
            {
                this.extra_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extra_totalSpecified
        {
            get
            {
                return this.extra_totalFieldSpecified;
            }
            set
            {
                this.extra_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassAttribute
    {

        private string nameField;

        private string presenceField;

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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassWarning
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassInterface
    {

        private string nameField;

        private string presenceField;

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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassField
    {

        private assembliesAssemblyNamespaceClassFieldAttribute[] attributesField;

        private string nameField;

        private string presenceField;

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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassFieldAttribute
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
    public partial class assembliesAssemblyNamespaceClassConstructor
    {

        private assembliesAssemblyNamespaceClassConstructorAttributes attributesField;

        private assembliesAssemblyNamespaceClassConstructorWarnings warningsField;

        private assembliesAssemblyNamespaceClassConstructorParameter[] parametersField;

        private string nameField;

        private string presenceField;

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private string errorField;

        private byte warningField;

        private bool warningFieldSpecified;

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
        public assembliesAssemblyNamespaceClassConstructorWarnings warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warningSpecified
        {
            get
            {
                return this.warningFieldSpecified;
            }
            set
            {
                this.warningFieldSpecified = value;
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
    public partial class assembliesAssemblyNamespaceClassConstructorWarnings
    {

        private assembliesAssemblyNamespaceClassConstructorWarningsWarning warningField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassConstructorWarningsWarning warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassConstructorWarningsWarning
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassConstructorParameter
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
    public partial class assembliesAssemblyNamespaceClassProperty
    {

        private assembliesAssemblyNamespaceClassPropertyMethod[] methodsField;

        private assembliesAssemblyNamespaceClassPropertyAttributes attributesField;

        private string nameField;

        private string presenceField;

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private byte warningField;

        private bool warningFieldSpecified;

        private byte warning_totalField;

        private bool warning_totalFieldSpecified;

        private byte extraField;

        private bool extraFieldSpecified;

        private byte extra_totalField;

        private bool extra_totalFieldSpecified;

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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warningSpecified
        {
            get
            {
                return this.warningFieldSpecified;
            }
            set
            {
                this.warningFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning_total
        {
            get
            {
                return this.warning_totalField;
            }
            set
            {
                this.warning_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warning_totalSpecified
        {
            get
            {
                return this.warning_totalFieldSpecified;
            }
            set
            {
                this.warning_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra
        {
            get
            {
                return this.extraField;
            }
            set
            {
                this.extraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extraSpecified
        {
            get
            {
                return this.extraFieldSpecified;
            }
            set
            {
                this.extraFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra_total
        {
            get
            {
                return this.extra_totalField;
            }
            set
            {
                this.extra_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extra_totalSpecified
        {
            get
            {
                return this.extra_totalFieldSpecified;
            }
            set
            {
                this.extra_totalFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethod
    {

        private assembliesAssemblyNamespaceClassPropertyMethodAttributes attributesField;

        private assembliesAssemblyNamespaceClassPropertyMethodWarning[] warningsField;

        private assembliesAssemblyNamespaceClassPropertyMethodParameters parametersField;

        private string nameField;

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private byte warningField;

        private bool warningFieldSpecified;

        private byte warning_totalField;

        private bool warning_totalFieldSpecified;

        private byte extraField;

        private bool extraFieldSpecified;

        private byte extra_totalField;

        private bool extra_totalFieldSpecified;

        private string errorField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("warning", IsNullable = false)]
        public assembliesAssemblyNamespaceClassPropertyMethodWarning[] warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warningSpecified
        {
            get
            {
                return this.warningFieldSpecified;
            }
            set
            {
                this.warningFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning_total
        {
            get
            {
                return this.warning_totalField;
            }
            set
            {
                this.warning_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warning_totalSpecified
        {
            get
            {
                return this.warning_totalFieldSpecified;
            }
            set
            {
                this.warning_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra
        {
            get
            {
                return this.extraField;
            }
            set
            {
                this.extraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extraSpecified
        {
            get
            {
                return this.extraFieldSpecified;
            }
            set
            {
                this.extraFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra_total
        {
            get
            {
                return this.extra_totalField;
            }
            set
            {
                this.extra_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extra_totalSpecified
        {
            get
            {
                return this.extra_totalFieldSpecified;
            }
            set
            {
                this.extra_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
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

        private assembliesAssemblyNamespaceClassPropertyMethodAttributesAttributeWarnings warningsField;

        private string nameField;

        private string errorField;

        private string presenceField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyMethodAttributesAttributeWarnings warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
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
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethodAttributesAttributeWarnings
    {

        private assembliesAssemblyNamespaceClassPropertyMethodAttributesAttributeWarningsWarning warningField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassPropertyMethodAttributesAttributeWarningsWarning warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethodAttributesAttributeWarningsWarning
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassPropertyMethodWarning
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
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

        private string nameField;

        private string presenceField;

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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassEvent
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
    public partial class assembliesAssemblyNamespaceClassMethod
    {

        private assembliesAssemblyNamespaceClassMethodAttribute[] attributesField;

        private assembliesAssemblyNamespaceClassMethodWarning[] warningsField;

        private assembliesAssemblyNamespaceClassMethodParameter[] parametersField;

        private string nameField;

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private byte warningField;

        private bool warningFieldSpecified;

        private byte warning_totalField;

        private bool warning_totalFieldSpecified;

        private string errorField;

        private string presenceField;

        private byte extraField;

        private bool extraFieldSpecified;

        private byte extra_totalField;

        private bool extra_totalFieldSpecified;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("warning", IsNullable = false)]
        public assembliesAssemblyNamespaceClassMethodWarning[] warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warningSpecified
        {
            get
            {
                return this.warningFieldSpecified;
            }
            set
            {
                this.warningFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning_total
        {
            get
            {
                return this.warning_totalField;
            }
            set
            {
                this.warning_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warning_totalSpecified
        {
            get
            {
                return this.warning_totalFieldSpecified;
            }
            set
            {
                this.warning_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra
        {
            get
            {
                return this.extraField;
            }
            set
            {
                this.extraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extraSpecified
        {
            get
            {
                return this.extraFieldSpecified;
            }
            set
            {
                this.extraFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra_total
        {
            get
            {
                return this.extra_totalField;
            }
            set
            {
                this.extra_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extra_totalSpecified
        {
            get
            {
                return this.extra_totalFieldSpecified;
            }
            set
            {
                this.extra_totalFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodAttribute
    {

        private assembliesAssemblyNamespaceClassMethodAttributeWarnings warningsField;

        private string nameField;

        private string errorField;

        private string presenceField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassMethodAttributeWarnings warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
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
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodAttributeWarnings
    {

        private assembliesAssemblyNamespaceClassMethodAttributeWarningsWarning warningField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassMethodAttributeWarningsWarning warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodAttributeWarningsWarning
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodWarning
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassMethodParameter
    {

        private assembliesAssemblyNamespaceClassMethodParameterAttributes attributesField;

        private string nameField;

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

        private assembliesAssemblyNamespaceClassClassWarnings warningsField;

        private assembliesAssemblyNamespaceClassClassInterface[] interfacesField;

        private assembliesAssemblyNamespaceClassClassField[] fieldsField;

        private assembliesAssemblyNamespaceClassClassConstructor[] constructorsField;

        private assembliesAssemblyNamespaceClassClassProperty[] propertiesField;

        private assembliesAssemblyNamespaceClassClassEvent[] eventsField;

        private assembliesAssemblyNamespaceClassClassMethod[] methodsField;

        private assembliesAssemblyNamespaceClassClassClass[] classesField;

        private string nameField;

        private string typeField;

        private ushort presentField;

        private bool presentFieldSpecified;

        private ushort okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private ushort present_totalField;

        private bool present_totalFieldSpecified;

        private ushort ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private string errorField;

        private byte missingField;

        private bool missingFieldSpecified;

        private byte warningField;

        private bool warningFieldSpecified;

        private byte missing_totalField;

        private bool missing_totalFieldSpecified;

        private string presenceField;

        private byte extraField;

        private bool extraFieldSpecified;

        private byte extra_totalField;

        private bool extra_totalFieldSpecified;

        private byte warning_totalField;

        private bool warning_totalFieldSpecified;

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
        public assembliesAssemblyNamespaceClassClassWarnings warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
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
        public ushort present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte missing
        {
            get
            {
                return this.missingField;
            }
            set
            {
                this.missingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool missingSpecified
        {
            get
            {
                return this.missingFieldSpecified;
            }
            set
            {
                this.missingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warningSpecified
        {
            get
            {
                return this.warningFieldSpecified;
            }
            set
            {
                this.warningFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte missing_total
        {
            get
            {
                return this.missing_totalField;
            }
            set
            {
                this.missing_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool missing_totalSpecified
        {
            get
            {
                return this.missing_totalFieldSpecified;
            }
            set
            {
                this.missing_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra
        {
            get
            {
                return this.extraField;
            }
            set
            {
                this.extraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extraSpecified
        {
            get
            {
                return this.extraFieldSpecified;
            }
            set
            {
                this.extraFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra_total
        {
            get
            {
                return this.extra_totalField;
            }
            set
            {
                this.extra_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extra_totalSpecified
        {
            get
            {
                return this.extra_totalFieldSpecified;
            }
            set
            {
                this.extra_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning_total
        {
            get
            {
                return this.warning_totalField;
            }
            set
            {
                this.warning_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warning_totalSpecified
        {
            get
            {
                return this.warning_totalFieldSpecified;
            }
            set
            {
                this.warning_totalFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassAttribute
    {

        private string nameField;

        private string presenceField;

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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassWarnings
    {

        private assembliesAssemblyNamespaceClassClassWarningsWarning warningField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassWarningsWarning warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassWarningsWarning
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassInterface
    {

        private string nameField;

        private string presenceField;

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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassField
    {

        private assembliesAssemblyNamespaceClassClassFieldAttribute[] attributesField;

        private string nameField;

        private string presenceField;

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
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassFieldAttribute
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
    public partial class assembliesAssemblyNamespaceClassClassConstructor
    {

        private assembliesAssemblyNamespaceClassClassConstructorAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassConstructorParameter[] parametersField;

        private string nameField;

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private string presenceField;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
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
    public partial class assembliesAssemblyNamespaceClassClassConstructorParameter
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
    public partial class assembliesAssemblyNamespaceClassClassProperty
    {

        private assembliesAssemblyNamespaceClassClassPropertyMethod[] methodsField;

        private assembliesAssemblyNamespaceClassClassPropertyAttributes attributesField;

        private string nameField;

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private string presenceField;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassPropertyMethod
    {

        private object[] itemsField;

        private string nameField;

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(assembliesAssemblyNamespaceClassClassPropertyMethodAttributes))]
        [System.Xml.Serialization.XmlElementAttribute("parameters", typeof(assembliesAssemblyNamespaceClassClassPropertyMethodParameters))]
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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
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
    public partial class assembliesAssemblyNamespaceClassClassEvent
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
    public partial class assembliesAssemblyNamespaceClassClassMethod
    {

        private assembliesAssemblyNamespaceClassClassMethodAttribute[] attributesField;

        private assembliesAssemblyNamespaceClassClassMethodParameter[] parametersField;

        private string nameField;

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private byte warningField;

        private bool warningFieldSpecified;

        private byte warning_totalField;

        private bool warning_totalFieldSpecified;

        private string presenceField;

        private byte extraField;

        private bool extraFieldSpecified;

        private byte extra_totalField;

        private bool extra_totalFieldSpecified;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warningSpecified
        {
            get
            {
                return this.warningFieldSpecified;
            }
            set
            {
                this.warningFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte warning_total
        {
            get
            {
                return this.warning_totalField;
            }
            set
            {
                this.warning_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool warning_totalSpecified
        {
            get
            {
                return this.warning_totalFieldSpecified;
            }
            set
            {
                this.warning_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra
        {
            get
            {
                return this.extraField;
            }
            set
            {
                this.extraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extraSpecified
        {
            get
            {
                return this.extraFieldSpecified;
            }
            set
            {
                this.extraFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte extra_total
        {
            get
            {
                return this.extra_totalField;
            }
            set
            {
                this.extra_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool extra_totalSpecified
        {
            get
            {
                return this.extra_totalFieldSpecified;
            }
            set
            {
                this.extra_totalFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethodAttribute
    {

        private assembliesAssemblyNamespaceClassClassMethodAttributeWarnings warningsField;

        private string nameField;

        private string errorField;

        private string presenceField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassMethodAttributeWarnings warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
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
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethodAttributeWarnings
    {

        private assembliesAssemblyNamespaceClassClassMethodAttributeWarningsWarning warningField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassMethodAttributeWarningsWarning warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethodAttributeWarningsWarning
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassMethodParameter
    {

        private assembliesAssemblyNamespaceClassClassMethodParameterAttributes attributesField;

        private string nameField;

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

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        private string presenceField;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presence
        {
            get
            {
                return this.presenceField;
            }
            set
            {
                this.presenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class assembliesAssemblyNamespaceClassClassClassAttributes
    {

        private assembliesAssemblyNamespaceClassClassClassAttributesAttribute attributeField;

        /// <remarks/>
        public assembliesAssemblyNamespaceClassClassClassAttributesAttribute attribute
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

        private byte presentField;

        private byte okField;

        private byte completeField;

        private byte present_totalField;

        private byte ok_totalField;

        private byte complete_totalField;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
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

        private byte presentField;

        private byte okField;

        private byte completeField;

        private byte present_totalField;

        private byte ok_totalField;

        private byte complete_totalField;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
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
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassConstructorParameter
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
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassProperty
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassPropertyMethods methodsField;

        private string nameField;

        private byte presentField;

        private byte okField;

        private byte completeField;

        private byte present_totalField;

        private byte ok_totalField;

        private byte complete_totalField;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
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
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassMethod
    {

        private assembliesAssemblyNamespaceClassClassClassClassesClassMethodAttributes attributesField;

        private assembliesAssemblyNamespaceClassClassClassClassesClassMethodParameter[] parametersField;

        private string nameField;

        private byte presentField;

        private byte okField;

        private byte completeField;

        private byte present_totalField;

        private byte ok_totalField;

        private byte complete_totalField;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
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
    public partial class assembliesAssemblyNamespaceClassClassClassClassesClassMethodParameter
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

        private object[] itemsField;

        private string nameField;

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(assembliesAssemblyNamespaceClassClassClassConstructorsConstructorAttributes))]
        [System.Xml.Serialization.XmlElementAttribute("parameters", typeof(assembliesAssemblyNamespaceClassClassClassConstructorsConstructorParameters))]
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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
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
    public partial class assembliesAssemblyNamespaceClassClassClassConstructorsConstructorParameters
    {

        private assembliesAssemblyNamespaceClassClassClassConstructorsConstructorParametersParameter[] parameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameter")]
        public assembliesAssemblyNamespaceClassClassClassConstructorsConstructorParametersParameter[] parameter
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
    public partial class assembliesAssemblyNamespaceClassClassClassConstructorsConstructorParametersParameter
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

        private byte presentField;

        private byte okField;

        private byte completeField;

        private byte present_totalField;

        private byte ok_totalField;

        private byte complete_totalField;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
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
    public partial class assembliesAssemblyNamespaceClassClassClassMethodsMethodParameter
    {

        private assembliesAssemblyNamespaceClassClassClassMethodsMethodParameterAttributes attributesField;

        private string nameField;

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

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyMethod[] methodsField;

        private assembliesAssemblyNamespaceClassClassClassPropertiesPropertyAttributes attributesField;

        private string nameField;

        private byte presentField;

        private byte okField;

        private byte completeField;

        private byte present_totalField;

        private byte ok_totalField;

        private byte complete_totalField;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
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

        private byte presentField;

        private bool presentFieldSpecified;

        private byte okField;

        private bool okFieldSpecified;

        private byte completeField;

        private bool completeFieldSpecified;

        private byte present_totalField;

        private bool present_totalFieldSpecified;

        private byte ok_totalField;

        private bool ok_totalFieldSpecified;

        private byte complete_totalField;

        private bool complete_totalFieldSpecified;

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
        public byte present
        {
            get
            {
                return this.presentField;
            }
            set
            {
                this.presentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool presentSpecified
        {
            get
            {
                return this.presentFieldSpecified;
            }
            set
            {
                this.presentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok
        {
            get
            {
                return this.okField;
            }
            set
            {
                this.okField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool okSpecified
        {
            get
            {
                return this.okFieldSpecified;
            }
            set
            {
                this.okFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete
        {
            get
            {
                return this.completeField;
            }
            set
            {
                this.completeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool completeSpecified
        {
            get
            {
                return this.completeFieldSpecified;
            }
            set
            {
                this.completeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte present_total
        {
            get
            {
                return this.present_totalField;
            }
            set
            {
                this.present_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool present_totalSpecified
        {
            get
            {
                return this.present_totalFieldSpecified;
            }
            set
            {
                this.present_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ok_total
        {
            get
            {
                return this.ok_totalField;
            }
            set
            {
                this.ok_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ok_totalSpecified
        {
            get
            {
                return this.ok_totalFieldSpecified;
            }
            set
            {
                this.ok_totalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte complete_total
        {
            get
            {
                return this.complete_totalField;
            }
            set
            {
                this.complete_totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool complete_totalSpecified
        {
            get
            {
                return this.complete_totalFieldSpecified;
            }
            set
            {
                this.complete_totalFieldSpecified = value;
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


}
