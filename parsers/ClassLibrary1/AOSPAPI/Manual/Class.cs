using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.AOSPAPI
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "class", AnonymousType = true)]
    public partial class Class
    {

        private object[] itemsField;

        private bool abstractField;

        private string deprecatedField;

        private string extendsField;

        private string extendsgenericawareField;

        private bool finalField;

        private string nameField;

        private bool staticField;

        private string visibilityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("constructor", typeof(apiPackageClassConstructor))]
        [System.Xml.Serialization.XmlElementAttribute("field", typeof(apiPackageClassField))]
        [System.Xml.Serialization.XmlElementAttribute("implements", typeof(apiPackageClassImplements))]
        [System.Xml.Serialization.XmlElementAttribute("method", typeof(Method))]
        [System.Xml.Serialization.XmlElementAttribute("typeParameters", typeof(apiPackageClassTypeParameters))]
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
        public string extends
        {
            get
            {
                return this.extendsField;
            }
            set
            {
                this.extendsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("extends-generic-aware")]
        public string extendsgenericaware
        {
            get
            {
                return this.extendsgenericawareField;
            }
            set
            {
                this.extendsgenericawareField = value;
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
    public partial class apiPackageClassImplements
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
