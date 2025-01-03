using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTime {
    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main", IsNullable = false)]
    public partial class sld {

        private sldCSld cSldField;

        private sldClrMapOvr clrMapOvrField;

        private AlternateContent alternateContentField;

        private sldTiming timingField;

        private int showSldField = 1;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int show{
            get {
                return this.showSldField;
            }
            set {
                this.showSldField = value;
            }
        }

        /// <remarks/>
        public sldCSld cSld {
            get {
                return this.cSldField;
            }
            set {
                this.cSldField = value;
            }
        }

        /// <remarks/>
        public sldClrMapOvr clrMapOvr {
            get {
                return this.clrMapOvrField;
            }
            set {
                this.clrMapOvrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
        public AlternateContent AlternateContent {
            get {
                return this.alternateContentField;
            }
            set {
                this.alternateContentField = value;
            }
        }

        /// <remarks/>
        public sldTiming timing {
            get {
                return this.timingField;
            }
            set {
                this.timingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSld {

        private sldCSldSpTree spTreeField;

        private sldCSldExtLst extLstField;

        /// <remarks/>
        public sldCSldSpTree spTree {
            get {
                return this.spTreeField;
            }
            set {
                this.spTreeField = value;
            }
        }

        /// <remarks/>
        public sldCSldExtLst extLst {
            get {
                return this.extLstField;
            }
            set {
                this.extLstField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTree {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("grpSpPr", typeof(sldCSldSpTreeGrpSpPr))]
        [System.Xml.Serialization.XmlElementAttribute("nvGrpSpPr", typeof(sldCSldSpTreeNvGrpSpPr))]
        [System.Xml.Serialization.XmlElementAttribute("pic", typeof(sldCSldSpTreePic))]
        [System.Xml.Serialization.XmlElementAttribute("sp", typeof(sldCSldSpTreeSP))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeGrpSpPr {

        private xfrm xfrmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public xfrm xfrm {
            get {
                return this.xfrmField;
            }
            set {
                this.xfrmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class xfrm {

        private xfrmOff offField;

        private xfrmExt extField;

        private xfrmChOff chOffField;

        private xfrmChExt chExtField;

        /// <remarks/>
        public xfrmOff off {
            get {
                return this.offField;
            }
            set {
                this.offField = value;
            }
        }

        /// <remarks/>
        public xfrmExt ext {
            get {
                return this.extField;
            }
            set {
                this.extField = value;
            }
        }

        /// <remarks/>
        public xfrmChOff chOff {
            get {
                return this.chOffField;
            }
            set {
                this.chOffField = value;
            }
        }

        /// <remarks/>
        public xfrmChExt chExt {
            get {
                return this.chExtField;
            }
            set {
                this.chExtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class xfrmOff {

        private uint xField;

        private uint yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class xfrmExt {

        private uint cxField;

        private uint cyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint cx {
            get {
                return this.cxField;
            }
            set {
                this.cxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint cy {
            get {
                return this.cyField;
            }
            set {
                this.cyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class xfrmChOff {

        private byte xField;

        private byte yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class xfrmChExt {

        private byte cxField;

        private byte cyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cx {
            get {
                return this.cxField;
            }
            set {
                this.cxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cy {
            get {
                return this.cyField;
            }
            set {
                this.cyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeNvGrpSpPr {

        private sldCSldSpTreeNvGrpSpPrCNvPr cNvPrField;

        private object cNvGrpSpPrField;

        private object nvPrField;

        /// <remarks/>
        public sldCSldSpTreeNvGrpSpPrCNvPr cNvPr {
            get {
                return this.cNvPrField;
            }
            set {
                this.cNvPrField = value;
            }
        }

        /// <remarks/>
        public object cNvGrpSpPr {
            get {
                return this.cNvGrpSpPrField;
            }
            set {
                this.cNvGrpSpPrField = value;
            }
        }

        /// <remarks/>
        public object nvPr {
            get {
                return this.nvPrField;
            }
            set {
                this.nvPrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeNvGrpSpPrCNvPr {

        private byte idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreePic {

        private sldCSldSpTreePicNvPicPr nvPicPrField;

        private sldCSldSpTreePicBlipFill blipFillField;

        private sldCSldSpTreePicSpPr spPrField;

        /// <remarks/>
        public sldCSldSpTreePicNvPicPr nvPicPr {
            get {
                return this.nvPicPrField;
            }
            set {
                this.nvPicPrField = value;
            }
        }

        /// <remarks/>
        public sldCSldSpTreePicBlipFill blipFill {
            get {
                return this.blipFillField;
            }
            set {
                this.blipFillField = value;
            }
        }

        /// <remarks/>
        public sldCSldSpTreePicSpPr spPr {
            get {
                return this.spPrField;
            }
            set {
                this.spPrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreePicNvPicPr {

        private sldCSldSpTreePicNvPicPrCNvPr cNvPrField;

        private sldCSldSpTreePicNvPicPrCNvPicPr cNvPicPrField;

        private object nvPrField;

        /// <remarks/>
        public sldCSldSpTreePicNvPicPrCNvPr cNvPr {
            get {
                return this.cNvPrField;
            }
            set {
                this.cNvPrField = value;
            }
        }

        /// <remarks/>
        public sldCSldSpTreePicNvPicPrCNvPicPr cNvPicPr {
            get {
                return this.cNvPicPrField;
            }
            set {
                this.cNvPicPrField = value;
            }
        }

        /// <remarks/>
        public object nvPr {
            get {
                return this.nvPrField;
            }
            set {
                this.nvPrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreePicNvPicPrCNvPr {

        private extLst extLstField;

        private byte idField;

        private string nameField;

        private string descrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public extLst extLst {
            get {
                return this.extLstField;
            }
            set {
                this.extLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string descr {
            get {
                return this.descrField;
            }
            set {
                this.descrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class extLst {

        private extLstExt extField;

        /// <remarks/>
        public extLstExt ext {
            get {
                return this.extField;
            }
            set {
                this.extField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class extLstExt {

        private creationId creationIdField;

        private string uriField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/office/drawing/2014/main")]
        public creationId creationId {
            get {
                return this.creationIdField;
            }
            set {
                this.creationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/office/drawing/2014/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/office/drawing/2014/main", IsNullable = false)]
    public partial class creationId {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreePicNvPicPrCNvPicPr {

        private picLocks picLocksField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public picLocks picLocks {
            get {
                return this.picLocksField;
            }
            set {
                this.picLocksField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class picLocks {

        private byte noChangeAspectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte noChangeAspect {
            get {
                return this.noChangeAspectField;
            }
            set {
                this.noChangeAspectField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreePicBlipFill {

        private blip blipField;

        private stretch stretchField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public blip blip {
            get {
                return this.blipField;
            }
            set {
                this.blipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public stretch stretch {
            get {
                return this.stretchField;
            }
            set {
                this.stretchField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class blip {

        private blipExtLst extLstField;

        private string embedField;

        /// <remarks/>
        public blipExtLst extLst {
            get {
                return this.extLstField;
            }
            set {
                this.extLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
        public string embed {
            get {
                return this.embedField;
            }
            set {
                this.embedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class blipExtLst {

        private blipExtLstExt extField;

        /// <remarks/>
        public blipExtLstExt ext {
            get {
                return this.extField;
            }
            set {
                this.extField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class blipExtLstExt {

        private useLocalDpi useLocalDpiField;

        private string uriField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/office/drawing/2010/main")]
        public useLocalDpi useLocalDpi {
            get {
                return this.useLocalDpiField;
            }
            set {
                this.useLocalDpiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/office/drawing/2010/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/office/drawing/2010/main", IsNullable = false)]
    public partial class useLocalDpi {

        private byte valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class stretch {

        private object fillRectField;

        /// <remarks/>
        public object fillRect {
            get {
                return this.fillRectField;
            }
            set {
                this.fillRectField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreePicSpPr {

        private xfrm xfrmField;

        private prstGeom prstGeomField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public xfrm xfrm {
            get {
                return this.xfrmField;
            }
            set {
                this.xfrmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public prstGeom prstGeom {
            get {
                return this.prstGeomField;
            }
            set {
                this.prstGeomField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class prstGeom {

        private object avLstField;

        private string prstField;

        /// <remarks/>
        public object avLst {
            get {
                return this.avLstField;
            }
            set {
                this.avLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string prst {
            get {
                return this.prstField;
            }
            set {
                this.prstField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeSP {

        private sldCSldSpTreeSPNvSpPr nvSpPrField;

        private sldCSldSpTreeSPSpPr spPrField;

        private sldCSldSpTreeSPStyle styleField;

        private sldCSldSpTreeSPTxBody txBodyField;

        /// <remarks/>
        public sldCSldSpTreeSPNvSpPr nvSpPr {
            get {
                return this.nvSpPrField;
            }
            set {
                this.nvSpPrField = value;
            }
        }

        /// <remarks/>
        public sldCSldSpTreeSPSpPr spPr {
            get {
                return this.spPrField;
            }
            set {
                this.spPrField = value;
            }
        }

        /// <remarks/>
        public sldCSldSpTreeSPStyle style {
            get {
                return this.styleField;
            }
            set {
                this.styleField = value;
            }
        }

        /// <remarks/>
        public sldCSldSpTreeSPTxBody txBody {
            get {
                return this.txBodyField;
            }
            set {
                this.txBodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeSPNvSpPr {

        private sldCSldSpTreeSPNvSpPrCNvPr cNvPrField;

        private sldCSldSpTreeSPNvSpPrCNvSpPr cNvSpPrField;

        private sldCSldSpTreeSPNvSpPrNvPr nvPrField;

        /// <remarks/>
        public sldCSldSpTreeSPNvSpPrCNvPr cNvPr {
            get {
                return this.cNvPrField;
            }
            set {
                this.cNvPrField = value;
            }
        }

        /// <remarks/>
        public sldCSldSpTreeSPNvSpPrCNvSpPr cNvSpPr {
            get {
                return this.cNvSpPrField;
            }
            set {
                this.cNvSpPrField = value;
            }
        }

        /// <remarks/>
        public sldCSldSpTreeSPNvSpPrNvPr nvPr {
            get {
                return this.nvPrField;
            }
            set {
                this.nvPrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeSPNvSpPrCNvPr {

        private extLst extLstField;

        private byte idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public extLst extLst {
            get {
                return this.extLstField;
            }
            set {
                this.extLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeSPNvSpPrCNvSpPr {

        private spLocks spLocksField;

        private byte txBoxField;

        private bool txBoxFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public spLocks spLocks {
            get {
                return this.spLocksField;
            }
            set {
                this.spLocksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte txBox {
            get {
                return this.txBoxField;
            }
            set {
                this.txBoxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool txBoxSpecified {
            get {
                return this.txBoxFieldSpecified;
            }
            set {
                this.txBoxFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class spLocks {

        private byte noGrpField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte noGrp {
            get {
                return this.noGrpField;
            }
            set {
                this.noGrpField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeSPNvSpPrNvPr {

        private sldCSldSpTreeSPNvSpPrNvPrPH phField;

        /// <remarks/>
        public sldCSldSpTreeSPNvSpPrNvPrPH ph {
            get {
                return this.phField;
            }
            set {
                this.phField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeSPNvSpPrNvPrPH {

        private string typeField;

        private byte idxField;

        private bool idxFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte idx {
            get {
                return this.idxField;
            }
            set {
                this.idxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idxSpecified {
            get {
                return this.idxFieldSpecified;
            }
            set {
                this.idxFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeSPSpPr {

        private xfrm xfrmField;

        private prstGeom prstGeomField;

        private object noFillField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public xfrm xfrm {
            get {
                return this.xfrmField;
            }
            set {
                this.xfrmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public prstGeom prstGeom {
            get {
                return this.prstGeomField;
            }
            set {
                this.prstGeomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public object noFill {
            get {
                return this.noFillField;
            }
            set {
                this.noFillField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeSPStyle {

        private lnRef lnRefField;

        private fillRef fillRefField;

        private effectRef effectRefField;

        private fontRef fontRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public lnRef lnRef {
            get {
                return this.lnRefField;
            }
            set {
                this.lnRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public fillRef fillRef {
            get {
                return this.fillRefField;
            }
            set {
                this.fillRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public effectRef effectRef {
            get {
                return this.effectRefField;
            }
            set {
                this.effectRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public fontRef fontRef {
            get {
                return this.fontRefField;
            }
            set {
                this.fontRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class lnRef {

        private lnRefSchemeClr schemeClrField;

        private byte idxField;

        /// <remarks/>
        public lnRefSchemeClr schemeClr {
            get {
                return this.schemeClrField;
            }
            set {
                this.schemeClrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte idx {
            get {
                return this.idxField;
            }
            set {
                this.idxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class lnRefSchemeClr {

        private lnRefSchemeClrShade shadeField;

        private string valField;

        /// <remarks/>
        public lnRefSchemeClrShade shade {
            get {
                return this.shadeField;
            }
            set {
                this.shadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class lnRefSchemeClrShade {

        private ushort valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class fillRef {

        private fillRefSchemeClr schemeClrField;

        private byte idxField;

        /// <remarks/>
        public fillRefSchemeClr schemeClr {
            get {
                return this.schemeClrField;
            }
            set {
                this.schemeClrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte idx {
            get {
                return this.idxField;
            }
            set {
                this.idxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class fillRefSchemeClr {

        private string valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class effectRef {

        private effectRefSchemeClr schemeClrField;

        private byte idxField;

        /// <remarks/>
        public effectRefSchemeClr schemeClr {
            get {
                return this.schemeClrField;
            }
            set {
                this.schemeClrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte idx {
            get {
                return this.idxField;
            }
            set {
                this.idxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class effectRefSchemeClr {

        private string valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class fontRef {

        private fontRefSchemeClr schemeClrField;

        private string idxField;

        /// <remarks/>
        public fontRefSchemeClr schemeClr {
            get {
                return this.schemeClrField;
            }
            set {
                this.schemeClrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string idx {
            get {
                return this.idxField;
            }
            set {
                this.idxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class fontRefSchemeClr {

        private string valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldSpTreeSPTxBody {

        private bodyPr bodyPrField;

        private object lstStyleField;

        private p pField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public bodyPr bodyPr {
            get {
                return this.bodyPrField;
            }
            set {
                this.bodyPrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public object lstStyle {
            get {
                return this.lstStyleField;
            }
            set {
                this.lstStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public p p {
            get {
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class bodyPr {

        private object spAutoFitField;

        private string wrapField;

        private byte rtlColField;

        private bool rtlColFieldSpecified;

        private string anchorField;

        /// <remarks/>
        public object spAutoFit {
            get {
                return this.spAutoFitField;
            }
            set {
                this.spAutoFitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wrap {
            get {
                return this.wrapField;
            }
            set {
                this.wrapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rtlCol {
            get {
                return this.rtlColField;
            }
            set {
                this.rtlColField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rtlColSpecified {
            get {
                return this.rtlColFieldSpecified;
            }
            set {
                this.rtlColFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anchor {
            get {
                return this.anchorField;
            }
            set {
                this.anchorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
    public partial class p {

        private pPPr pPrField;

        private pR rField;

        private pEndParaRPr endParaRPrField;

        /// <remarks/>
        public pPPr pPr {
            get {
                return this.pPrField;
            }
            set {
                this.pPrField = value;
            }
        }

        /// <remarks/>
        public pR r {
            get {
                return this.rField;
            }
            set {
                this.rField = value;
            }
        }

        /// <remarks/>
        public pEndParaRPr endParaRPr {
            get {
                return this.endParaRPrField;
            }
            set {
                this.endParaRPrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class pPPr {

        private string algnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string algn {
            get {
                return this.algnField;
            }
            set {
                this.algnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class pR {

        private pRRPr rPrField;

        private string tField;

        /// <remarks/>
        public pRRPr rPr {
            get {
                return this.rPrField;
            }
            set {
                this.rPrField = value;
            }
        }

        /// <remarks/>
        public string t {
            get {
                return this.tField;
            }
            set {
                this.tField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class pRRPr {

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
    public partial class pEndParaRPr {

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldExtLst {

        private sldCSldExtLstExt extField;

        /// <remarks/>
        public sldCSldExtLstExt ext {
            get {
                return this.extField;
            }
            set {
                this.extField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldCSldExtLstExt {

        private creationId1 creationIdField;

        private string uriField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/office/powerpoint/2010/main")]
        public creationId1 creationId {
            get {
                return this.creationIdField;
            }
            set {
                this.creationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/office/powerpoint/2010/main")]
    [System.Xml.Serialization.XmlRootAttribute("creationId", Namespace = "http://schemas.microsoft.com/office/powerpoint/2010/main", IsNullable = false)]
    public partial class creationId1 {

        private uint valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldClrMapOvr {

        private object masterClrMappingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
        public object masterClrMapping {
            get {
                return this.masterClrMappingField;
            }
            set {
                this.masterClrMappingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006", IsNullable = false)]
    public partial class AlternateContent {

        private object[] choiceField;
        //private AlternateContentChoice choiceField;

        private AlternateContentFallback fallbackField;

        [System.Xml.Serialization.XmlElementAttribute()]
        /// <remarks/>
        public object[] Choice {
        //public AlternateContentChoice Choice {
            get {
                return this.choiceField;
            }
            set {
                this.choiceField = value;
            }
        }

        /// <remarks/>
        public AlternateContentFallback Fallback {
            get {
                return this.fallbackField;
            }
            set {
                this.fallbackField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
    public partial class AlternateContentChoice {

        private transition transitionField;

        private string requiresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
        public transition transition {
            get {
                return this.transitionField;
            }
            set {
                this.transitionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Requires {
            get {
                return this.requiresField;
            }
            set {
                this.requiresField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main", IsNullable = false)]
    public partial class transition {

        private object fadeField;

        private morph morphField;

        private string spdField;

        private byte advClickField;

        private ushort advTmField;

        /// <remarks/>
        public object fade {
            get {
                return this.fadeField;
            }
            set {
                this.fadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/office/powerpoint/2015/09/main")]
        public morph morph {
            get {
                return this.morphField;
            }
            set {
                this.morphField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spd {
            get {
                return this.spdField;
            }
            set {
                this.spdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte advClick {
            get {
                return this.advClickField;
            }
            set {
                this.advClickField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort advTm {
            get {
                return this.advTmField;
            }
            set {
                this.advTmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/office/powerpoint/2015/09/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/office/powerpoint/2015/09/main", IsNullable = false)]
    public partial class morph {

        private string optionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
    public partial class AlternateContentFallback {

        private transition transitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
        public transition transition {
            get {
                return this.transitionField;
            }
            set {
                this.transitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTiming {

        private sldTimingTnLst tnLstField;

        private sldTimingBldP[] bldLstField;

        /// <remarks/>
        public sldTimingTnLst tnLst {
            get {
                return this.tnLstField;
            }
            set {
                this.tnLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("bldP", IsNullable = false)]
        public sldTimingBldP[] bldLst {
            get {
                return this.bldLstField;
            }
            set {
                this.bldLstField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLst {

        private sldTimingTnLstPar parField;

        /// <remarks/>
        public sldTimingTnLstPar par {
            get {
                return this.parField;
            }
            set {
                this.parField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstPar {

        private sldTimingTnLstParCTn cTnField;

        /// <remarks/>
        public sldTimingTnLstParCTn cTn {
            get {
                return this.cTnField;
            }
            set {
                this.cTnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTn {

        private sldTimingTnLstParCTnChildTnLst childTnLstField;

        private byte idField;

        private string durField;

        private string restartField;

        private string nodeTypeField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLst childTnLst {
            get {
                return this.childTnLstField;
            }
            set {
                this.childTnLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dur {
            get {
                return this.durField;
            }
            set {
                this.durField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string restart {
            get {
                return this.restartField;
            }
            set {
                this.restartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeType {
            get {
                return this.nodeTypeField;
            }
            set {
                this.nodeTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLst {

        private sldTimingTnLstParCTnChildTnLstSeq seqField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeq seq {
            get {
                return this.seqField;
            }
            set {
                this.seqField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeq {

        private sldTimingTnLstParCTnChildTnLstSeqCTn cTnField;

        private sldTimingTnLstParCTnChildTnLstSeqPrevCondLst prevCondLstField;

        private sldTimingTnLstParCTnChildTnLstSeqNextCondLst nextCondLstField;

        private byte concurrentField;

        private string nextAcField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTn cTn {
            get {
                return this.cTnField;
            }
            set {
                this.cTnField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqPrevCondLst prevCondLst {
            get {
                return this.prevCondLstField;
            }
            set {
                this.prevCondLstField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqNextCondLst nextCondLst {
            get {
                return this.nextCondLstField;
            }
            set {
                this.nextCondLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte concurrent {
            get {
                return this.concurrentField;
            }
            set {
                this.concurrentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nextAc {
            get {
                return this.nextAcField;
            }
            set {
                this.nextAcField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTn {

        private sldTimingTnLstParCTnChildTnLstSeqCTnPar[] childTnLstField;

        private byte idField;

        private string durField;

        private string nodeTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("par", IsNullable = false)]
        public sldTimingTnLstParCTnChildTnLstSeqCTnPar[] childTnLst {
            get {
                return this.childTnLstField;
            }
            set {
                this.childTnLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dur {
            get {
                return this.durField;
            }
            set {
                this.durField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeType {
            get {
                return this.nodeTypeField;
            }
            set {
                this.nodeTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnPar {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTn cTnField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTn cTn {
            get {
                return this.cTnField;
            }
            set {
                this.cTnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTn {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnStCondLst stCondLstField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLst childTnLstField;

        private byte idField;

        private string fillField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnStCondLst stCondLst {
            get {
                return this.stCondLstField;
            }
            set {
                this.stCondLstField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLst childTnLst {
            get {
                return this.childTnLstField;
            }
            set {
                this.childTnLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnStCondLst {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnStCondLstCond condField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnStCondLstCond cond {
            get {
                return this.condField;
            }
            set {
                this.condField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnStCondLstCond {

        private string delayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string delay {
            get {
                return this.delayField;
            }
            set {
                this.delayField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLst {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstPar parField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstPar par {
            get {
                return this.parField;
            }
            set {
                this.parField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstPar {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTn cTnField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTn cTn {
            get {
                return this.cTnField;
            }
            set {
                this.cTnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTn {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnStCondLst stCondLstField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnPar[] childTnLstField;

        private byte idField;

        private string fillField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnStCondLst stCondLst {
            get {
                return this.stCondLstField;
            }
            set {
                this.stCondLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("par", IsNullable = false)]
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnPar[] childTnLst {
            get {
                return this.childTnLstField;
            }
            set {
                this.childTnLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnStCondLst {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnStCondLstCond condField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnStCondLstCond cond {
            get {
                return this.condField;
            }
            set {
                this.condField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnStCondLstCond {

        private byte delayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte delay {
            get {
                return this.delayField;
            }
            set {
                this.delayField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnPar {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTn cTnField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTn cTn {
            get {
                return this.cTnField;
            }
            set {
                this.cTnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTn {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnStCondLst stCondLstField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLst childTnLstField;

        private byte idField;

        private byte presetIDField;

        private string presetClassField;

        private byte presetSubtypeField;

        private string fillField;

        private byte grpIdField;

        private bool grpIdFieldSpecified;

        private string nodeTypeField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnStCondLst stCondLst {
            get {
                return this.stCondLstField;
            }
            set {
                this.stCondLstField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLst childTnLst {
            get {
                return this.childTnLstField;
            }
            set {
                this.childTnLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte presetID {
            get {
                return this.presetIDField;
            }
            set {
                this.presetIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string presetClass {
            get {
                return this.presetClassField;
            }
            set {
                this.presetClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte presetSubtype {
            get {
                return this.presetSubtypeField;
            }
            set {
                this.presetSubtypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte grpId {
            get {
                return this.grpIdField;
            }
            set {
                this.grpIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grpIdSpecified {
            get {
                return this.grpIdFieldSpecified;
            }
            set {
                this.grpIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeType {
            get {
                return this.nodeTypeField;
            }
            set {
                this.nodeTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnStCondLst {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnStCondLstCond condField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnStCondLstCond cond {
            get {
                return this.condField;
            }
            set {
                this.condField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnStCondLstCond {

        private ushort delayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort delay {
            get {
                return this.delayField;
            }
            set {
                this.delayField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLst {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("anim", typeof(sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnim))]
        [System.Xml.Serialization.XmlElementAttribute("animEffect", typeof(sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffect))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSet))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnim {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvr cBhvrField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTav[] tavLstField;

        private string calcmodeField;

        private string valueTypeField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvr cBhvr {
            get {
                return this.cBhvrField;
            }
            set {
                this.cBhvrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("tav", IsNullable = false)]
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTav[] tavLst {
            get {
                return this.tavLstField;
            }
            set {
                this.tavLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string calcmode {
            get {
                return this.calcmodeField;
            }
            set {
                this.calcmodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueType {
            get {
                return this.valueTypeField;
            }
            set {
                this.valueTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvr {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrCTn cTnField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrTgtEl tgtElField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrAttrNameLst attrNameLstField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrCTn cTn {
            get {
                return this.cTnField;
            }
            set {
                this.cTnField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrTgtEl tgtEl {
            get {
                return this.tgtElField;
            }
            set {
                this.tgtElField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrAttrNameLst attrNameLst {
            get {
                return this.attrNameLstField;
            }
            set {
                this.attrNameLstField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrCTn {

        private byte idField;

        private ushort durField;

        private string fillField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort dur {
            get {
                return this.durField;
            }
            set {
                this.durField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrTgtEl {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrTgtElSpTgt spTgtField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrTgtElSpTgt spTgt {
            get {
                return this.spTgtField;
            }
            set {
                this.spTgtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrTgtElSpTgt {

        private byte spidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte spid {
            get {
                return this.spidField;
            }
            set {
                this.spidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimCBhvrAttrNameLst {

        private string attrNameField;

        /// <remarks/>
        public string attrName {
            get {
                return this.attrNameField;
            }
            set {
                this.attrNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTav {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTavVal valField;

        private uint tmField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTavVal val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint tm {
            get {
                return this.tmField;
            }
            set {
                this.tmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTavVal {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTavValFltVal fltValField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTavValStrVal strValField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTavValFltVal fltVal {
            get {
                return this.fltValField;
            }
            set {
                this.fltValField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTavValStrVal strVal {
            get {
                return this.strValField;
            }
            set {
                this.strValField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTavValFltVal {

        private byte valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimTavValStrVal {

        private string valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffect {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvr cBhvrField;

        private string transitionField;

        private string filterField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvr cBhvr {
            get {
                return this.cBhvrField;
            }
            set {
                this.cBhvrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transition {
            get {
                return this.transitionField;
            }
            set {
                this.transitionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvr {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvrCTn cTnField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvrTgtEl tgtElField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvrCTn cTn {
            get {
                return this.cTnField;
            }
            set {
                this.cTnField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvrTgtEl tgtEl {
            get {
                return this.tgtElField;
            }
            set {
                this.tgtElField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvrCTn {

        private byte idField;

        private ushort durField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort dur {
            get {
                return this.durField;
            }
            set {
                this.durField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvrTgtEl {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvrTgtElSpTgt spTgtField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvrTgtElSpTgt spTgt {
            get {
                return this.spTgtField;
            }
            set {
                this.spTgtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstAnimEffectCBhvrTgtElSpTgt {

        private byte spidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte spid {
            get {
                return this.spidField;
            }
            set {
                this.spidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSet {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvr cBhvrField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetTO toField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvr cBhvr {
            get {
                return this.cBhvrField;
            }
            set {
                this.cBhvrField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetTO to {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvr {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrCTn cTnField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrTgtEl tgtElField;

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrAttrNameLst attrNameLstField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrCTn cTn {
            get {
                return this.cTnField;
            }
            set {
                this.cTnField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrTgtEl tgtEl {
            get {
                return this.tgtElField;
            }
            set {
                this.tgtElField = value;
            }
        }

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrAttrNameLst attrNameLst {
            get {
                return this.attrNameLstField;
            }
            set {
                this.attrNameLstField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrCTn {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrCTnStCondLst stCondLstField;

        private byte idField;

        private byte durField;

        private string fillField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrCTnStCondLst stCondLst {
            get {
                return this.stCondLstField;
            }
            set {
                this.stCondLstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dur {
            get {
                return this.durField;
            }
            set {
                this.durField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrCTnStCondLst {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrCTnStCondLstCond condField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrCTnStCondLstCond cond {
            get {
                return this.condField;
            }
            set {
                this.condField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrCTnStCondLstCond {

        private ushort delayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort delay {
            get {
                return this.delayField;
            }
            set {
                this.delayField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrTgtEl {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrTgtElSpTgt spTgtField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrTgtElSpTgt spTgt {
            get {
                return this.spTgtField;
            }
            set {
                this.spTgtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrTgtElSpTgt {

        private byte spidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte spid {
            get {
                return this.spidField;
            }
            set {
                this.spidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetCBhvrAttrNameLst {

        private string attrNameField;

        /// <remarks/>
        public string attrName {
            get {
                return this.attrNameField;
            }
            set {
                this.attrNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetTO {

        private sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetTOStrVal strValField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetTOStrVal strVal {
            get {
                return this.strValField;
            }
            set {
                this.strValField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqCTnParCTnChildTnLstParCTnParCTnChildTnLstSetTOStrVal {

        private string valField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqPrevCondLst {

        private sldTimingTnLstParCTnChildTnLstSeqPrevCondLstCond condField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqPrevCondLstCond cond {
            get {
                return this.condField;
            }
            set {
                this.condField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqPrevCondLstCond {

        private sldTimingTnLstParCTnChildTnLstSeqPrevCondLstCondTgtEl tgtElField;

        private string evtField;

        private byte delayField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqPrevCondLstCondTgtEl tgtEl {
            get {
                return this.tgtElField;
            }
            set {
                this.tgtElField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string evt {
            get {
                return this.evtField;
            }
            set {
                this.evtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte delay {
            get {
                return this.delayField;
            }
            set {
                this.delayField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqPrevCondLstCondTgtEl {

        private object sldTgtField;

        /// <remarks/>
        public object sldTgt {
            get {
                return this.sldTgtField;
            }
            set {
                this.sldTgtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqNextCondLst {

        private sldTimingTnLstParCTnChildTnLstSeqNextCondLstCond condField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqNextCondLstCond cond {
            get {
                return this.condField;
            }
            set {
                this.condField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqNextCondLstCond {

        private sldTimingTnLstParCTnChildTnLstSeqNextCondLstCondTgtEl tgtElField;

        private string evtField;

        private byte delayField;

        /// <remarks/>
        public sldTimingTnLstParCTnChildTnLstSeqNextCondLstCondTgtEl tgtEl {
            get {
                return this.tgtElField;
            }
            set {
                this.tgtElField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string evt {
            get {
                return this.evtField;
            }
            set {
                this.evtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte delay {
            get {
                return this.delayField;
            }
            set {
                this.delayField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingTnLstParCTnChildTnLstSeqNextCondLstCondTgtEl {

        private object sldTgtField;

        /// <remarks/>
        public object sldTgt {
            get {
                return this.sldTgtField;
            }
            set {
                this.sldTgtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/presentationml/2006/main")]
    public partial class sldTimingBldP {

        private byte spidField;

        private byte grpIdField;

        private byte animBgField;

        private bool animBgFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte spid {
            get {
                return this.spidField;
            }
            set {
                this.spidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte grpId {
            get {
                return this.grpIdField;
            }
            set {
                this.grpIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte animBg {
            get {
                return this.animBgField;
            }
            set {
                this.animBgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool animBgSpecified {
            get {
                return this.animBgFieldSpecified;
            }
            set {
                this.animBgFieldSpecified = value;
            }
        }
    }


}
