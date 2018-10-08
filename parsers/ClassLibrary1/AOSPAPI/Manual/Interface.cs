using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.AOSPAPI
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class apiPackageInterface
    {

        private apiPackageInterfaceTypeParameters typeParametersField;

        private apiPackageInterfaceMethod[] methodField;

        private apiPackageInterfaceImplements implementsField;

        private bool abstractField;

        private string deprecatedField;

        private bool finalField;

        private string nameField;

        private bool staticField;

        private string visibilityField;

        /// <remarks/>
        public apiPackageInterfaceTypeParameters typeParameters
        {
            get
            {
                return this.typeParametersField;
            }
            set
            {
                this.typeParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("method")]
        public apiPackageInterfaceMethod[] method
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

        /// <remarks/>
        public apiPackageInterfaceImplements implements
        {
            get
            {
                return this.implementsField;
            }
            set
            {
                this.implementsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deprecated
        {
            get
            {
                return this.deprecatedField;
            }
            set
            {
                this.deprecatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool final
        {
            get
            {
                return this.finalField;
            }
            set
            {
                this.finalField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string visibility
        {
            get
            {
                return this.visibilityField;
            }
            set
            {
                this.visibilityField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class apiPackageInterfaceImplements
    {

        private string nameField;

        private string namegenericawareField;

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
        [System.Xml.Serialization.XmlAttributeAttribute("name-generic-aware")]
        public string namegenericaware
        {
            get
            {
                return this.namegenericawareField;
            }
            set
            {
                this.namegenericawareField = value;
            }
        }
    }

}
