using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.AOSPAPI
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "api", AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Api
    {

        private Package[] packageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("package")]
        public Package[] package
        {
            get
            {
                return this.packageField;
            }
            set
            {
                this.packageField = value;
            }
        }
    }
}
