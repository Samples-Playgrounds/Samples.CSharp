using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Android.Repository
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class addon
    {

        private addonLicense[] licenseField;

        private addonAddon[] addon1Field;

        private addonExtra[] extraField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("license")]
        public addonLicense[] license
        {
            get
            {
                return this.licenseField;
            }
            set
            {
                this.licenseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("add-on")]
        public addonAddon[] addon1
        {
            get
            {
                return this.addon1Field;
            }
            set
            {
                this.addon1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extra")]
        public addonExtra[] extra
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class addonLicense
    {

        private string idField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
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
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    public partial class addonAddon
    {

        private object obsoleteField;

        private byte revisionField;

        private addonAddonArchives archivesField;

        private addonAddonUseslicense useslicenseField;

        private string vendoridField;

        private string vendordisplayField;

        private string nameidField;

        private string namedisplayField;

        private byte apilevelField;

        private string descriptionField;

        private string descurlField;

        private addonAddonLib[] libsField;

        /// <remarks/>
        public object obsolete
        {
            get
            {
                return this.obsoleteField;
            }
            set
            {
                this.obsoleteField = value;
            }
        }

        /// <remarks/>
        public byte revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        public addonAddonArchives archives
        {
            get
            {
                return this.archivesField;
            }
            set
            {
                this.archivesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("uses-license")]
        public addonAddonUseslicense useslicense
        {
            get
            {
                return this.useslicenseField;
            }
            set
            {
                this.useslicenseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendor-id")]
        public string vendorid
        {
            get
            {
                return this.vendoridField;
            }
            set
            {
                this.vendoridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendor-display")]
        public string vendordisplay
        {
            get
            {
                return this.vendordisplayField;
            }
            set
            {
                this.vendordisplayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name-id")]
        public string nameid
        {
            get
            {
                return this.nameidField;
            }
            set
            {
                this.nameidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name-display")]
        public string namedisplay
        {
            get
            {
                return this.namedisplayField;
            }
            set
            {
                this.namedisplayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("api-level")]
        public byte apilevel
        {
            get
            {
                return this.apilevelField;
            }
            set
            {
                this.apilevelField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("desc-url")]
        public string descurl
        {
            get
            {
                return this.descurlField;
            }
            set
            {
                this.descurlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("lib", IsNullable = false)]
        public addonAddonLib[] libs
        {
            get
            {
                return this.libsField;
            }
            set
            {
                this.libsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class addonAddonArchives
    {

        private addonAddonArchivesArchive archiveField;

        /// <remarks/>
        public addonAddonArchivesArchive archive
        {
            get
            {
                return this.archiveField;
            }
            set
            {
                this.archiveField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class addonAddonArchivesArchive
    {

        private uint sizeField;

        private addonAddonArchivesArchiveChecksum checksumField;

        private string urlField;

        /// <remarks/>
        public uint size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public addonAddonArchivesArchiveChecksum checksum
        {
            get
            {
                return this.checksumField;
            }
            set
            {
                this.checksumField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class addonAddonArchivesArchiveChecksum
    {

        private string typeField;

        private string valueField;

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
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    public partial class addonAddonUseslicense
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class addonAddonLib
    {

        private string nameField;

        private string descriptionField;

        /// <remarks/>
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
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class addonExtra
    {

        private object obsoleteField;

        private addonExtraRevision revisionField;

        private addonExtraArchive[] archivesField;

        private addonExtraUseslicense useslicenseField;

        private string vendoridField;

        private string vendordisplayField;

        private string descriptionField;

        private string descurlField;

        private string namedisplayField;

        private string pathField;

        /// <remarks/>
        public object obsolete
        {
            get
            {
                return this.obsoleteField;
            }
            set
            {
                this.obsoleteField = value;
            }
        }

        /// <remarks/>
        public addonExtraRevision revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("archive", IsNullable = false)]
        public addonExtraArchive[] archives
        {
            get
            {
                return this.archivesField;
            }
            set
            {
                this.archivesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("uses-license")]
        public addonExtraUseslicense useslicense
        {
            get
            {
                return this.useslicenseField;
            }
            set
            {
                this.useslicenseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendor-id")]
        public string vendorid
        {
            get
            {
                return this.vendoridField;
            }
            set
            {
                this.vendoridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendor-display")]
        public string vendordisplay
        {
            get
            {
                return this.vendordisplayField;
            }
            set
            {
                this.vendordisplayField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("desc-url")]
        public string descurl
        {
            get
            {
                return this.descurlField;
            }
            set
            {
                this.descurlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name-display")]
        public string namedisplay
        {
            get
            {
                return this.namedisplayField;
            }
            set
            {
                this.namedisplayField = value;
            }
        }

        /// <remarks/>
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class addonExtraRevision
    {

        private byte majorField;

        private byte minorField;

        private bool minorFieldSpecified;

        private byte microField;

        private bool microFieldSpecified;

        /// <remarks/>
        public byte major
        {
            get
            {
                return this.majorField;
            }
            set
            {
                this.majorField = value;
            }
        }

        /// <remarks/>
        public byte minor
        {
            get
            {
                return this.minorField;
            }
            set
            {
                this.minorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minorSpecified
        {
            get
            {
                return this.minorFieldSpecified;
            }
            set
            {
                this.minorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte micro
        {
            get
            {
                return this.microField;
            }
            set
            {
                this.microField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool microSpecified
        {
            get
            {
                return this.microFieldSpecified;
            }
            set
            {
                this.microFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class addonExtraArchive
    {

        private uint sizeField;

        private addonExtraArchiveChecksum checksumField;

        private string urlField;

        private string hostosField;

        /// <remarks/>
        public uint size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public addonExtraArchiveChecksum checksum
        {
            get
            {
                return this.checksumField;
            }
            set
            {
                this.checksumField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("host-os")]
        public string hostos
        {
            get
            {
                return this.hostosField;
            }
            set
            {
                this.hostosField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class addonExtraArchiveChecksum
    {

        private string typeField;

        private string valueField;

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
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    public partial class addonExtraUseslicense
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }


}
